using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using VRPWindowsForms.DTO;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System.Data.Entity;
using VRPWindowsForms.Models;
using VRPWindowsForms.Services;

namespace VRPWindowsForms
{
    public partial class Form1 : Form
    {
        GMapOverlay gMapOverlay;
        GMapOverlay storePointsOverlay;
        GMapOverlay routesOverlay;
        private List<Order> Orders;
        private List<OrderDTO> OrdersDTO;
        private List<Car> Cars;
        private List<MapRouteDTO> routes;
        private static BindingList<MapPoint> points;
        private static BindingList<MapPoint> addedPoints;
        private static BindingList<OrderDTO> orders;
        private static BindingList<StoreDTO> stores;
        private static BindingList<CustomerDTO> customers; 
        private DatabaseContext context;
        public Form1()
        {
            InitializeComponent();

            context = new DatabaseContext();

            SampleData data = new SampleData(context);
            data.GetSample();

            Orders = new List<Order>();
            OrdersDTO = new List<OrderDTO>();
            Cars = new List<Car>();
            points = new BindingList<MapPoint>();
            addedPoints = new BindingList<MapPoint>();
            orders = new BindingList<OrderDTO>();
            stores = new BindingList<StoreDTO>();
            customers = new BindingList<CustomerDTO>();

            routes = new List<MapRouteDTO>();

            // Initialization of map
            gmap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            gmap.DragButton = MouseButtons.Left;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gmap.Position = new PointLatLng(49.838583451783904, 24.030081329423524);
            gMapOverlay = new GMapOverlay("markers");
            gmap.Overlays.Add(gMapOverlay);
            routesOverlay = new GMapOverlay("routes");
            gmap.Overlays.Add(routesOverlay);
            storePointsOverlay = new GMapOverlay("markers");
            gmap.Overlays.Add(storePointsOverlay);

            pointsDropDown.DataSource = new BindingSource(points, null);
            pointsDropDown.DisplayMember = "StreetName";
            addedRouteGrid.DataSource = new BindingSource(addedPoints, null);
            addedRouteGrid.Columns["CarID"].Visible = false;
            addedRouteGrid.Columns.Add(
                new DataGridViewButtonColumn()
                {
                    HeaderText = "Action",
                    //CellTemplate = new DataGridViewButtonCell(),
                    Tag = (Action<MapPoint>)RemoveFromAddDataGrid,
                    Text = "Remove",
                    UseColumnTextForButtonValue = true
                });
            addedRouteGrid.CellContentClick += AddedRouteGrid_CellContentClick;

            comboBox1.DataSource = new BindingSource(stores, null);
            comboBox1.DisplayMember = "StoreName";

            LoadOrders();

            LoadStores();

            LoadCars();

            LoadCustomers();

            LoadFilter();

            SetCustomerFilter();
        }
        private void AddedRouteGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;

            if (e.RowIndex < 0)
            {
                //They clicked the header column, do nothing
                return;
            }

