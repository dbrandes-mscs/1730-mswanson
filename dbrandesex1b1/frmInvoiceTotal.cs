﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbrandesex1b1
{
    public partial class frmInvoiceTotal : Form
    {
        public frmInvoiceTotal()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //txtTotal.Text = "10";
            //txtTotal.ReadOnly = false;
            txtDiscountAmount.Text =
                 (Convert.ToDecimal(txtSubtotal.Text)
                     * Convert.ToDecimal(txtDiscountPercent.Text) / 100).ToString();
            txtTotal.Text =
                 (Convert.ToDecimal(txtSubtotal.Text)
                     - Convert.ToDecimal(txtDiscountAmount.Text)).ToString();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDiscountAmount_TextChanged(object sender, EventArgs e)
        {
            //txtDiscountAmount.Text = 
            //    (Convert.ToDecimal(txtSubtotal.Text) 
            //    * Convert.ToDecimal(txtDiscountPercent.Text) / 100).ToString();
        }
    }
}
