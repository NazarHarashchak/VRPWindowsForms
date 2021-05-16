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
using VRPWindowsForms.DTO;
using System.Data.Entity;

namespace VRPWindowsForms
{
    public partial class AddNewCustomerForm : Form
    {
        DatabaseContext context;
        public AddNewCustomerForm()
        {
            InitializeComponent();

            context = new DatabaseContext();

            BindingList<Store> stores = new BindingList<Store>(context.Stores.Include(item => item.Address).ToList());
            comboBox1.DataSource = new BindingSource(stores, null);
            comboBox1.DisplayMember = "Address.City";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Customer customer = new Customer();

                if (string.IsNullOrEmpty(nametxt.Text))
                {
                    MessageBox.Show("Name field can not be empty!", "Error!");
                    return;
                }
                else
                {
                    customer.Name = nametxt.Text;
                }
                if (string.IsNullOrEmpty(secondNametxt.Text))
                {
                    MessageBox.Show("Second name field can not be empty!", "Error!");
                    return;
                }
                else
                {
                    customer.SecondName = secondNametxt.Text;
                }
                if (string.IsNullOrEmpty(phoneNumbertxt.Text))
                {
                    MessageBox.Show("Phone number field can not be empty!", "Error!");
                    return;
                }
                else
                {
                    customer.PhoneNumber = phoneNumbertxt.Text;
                }
                if (string.IsNullOrEmpty(emailtxt.Text))
                {
                    MessageBox.Show("Email field can not be empty!", "Error!");
                    return;
                }
                else
                {
                    customer.Email = emailtxt.Text;
                }

                customer.Age = (int)agetxt.Value;

                Address address = new Address();
                var selected = (Store)comboBox1.SelectedItem;
                address.City = selected.Address.City;

                if (string.IsNullOrEmpty(textBox2.Text))
                {
                    MessageBox.Show("Street field can not be empty!", "Error!");
                    return;
                }
                else
                {
                    address.Street = textBox2.Text;
                }
                if (string.IsNullOrEmpty(textBox3.Text))
                {
                    MessageBox.Show("House number field can not be empty!", "Error!");
                    return;
                }
                else
                {
                    address.Street = textBox3.Text;
                }
                if (checkBox1.Checked)
                {
                    address.IsPrivateHouse = true;
                }
                else
                {
                    address.IsPrivateHouse = false;
                }

                address.AppartmentsNumber = Convert.ToInt32(textBox4.Text);
                address.PostCode = textBox5.Text;

                customer.Address = address;
                context.Customers.Add(customer);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
                return;
            }
        }
    }
}