            if (grid[e.ColumnIndex, e.RowIndex] is DataGridViewButtonCell)
            {
                var clickHandler = (Action<MapPoint>)grid.Columns[e.ColumnIndex].Tag;
                var point = (MapPoint)grid.Rows[e.RowIndex].DataBoundItem;

                clickHandler(point);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (carsDropDown.SelectedItem == null)
            {
                MessageBox.Show("You have to choose car first.", "Error!");
                return;
            }
            if (pointsDropDown.Items.Count == 0)
            {
                MessageBox.Show("There are no points to add.", "Error!");
                return;
            }
            MapPoint selectedPoint = (MapPoint)pointsDropDown.SelectedItem;

            var order = context.Orders.Where(item => item.ID == selectedPoint.ID).FirstOrDefault();
            if (order != null)
            {
                var car = (Car)carsDropDown.SelectedItem;
                order.OrderStatus = context.OrderStatuses.Where(item => item.ID == (int)Constant.OrderStatusesEnum.OnMap).FirstOrDefault();
                order.Car = context.Cars.Where(item => item.ID == car.ID).FirstOrDefault();
                context.SaveChanges();
            }

            selectedPoint.CarName = order.Car.Name;
            selectedPoint.CarID = order.Car.ID;

            addedPoints.Add(selectedPoint);
            AddMarkerOnMap(selectedPoint.Lat, selectedPoint.Lng);

            points.Remove(selectedPoint);
        }
        private void RemoveFromAddDataGrid(MapPoint point)
        {
            if (point == null)
                return;

            point.CarID = 0;
            point.CarName = null;
            addedPoints.Remove(point);
            RemoveMarkerFromMap(point.Lat, point.Lng);

            points.Add(point);

            var order = context.Orders.Where(item => item.ID == point.ID).FirstOrDefault();
            order.OrderStatus = context.OrderStatuses.Where(item => item.ID == (int)Constant.OrderStatusesEnum.Created).FirstOrDefault();
            order.Car = null;
            context.SaveChanges();
            if (pointsDropDown.Items.Count == 0)
            {
                pointsDropDown.Text = "Select order";
            }
        }
        private void AddMarkerOnMap(double lat, double lng)
        {
            GMarkerGoogle marker = new GMarkerGoogle(
                new PointLatLng(lat, lng),
                GMarkerGoogleType.green);
            gMapOverlay.Markers.Add(marker);
        }
        private void RemoveMarkerFromMap(double lat, double lng)
        {
            var marker = gMapOverlay.Markers.Where(item => item.Position.Lat == lat && item.Position.Lng == lng).FirstOrDefault();
            gMapOverlay.Markers.Remove(marker);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (addedPoints.Count == 0)
            {
                MessageBox.Show("You have to add points first!", "Error!");
                return;
            }

            List<CarDTO> cars = new List<CarDTO>();

            foreach (var item in addedPoints)
            {
                var car = new CarDTO()
                {
                    CarName = item.CarName,
                    ID = item.CarID
                };
                if (cars.Where(myCar => myCar.ID == car.ID).Where(myCar => myCar.CarName == car.CarName).FirstOrDefault() == null)
                {
                    car.Orders.Add(item);
                    var carDB = context.Cars.Where(searchItem => searchItem.ID == car.ID).Include(includeItem => includeItem.Store).FirstOrDefault();
                    car.StoreName = carDB.Store.StoreName;
                    cars.Add(car);
                }
                else
                {
                    if (cars.Count != 0)
                    {
                        var carItem = cars.Where(myCar => myCar.ID == car.ID).Where(myCar => myCar.CarName == car.CarName).FirstOrDefault();
                        carItem.Orders.Add(item);
                    }
                }
            }

            waysTabControl.TabPages.Clear();
            foreach (var car in cars)
            {
                DataGridView dataGrid = new DataGridView()
                {
                    Name = "wayDataGrid" + car.ID,
                    Width = 439,
                    Height = 117,
                    Location = new Point(6, 6)
                };
                TabPage page = new TabPage()
                {
                    Name = "tabPage" + car.ID,
                    Text = car.CarName + "/" + car.StoreName
                };
                page.Controls.Add(dataGrid);
                waysTabControl.TabPages.Add(page);
            }
            waysTabControl.SelectedIndexChanged += waysTabControl_TabIndexChanged;

            VRPService vrp = new VRPService(cars);

            routes = new List<MapRouteDTO>();

            routes = vrp.GetRoutes();

            RedrawRoutes(cars[0].ID);
        }

