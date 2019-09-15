using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_shop_customer_manager
{
    public partial class HomeUI : Form
    {
        public HomeUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            int contact = Convert.ToInt32(contactTextBox.Text);
            string address = addressTextBox.Text;
            string item = itemComboBox.Text;
            int quantity = Convert.ToInt32(quantityTextBox.Text);

            MessageBox.Show (" Name: " + name + "\n" + " Contact: " + contact +"\n" +" Address: " + address +"\n" + "Item: " + item +"\n"+ "Quantity: " + quantity ) ;

            




           


        }

        private void HomeUI_Load(object sender, EventArgs e)
        {

        }

        private void quantityTextBox_TextChanged(object sender, EventArgs e)
        {
          

        }
    }
}
