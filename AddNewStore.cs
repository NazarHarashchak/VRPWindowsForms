using GMap.NET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VRPWindowsForms.Models;
using VRPWindowsForms.Services;

namespace VRPWindowsForms
{
    public partial class AddNewStore : Form
    {
        private DatabaseContext context;
        private GoogleMap gMap;
        public AddNewStore()
        {
            InitializeComponent();

            gMap = new GoogleMap();

            context = new DatabaseContext();

            var storeTypes = context.StoreTypes.ToList();


            foreach (var type in storeTypes)
            {
                comboBox2.Items.Add(type.Type);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (context.Stores.Where(item => item.StoreName == textBox8.Text).Any())
            {
                MessageBox.Show("Store with this name already exists");
                return;
            }
            Address address = new Address();

            address = GetAddressService.GetNewAddress(
                    gMap,
                    "Україна",
                    textBox1.Text,
                    textBox2.Text,
                    textBox3.Text,
                    checkBox1.Checked,
                    Convert.ToInt32(string.IsNullOrEmpty(textBox4.Text) ? "0" : textBox4.Text),
                    textBox5.Text
                );

            context.Addresses.Add(address);

            Store store = new Store();

            store.StoreName = textBox8.Text;
            store.Address = address;
            store.StoreType = context.StoreTypes.Where(type => type.Type == comboBox2.SelectedItem.ToString()).FirstOrDefault();

            context.Stores.Add(store);
            context.SaveChanges();
            this.Close();
        }
    }
}