        private void LoadOrders()
        {
            var ordersDb = context.Orders.Include(customer => customer.Customer).Include(address => address.DeliveryAddress)
                                    .Include(item => item.Car)
                                   .Include(store => store.Store).Include(status => status.OrderStatus)
                                  .ToList();
            Orders = ordersDb;
            orders = new BindingList<OrderDTO>();
            points.Clear();
            addedPoints.Clear();

            foreach (var order in ordersDb)
            {
                orders.Add(new OrderDTO()
                {
                    ID = order.ID,
                    AvailableEndTime = order.AvailableEndTime,
                    AvailableStartTime = order.AvailableStartTime,
                    CreatedDate = order.CreatedDate,
                    CustomerFullName = string.Format("{0} {1}", order.Customer.Name, order.Customer.SecondName),
                    Message = order.Message,
                    Weight = order.Weight,
                    OrderStatus = order.OrderStatus == null ? "" : order.OrderStatus.Status,
                    Store = order.Store == null ? "" : order.Store.StoreName,
                    DeliveryAddress = GetAddressService.ToShortAddressWithoutCity(order.DeliveryAddress),
                    Lattitude = order.DeliveryAddress.Lattitude,
                    Longitude = order.DeliveryAddress.Longitude
                });

                if (order.OrderStatus.ID == (int)Constant.OrderStatusesEnum.Created)
                {
                    points.Add(new MapPoint()
                    {
                        ID = order.ID,
                        StreetName = GetAddressService.ToShortAddressWithoutCity(order.DeliveryAddress),
                        Lat = order.DeliveryAddress.Lattitude,
                        Lng = order.DeliveryAddress.Longitude
                    });
                }
                if (order.OrderStatus.ID == (int)Constant.OrderStatusesEnum.OnMap)
                {
                    addedPoints.Add(new MapPoint()
                    {
                        ID = order.ID,
                        CarID = order.Car.ID,
                        CarName = order.Car.Name,
                        StreetName = GetAddressService.ToShortAddressWithoutCity(order.DeliveryAddress),
                        Lat = order.DeliveryAddress.Lattitude,
                        Lng = order.DeliveryAddress.Longitude
                    });
                    AddMarkerOnMap(order.DeliveryAddress.Lattitude, order.DeliveryAddress.Longitude);
                }
            }

            OrdersDTO = new List<OrderDTO>(orders);

            ordersDataGrid.Columns.Clear();

            ordersDataGrid.DataSource = new BindingSource(orders, null);

            ordersDataGrid.Columns["CustomerFullName"].HeaderText = "Customer";
            ordersDataGrid.Columns["AvailableStartTime"].HeaderText = "From";
            ordersDataGrid.Columns["AvailableEndTime"].HeaderText = "To";
            ordersDataGrid.Columns["OrderStatus"].HeaderText = "Status";
            ordersDataGrid.Columns["DeliveryAddress"].HeaderText = "Address";


            foreach (DataGridViewColumn column in ordersDataGrid.Columns)
            {
                column.Width = ordersDataGrid.Width / ordersDataGrid.Columns.Count;
            }
        }

        private void LoadCars()
        {
            var cars = context.Cars.Include(item => item.CarStatus).Include(item => item.Store).ToList();

            Cars = cars;

            List<CarDTO> carsDTO = new List<CarDTO>();

            foreach (var car in cars)
            {
                carsDTO.Add(new CarDTO()
                {
                    ID = car.ID,
                    CarName = car.Name,
                    CarStatus = car.CarStatus.Status,
                    StoreName = car.Store.StoreName
                });
            }

            carsDataGrid.DataSource = new BindingSource(carsDTO, null);

            if (comboBox1.SelectedItem != null)
            {
                var store = (StoreDTO)comboBox1.SelectedItem;
                if (store != null)
                {
                    var bindingCars = cars.Where(item => item.Store.ID == store.ID).ToList();
                    carsDropDown.DataSource = new BindingSource(bindingCars, null);
                    carsDropDown.DisplayMember = "Name";
                }
            }
        }

