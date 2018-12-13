using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace dbrandesex3b1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, RoutedEventArgs e)
        {
            //0) Calculate dicountPercent
            try
            {
                decimal subtotal = Decimal.Parse(inputTextBox0a.Text);
                decimal discountPercent = Ex3bCalculations.GetDiscountPercent(subtotal);
                resultTextBox0.Text = discountPercent.ToString("f3");
            }
            catch {
                resultTextBox0.Text = "";
                MessageBox.Show("Invalid input: " + this.inputTextBox0a.Text);
            }
            //1) Calculate dicountPercent using output argument 
            try
            {
                decimal subtotal = Decimal.Parse(inputTextBox1a.Text);
                decimal discountPercent;
                Ex3bCalculations.GetDiscountPercent(subtotal, out discountPercent);
                resultTextBox1.Text = discountPercent.ToString("f3");
            }
            catch
            {
                resultTextBox1.Text = "";
                MessageBox.Show("Invalid input: " + this.inputTextBox0a.Text);
            }
            //2) Calculate futureValue
            try
            {
                int months = Int32.Parse(inputTextBox2a.Text);
                decimal monthlyInvestment = Decimal.Parse(inputTextBox2b.Text);
                decimal monthlyInterestRate = Decimal.Parse(inputTextBox2c.Text);
                decimal futureValue = Ex3bCalculations.CalculatefutureValue(monthlyInvestment, monthlyInterestRate, months);
                resultTextBox2.Text = futureValue.ToString("c2");
            }
            catch
            {
                resultTextBox2.Text = "";
                MessageBox.Show("Invalid input:\n" 
                    + this.inputTextBox2a.Text + "\n"
                    + this.inputTextBox2b.Text + "\n"
                    + this.inputTextBox2c.Text + "\n");
            }
            //3) CalcFutureValue using ref argument
            try
            {
                int months = Int32.Parse(inputTextBox2a.Text);
                decimal monthlyInvestment = Decimal.Parse(inputTextBox2b.Text);
                decimal monthlyInterestRate = Decimal.Parse(inputTextBox2c.Text);
                decimal futureValue = 0m;
                Ex3bCalculations.CalculateFutureValue(
                    monthlyInvestment, monthlyInterestRate, months, ref futureValue);
                resultTextBox3.Text = futureValue.ToString("c2");
            }
            catch
            {
                resultTextBox3.Text = "";
                MessageBox.Show("Invalid input:\n"
                    + this.inputTextBox3a.Text + "\n"
                    + this.inputTextBox3b.Text + "\n"
                    + this.inputTextBox3c.Text + "\n");
            }
            //4) Calculate FahrenheitToCelsius
            try
            {
                double tempfahrenheit = Double.Parse(inputTextBox4a.Text);
                double tempcelsius = Ex3bCalculations.FahrenheitToCelsius(tempfahrenheit);

                resultTextBox4.Text = tempcelsius.ToString("f1");
            }
            catch
            {
                resultTextBox4.Text = "";
                MessageBox.Show("Invalid input:\n"
                    + this.inputTextBox4a.Text + "\n");
            }
            //5) Calculate CelsiusToFahrenheit
            try
            {
                double tempCelsius;
                double tempfahrenheit = Double.Parse(inputTextBox5a.Text);
                Ex3bCalculations.CelsiusToFahrenheit(ref tempCelsius);

                resultTextBox5.Text = tempCelsius.ToString("f1");
            }
            catch
            {
                resultTextBox4.Text = "";
                MessageBox.Show("Invalid input:\n"
                    + this.inputTextBox5a.Text + "\n");
            }
            //6) Calculate GrossPay
            try
            {
                decimal hours = Decimal.Parse(inputTextBox6a.Text);
                decimal rate = Decimal.Parse(inputTextBox6b.Text);
                decimal grossPay = Ex3bCalculations.GrossPay(hours, rate);

                resultTextBox6.Text = grossPay.ToString("c2");
            }
            catch
            {
                resultTextBox6.Text = "";
                MessageBox.Show("Invalid input:\n"
                    + this.inputTextBox6a.Text + "\n"
                    + this.inputTextBox6b.Text + "\n");
            }
            //7) TotalHours(strNumbers)
            try
            {
                this.resultTextBox7.Text =
                    Ex3bCalculations.TotalHours(this.inputTextBox7a.Text).ToString("n2");
            }
            catch
            {
                this.resultTextBox7.Text = "";
                MessageBox.Show("Invalid input: " + this.inputTextBox7a.Text);
            }
            //8) GrossPay(strNumbers, rate)
            try
            {

                decimal rate = Decimal.Parse(inputTextBox8b.Text);
                this.resultTextBox8.Text =
                    Ex3bCalculations.GrossPay(inputTextBox8a.Text, rate).ToString("c2");
            }
            catch
            {
                this.resultTextBox8.Text = "";
                MessageBox.Show("Invalid input:\n"
                    + this.inputTextBox8a.Text + "\n"
                    + this.inputTextBox8b.Text);
            }
        }

    }
}
