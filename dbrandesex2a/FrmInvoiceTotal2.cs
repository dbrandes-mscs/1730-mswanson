using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbrandesex2a
{
    public partial class Frm2a1 : Form
    {
        public Frm2a1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal Subtotal = Convert.ToInt32(txtSubtotal.Text);
            decimal DiscountPercent = Convert.ToInt32(txtDiscountPercent.Text);
            decimal DiscountAmount = (Subtotal * DiscountPercent) / 100;
            txtDiscountAmount.Text = DiscountAmount.ToString("0.00");

            decimal Total = Subtotal - DiscountAmount;
            txtTotal.Text = Total.ToString("0.00");
           

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
