using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuliaIB.Properties
{
    public partial class frmOptions : Form
    {
        public frmOptions()
        {
            InitializeComponent();
        }

        string Name;
        double Price;
        double quantity;
        double discount;
        double total;
        double subtotal;

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            Name = txtName.Text;
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            Price = double.Parse(txtPrice.Text);


        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            quantity = double.Parse(txtQuantity.Text);
            subtotal = +Price * quantity;
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            discount = double.Parse(txtDiscount.Text);
        }

        private void rdoIncluded_CheckedChanged(object sender, EventArgs e)
        {
            picCheck.Visible = true;
            picCross.Visible = false;
            total = subtotal * 1 - discount;
        }

        private void rdoNotIncluded_CheckedChanged(object sender, EventArgs e)
        {
            picCheck.Visible = false;
            picCross.Visible = true;
            total = subtotal + subtotal * 0.16 - discount;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The material requested was " +quantity +" "+ Name +" which has a price of "+ subtotal + "however arfter discound and" +
                "taxes the final price was " + total);
        }
    }
}
