using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VRPWindowsForms.Models;
using VRPWindowsForms.Services;
using VRPWindowsForms.Constant;

namespace VRPWindowsForms
{
    public partial class AddNewOrderForm : Form
    {
        private DatabaseContext context;
        private Customer customer;
        public AddNewOrderForm()
        {
            InitializeComponent();

            context = new DatabaseContext();

            label6.Visible = true;
            label2.Visible = true;
            textBox1.Visible = true;

            label1.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            nameTxt.Visible = false;
            secondNameTxt.Visible = false;
            phoneNumberTxt.Visible = false;
            emailTxt.Visible = false;
            button3.Visible = false;

            LoadStores();
        }

        private void LoadStores()
        {
            BindingList<Store> stores = new BindingList<Store>(context.Stores.Include(item => item.Address).ToList());

            List<string> cities = new List<string>();
            for(int i = 0; i < stores.Count; i++)
            {
                if (!cities.Contains(stores[i].Address.City))
                    cities.Add(stores[i].Address.City);
            }
            comboBox1.Items.AddRange(cities.ToArray());
            storeDropDown.DataSource = new BindingSource(stores, null);
            storeDropDown.DisplayMember = "StoreName";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label6.Visible = true;
                label2.Visible = true;
                textBox1.Visible = true;
                button1.Visible = true;
            }
            else
            {
                label6.Visible = false;
                label2.Visible = false;
                textBox1.Visible = false;
                button1.Visible = false;
            }
            if (radioButton2.Checked)
            {
                label1.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                nameTxt.Visible = true;
                secondNameTxt.Visible = true;
                phoneNumberTxt.Visible = true;
                emailTxt.Visible = true;
                button3.Visible = true;
            }
            else
            {
                label1.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                nameTxt.Visible = false;
                secondNameTxt.Visible = false;
                phoneNumberTxt.Visible = false;
                emailTxt.Visible = false;
                button3.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text.Trim();
            var user = context.Customers.Where(item => item.Email.ToLower() == email.ToLower()).FirstOrDefault();
            if (user == null)
            {
                label2.Text = "User was not found!";
            }
            else
            {
                label2.Text = string.Format("{0} {1}, {2}", user.Name, user.SecondName, user.Email);
                customer = user;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Customer newCustomer = new Customer();
            newCustomer.Name = nameTxt.Text.Trim();
            newCustomer.SecondName = secondNameTxt.Text.Trim();
            newCustomer.PhoneNumber = phoneNumberTxt.Text.Trim();
            newCustomer.Email = emailTxt.Text.Trim();

            context.Customers.Add(newCustomer);
            customer = newCustomer;
            context.SaveChanges();
            MessageBox.Show("Customer had been created!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            Address address = new Address();

            address = GetAddressService.GetNewAddress(
                    new GoogleMap(),
                    "Україна",
                    comboBox1.SelectedItem.ToString(),
                    textBox2.Text,
                    textBox3.Text,
                    checkBox1.Checked,
                    Convert.ToInt32(string.IsNullOrEmpty(textBox4.Text) ? "0" : textBox4.Text),
                    textBox5.Text
                );

            context.Addresses.Add(address);

            order.Weight = double.Parse(numericUpDown5.Value.ToString());
            order.Message = richTextBox1.Text;
            order.AvailableStartTime = new TimeSpan(int.Parse(numericUpDown1.Value.ToString()), int.Parse(numericUpDown2.Value.ToString()), 0);
            order.AvailableEndTime = new TimeSpan(int.Parse(numericUpDown3.Value.ToString()), int.Parse(numericUpDown4.Value.ToString()), 0);
            order.CreatedDate = DateTime.Now;
            order.DeliveryAddress = address;
            order.Customer = customer;
            order.OrderStatus = context.OrderStatuses.Where(item => item.ID == (int)Constant.OrderStatusesEnum.Created).FirstOrDefault();
            order.Store = (Store)storeDropDown.SelectedItem;
            context.Orders.Add(order);
            context.SaveChanges();
            this.Close();
        }
    }
}