        private void LoadStores()
        {
            var storesDb = context.Stores
                            .Include(address => address.Address)
                            .Include(type => type.StoreType).ToList();
            stores.Clear();

            foreach (var storeItem in storesDb)
            {
                stores.Add(new StoreDTO()
                {
                    ID = storeItem.ID,
                    StoreName = storeItem.StoreName,
                    StoreType = storeItem.StoreType.Type,
                    Address = GetAddressService.ToShortAddress(storeItem.Address)
                });
            }

            storesDataGrid.DataSource = new BindingSource(stores, null);

            foreach (DataGridViewColumn column in storesDataGrid.Columns)
            {
                column.Width = storesDataGrid.Width / storesDataGrid.Columns.Count;
            }

            var storeDTO = (StoreDTO)comboBox1.SelectedItem;

            Store store = null;
            if (storeDTO != null)
            {
                store = context.Stores.Where(item => item.ID == storeDTO.ID).Include(item => item.Address).FirstOrDefault();
            }

            storePointsOverlay.Markers.Clear();

            if (store != null)
            {
                gmap.Position = new PointLatLng(store.Address.Lattitude, store.Address.Longitude);

                GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(store.Address.Lattitude, store.Address.Longitude),
                                                        GMarkerGoogleType.red);
                storePointsOverlay.Markers.Add(marker);
            }
        }

        private void addOrderButton_Click(object sender, EventArgs e)
        {
            if (stores.Count != 0)
            {
                AddNewOrderForm form = new AddNewOrderForm();
                form.Show();
            }
            else
            {
                MessageBox.Show("You need to create a store first!");
            }
        }

        private void createStoreButton_Click(object sender, EventArgs e)
        {
            AddNewStore form = new AddNewStore();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadOrders();

            LoadStores();

            LoadCars();

            LoadCustomers();

            ClearFilter();

            ClearCustomerFilter();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var storeDTO = (StoreDTO)comboBox1.SelectedItem;

            if (storeDTO == null)
            {
                return;
            }

            var store = context.Stores.Where(item => item.ID == storeDTO.ID).Include(item => item.Address).FirstOrDefault();

            storePointsOverlay.Markers.Clear();

            if (store != null)
            {
                gmap.Position = new PointLatLng(store.Address.Lattitude, store.Address.Longitude);

                GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(store.Address.Lattitude, store.Address.Longitude),
                                                        GMarkerGoogleType.red);
                storePointsOverlay.Markers.Add(marker);
            }

            carsDropDown.SelectedIndex = -1;
            carsDropDown.Text = "Select car";

            if (store != null)
            {
                var bindingCars = Cars.Where(item => item.Store.ID == store.ID).ToList();
                carsDropDown.DataSource = new BindingSource(bindingCars, null);
                carsDropDown.DisplayMember = "Name";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddNewCarForm form = new AddNewCarForm();
            form.Show();
        }

        private void waysTabControl_TabIndexChanged(object sender, EventArgs e)
        {
            int tabIndx = 1;
        }

        private void RedrawRoutes(int carID)
        {
            var currentRoute = routes.Where(item => item.CarID == carID).FirstOrDefault();

            //Show route

            GoogleMap mapProvider = new GoogleMap();
            MapRoute route = new MapRoute(currentRoute.Route);

            GMapRoute myRoute = new GMapRoute(route.Points, "My route");
            routesOverlay.Routes.Add(myRoute);
        }

