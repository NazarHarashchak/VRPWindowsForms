using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using VRPWindowsForms.DTO;
using VRPWindowsForms.Models;
using VRPWindowsForms.Constant;

namespace VRPWindowsForms
{
    public partial class AddNewCarForm : Form
    {
        private DatabaseContext context;
        public AddNewCarForm()
        {
            InitializeComponent();

            context = new DatabaseContext();

            var stores = context.Stores.ToList();
            var storeDTO = new List<StoreDTO>();

            foreach (var store in stores)
            {
                storeDTO.Add(new StoreDTO()
                {
                    ID = store.ID,
                    StoreName = store.StoreName
                });
            }

            comboBox1.DataSource = new BindingSource(storeDTO, null);
            comboBox1.DisplayMember = "StoreName";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var storeDTO = (StoreDTO)comboBox1.SelectedItem;
            if (storeDTO != null)
            {
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show("Enter car name.", "Error!");
                    return;
                }
                if (context.Cars.Where(item => (item.Name == textBox1.Text && item.StoreID != storeDTO.ID)).FirstOrDefault() != null)
                {
                    MessageBox.Show("Car with the same name is already exist.", "Error!");
                    return;
                }
                var car = new Car()
                {
                    CarStatus = context.CarStatuses.Where(item => item.ID == (int)Constant.CarStatusesEnum.InStore).FirstOrDefault(),
                    Name = textBox1.Text,
                    Store = context.Stores.Where(item => item.ID == storeDTO.ID).FirstOrDefault()
                };
                context.Cars.Add(car);
                context.SaveChanges();
                MessageBox.Show("Car have been saved!", "Success!");
                this.Close();
            }
            else
            {
                MessageBox.Show("You have to choose store first", "Error!");
                return;
            }
        }
    }
}
