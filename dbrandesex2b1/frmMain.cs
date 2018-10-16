using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbrandesex2b1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void calculate(object sender, EventArgs e)
        {
            decimal amountAustralia = Convert.ToDecimal(txtAmountAustralia.Text);
            decimal rateAustralia = 0.717976m;
            decimal usdAustralia = amountAustralia * rateAustralia;

            decimal amountBahrain = Convert.ToDecimal(txtAmountBahrain.Text);
            decimal rateBahrain = 0.38m;
            decimal usdBahrain = amountBahrain * rateBahrain;

            decimal amountBelgium = Convert.ToDecimal(txtAmountBelgium.Text);
            decimal rateBelgium = 0.86m;
            decimal usdBelgium = amountBelgium * rateBelgium;

            decimal amountBhutan = Convert.ToDecimal(txtAmountBhutan.Text);
            decimal rateBhutan = 0.0139831m;
            decimal usdBhutan = amountBhutan * rateBhutan;

            decimal totalUSD = usdAustralia + usdBahrain + usdBelgium + usdBhutan;

            txtTotalUSD.Text = totalUSD.ToString("0.00");
            txtUSDAustralia.Text = usdAustralia.ToString("0.00");
            txtUSDBahrain.Text = usdBahrain.ToString("0.00");
            txtUSDBelgium.Text = usdBelgium.ToString("0.00");
            txtUSDBhutan.Text = usdBhutan.ToString("0.00");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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