        private void storeFilterBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterOutOrders();
        }
        private void LoadFilter()
        {
            storeFilterBox.Items.Add("All");

            for (int i = 0; i < stores.Count; i++)
            {
                storeFilterBox.Items.Add(stores[i].StoreName);
            }

            statusFilterBox.Items.Add("All");

            var statuses = context.OrderStatuses.ToList();
            for (int i = 0; i < statuses.Count; i++)
            {
                statusFilterBox.Items.Add(statuses[i].Status);
            }

            FilterOutOrders();
        }
        private void ClearFilter()
        {
            storeFilterBox.Items.Clear();
            statusFilterBox.Items.Clear();
            customerNameFiltertxt.Text = null;
            fromDateFiltertxt.ResetText();
            toDateFiltertxt.ResetText();

            FilterOutOrders();
        }
        private void FilterOutOrders()
        {
            List<OrderDTO> filtered = new List<OrderDTO>();

            if (statusFilterBox.SelectedIndex > 0 && statusFilterBox.SelectedItem.ToString() != "All")
            {
                filtered = OrdersDTO.Where(item => item.OrderStatus.Contains(statusFilterBox.SelectedItem.ToString())).ToList();
            }
            else
            {
                filtered = OrdersDTO;
            }
            
            if (storeFilterBox.SelectedIndex > 0 && storeFilterBox.SelectedItem.ToString() != "All")
            {
                filtered = filtered.Where(item => item.Store.Contains(storeFilterBox.SelectedItem.ToString())).ToList();
            }

            if (!string.IsNullOrEmpty(customerNameFiltertxt.Text))
            {
                filtered = filtered.Where(item => item.CustomerFullName.ToLower().Contains(customerNameFiltertxt.Text.ToLower().Trim().ToString())).ToList();
            }

            filtered = filtered.Where(item => (item.CreatedDate >= fromDateFiltertxt.Value && item.CreatedDate <= toDateFiltertxt.Value)).ToList();

            orders = new BindingList<OrderDTO>(filtered);

            ordersDataGrid.DataSource = new BindingSource(orders, null);
        }
        private void LoadCustomers()
        {
            var customersDB = context.Customers.Include(item => item.Address).ToList();
            foreach(var customer in customersDB)
            {
                customers.Add(new CustomerDTO() { 
                    ID = customer.ID,
                    Name = customer.Name,
                    SecondName = customer.SecondName,
                    Age = customer.Age,
                    PhoneNumber = customer.PhoneNumber,
                    Email = customer.Email,
                    Address = customer.Address != null ? GetAddressService.ToShortAddress(customer.Address) : ""
                });
            }

            customersDataGrid.DataSource = new BindingSource(customers, null);
        }

        private void emailFiltertxt_TextChanged(object sender, EventArgs e)
        {
            SetCustomerFilter();
        }
        private void ClearCustomerFilter()
        {
            nameFiltertxt.Text = null;
            secondNameFiltertxt.Text = null;
            emailFiltertxt.Text = null;
            phoneNumberFiltertxt.Text = null;

            SetCustomerFilter();
        }
        private void SetCustomerFilter()
        {
            var filtered = context.Customers.Include(item => item.Address).ToList();

            if (!string.IsNullOrEmpty(nameFiltertxt.Text))
            {
                filtered = filtered.Where(item => item.Name.ToLower().Contains(nameFiltertxt.Text.ToLower().Trim().ToString())).ToList();
            }
            if (!string.IsNullOrEmpty(secondNameFiltertxt.Text))
            {
                filtered = filtered.Where(item => item.SecondName.ToLower().Contains(secondNameFiltertxt.Text.ToLower().Trim().ToString())).ToList();
            }
            if (!string.IsNullOrEmpty(emailFiltertxt.Text))
            {
                filtered = filtered.Where(item => item.Email.ToLower().Contains(emailFiltertxt.Text.ToLower().Trim().ToString())).ToList();
            }
            if (!string.IsNullOrEmpty(phoneNumberFiltertxt.Text))
            {
                filtered = filtered.Where(item => item.PhoneNumber.ToLower().Contains(phoneNumberFiltertxt.Text.ToLower().Trim().ToString())).ToList();
            }

            customers.Clear();
            foreach (var customer in filtered)
            {
                customers.Add(new CustomerDTO()
                {
                    ID = customer.ID,
                    Name = customer.Name,
                    SecondName = customer.SecondName,
                    Age = customer.Age,
                    PhoneNumber = customer.PhoneNumber,
                    Email = customer.Email,
                    Address = customer.Address != null ? GetAddressService.ToShortAddress(customer.Address) : ""
                });
            }

            customersDataGrid.DataSource = new BindingSource(customers, null);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddNewCustomerForm form = new AddNewCustomerForm();
            form.Show();
        }
    }
}
