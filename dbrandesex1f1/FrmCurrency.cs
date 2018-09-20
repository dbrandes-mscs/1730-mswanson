using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbrandesex1f1
{
    public partial class FrmCurrency : Form
    {
        public FrmCurrency()
        {
            InitializeComponent();
        }

        private void FrmCurrency_Load(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustralia.Image;
            btnBahrain.BackgroundImage = picBahrainDim.Image;
            btnBelgium.BackgroundImage = picBelgiumDim.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            txtRate.Text = "0.717976";
            lblCurrency.Text = btnAustralia.Text + ":";
            txtUSD.Text = "0.00";
            txtTotalUsd.Text = "0.00";
            txtCurrency.Focus();
        }

        private void btnAustralia_Click(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustralia.Image;
            btnBahrain.BackgroundImage = picBahrainDim.Image;
            btnBelgium.BackgroundImage = picBelgiumDim.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            txtRate.Text = "0.717976";
            lblCurrency.Text = btnAustralia.Text + ":";
            txtCurrency.Focus();
        }

        private void btnBahrain_Click(object sender, EventArgs e)
        {
            btnBahrain.BackgroundImage = picBahrain.Image;
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnBelgium.BackgroundImage = picBelgiumDim.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            txtRate.Text = "0.38";
            lblCurrency.Text = btnBahrain.Text + ":";
            txtCurrency.Focus();
        }

        private void btnBelgium_Click(object sender, EventArgs e)
        {
            btnBelgium.BackgroundImage = picBelgium.Image;
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnBahrain.BackgroundImage = picBahrainDim.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            txtRate.Text = "0.86";
            lblCurrency.Text = btnBelgium.Text + ":";
            txtCurrency.Focus();
        }

        private void btnBhutan_Click(object sender, EventArgs e)
        {
            btnBhutan.BackgroundImage = picBhutan.Image;
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnBahrain.BackgroundImage = picBahrainDim.Image;
            btnBelgium.BackgroundImage = picBelgiumDim.Image;
            txtRate.Text = "0.01382";
            lblCurrency.Text = btnBhutan.Text + ":";
            txtCurrency.Focus();
        }

        private void txtCurrency_Enter(object sender, EventArgs e)
        {
            txtCurrency.SelectAll();
        }

        private void txtUSD_TextChanged(object sender, EventArgs e)
        {
            txtUSD.Text = (
                Convert.ToDecimal(txtCurrency.Text) * 
                
                Convert.ToDecimal(txtRate.Text)).ToString("0.00");
        }

        private void CalcUsd(object sender, EventArgs e)
        {
            txtUSD.Text = (
              Convert.ToDecimal(txtCurrency.Text) *

              Convert.ToDecimal(txtRate.Text)).ToString("");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblEquation.Text = lblEquation.Text + txtUSD.Text + " + ";

            txtTotalUsd.Text = (
              Convert.ToDecimal(txtUSD.Text) +

              Convert.ToDecimal(txtTotalUsd.Text)).ToString("");

            txtCurrency.Focus();
        }

        private void txtCurrency_Click(object sender, EventArgs e)
        {
            txtCurrency.Focus();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustralia.Image;
            btnBahrain.BackgroundImage = picBahrainDim.Image;
            btnBelgium.BackgroundImage = picBelgiumDim.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            txtRate.Text = "0.717976";
            lblCurrency.Text = btnAustralia.Text + ":";
            txtCurrency.Text = "0.00";
            lblEquation.Text = "";
            txtUSD.Text = "0.00";
            txtTotalUsd.Text = "0.00";
            txtCurrency.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
