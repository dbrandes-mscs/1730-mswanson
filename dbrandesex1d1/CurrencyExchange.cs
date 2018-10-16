using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbrandesex1d1
{
    public partial class CurrencyExchange : Form
    {
        public CurrencyExchange()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void australiaTextChanged(object sender, EventArgs e)
        {
            txtUSDAustralia.Text = (
                  Convert.ToDecimal(txtRateAustralia.Text) * Convert.ToDecimal(txtAmountAustralia.Text)
              ).ToString("0.00");
        }

        private void bahrainTextChanged(object sender, EventArgs e)
        {
            txtUSDBahrain.Text = (
                  Convert.ToDecimal(txtRateBahrain.Text) * Convert.ToDecimal(txtAmountBahrain.Text)
              ).ToString("0.00");
        }

        private void belgiumTextChanged(object sender, EventArgs e)
        {
            txtUSDBelgium.Text = (
                  Convert.ToDecimal(txtRateBelgium.Text) * Convert.ToDecimal(txtAmountBelgium.Text)
              ).ToString("0.00");
        }

        private void bhutanTextChange(object sender, EventArgs e)
        {
            txtUSDBhutan.Text = (
                  Convert.ToDecimal(txtRateBhutan.Text) * Convert.ToDecimal(txtAmountBhutan.Text)
              ).ToString("0.00");
        }

        private void usdTextChanged(object sender, EventArgs e)
        {
            txtTotalUSD.Text = (
                    Convert.ToDecimal(txtUSDAustralia.Text) 
                    
                    + Convert.ToDecimal(txtUSDBahrain.Text) 

                    + Convert.ToDecimal(txtUSDBelgium.Text)

                    + Convert.ToDecimal(txtUSDBhutan.Text)
                    ).ToString("0.00");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAmountAustralia.Text = "0.00";
            txtRateAustralia.Text = "0.717976";
            txtAmountBahrain.Text = "0.00";
            txtRateBahrain.Text = ".38";
            txtAmountBelgium.Text = "0.00";
            txtRateBelgium.Text = ".86";
            txtAmountBhutan.Text = "0.00";
            txtRateBhutan.Text = "0.0139831";
        }
    }
}
