using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierApplication
{
    public partial class frmPurchaseDiscountedItem : Form
    {
        private DiscountedItem discountedItem;
        public frmPurchaseDiscountedItem()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            double price = Convert.ToDouble(textBox3.Text);
            int quantity = Convert.ToInt32(textBox4.Text);
            double discount = Convert.ToDouble(textBox2.Text);

            discountedItem = new DiscountedItem(name, price, quantity, discount);
            double totalPrice = discountedItem.getTotalPrice();
            label6.Text = "Total Amount: " + totalPrice.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double paymentAmount = Convert.ToDouble(textBox5.Text);
            discountedItem.setPayment(paymentAmount);
            double change = discountedItem.getChange();
            label7.Text = "Change: " + change.ToString();
        }
    }
}
    

