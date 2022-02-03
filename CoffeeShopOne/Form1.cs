using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopOne
{
    public partial class CoffeeShop : Form
    {
        int black = 120;
        int cold = 100;
        int hot = 90;
        int regular = 80;
        int total;

        public int Total { get => total; set => total = value; }

        public CoffeeShop()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string CustomerName = customerNameTextBox.Text,
                PhoneNumber = phoneNumberTextBox.Text,
                Address = addressTextBox.Text,
                CoffeeType = coffeeTypeComboBox.Text;
            int qua = Convert.ToInt32(quantityTextBox.Text);

         

         
            if (CoffeeType == "Black Coffee")
            {
                total = qua * black;
            }else if (CoffeeType == "Cold Coffee")
            {
                total = qua * cold;
            }else if(CoffeeType == "Hot Coffee")
            {
                total = qua * hot;
            }else if(CoffeeType == "Regular Coffee")
            {
                total = qua * regular;
            }

            

            if (CustomerName == "")
            {
                MessageBox.Show("Please Enter Customer Name");
            }
            else if (PhoneNumber == "")
            {
                MessageBox.Show("Please Enter Phone Number");
            }
            else if (Address == "")
            {
                MessageBox.Show("Please Enter Address");
            }
            else if (CoffeeType == "")
            {
                MessageBox.Show("Please Select Coffee Type");
            }
            else if (qua < 0)
            {
                MessageBox.Show("Please Enter Quantitly");
            }
            else
            {
                richTextBox.Text = ("Customer Name: " + CustomerName + "\n" +  " \n " + "Phone Number: " + PhoneNumber + " \n " + " \n " + "Address: " + Address + " \n " + " \n " + " \n " + "Coffee Type: " + CoffeeType + "\n" +  " \n " + "Quantity: " + qua +" \n " + " \n "+"Total Price: " + total);
            }

        }
    }
}
