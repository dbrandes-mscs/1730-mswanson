using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbrandesex2f1
{
    public partial class dbrandes17142f1 : Form
    {
        public dbrandes17142f1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal subtotal = 0.0m;
            decimal discountPercent = 0.0m;

            // #1 if
            result1textBox.Text = Ex2fCalculations.Calc01(input1AtextBox.Text);

            // #2 if (block)
            result2textBox.Text = Ex2fCalculations.Calc02(input2AtextBox.Text);

            // #3: if else
            result3textBox.Text = Ex2fCalculations.Calc03(input3AtextBox.Text);

            // #4 if else if
            result4textBox.Text = Ex2fCalculations.Calc04(input4AtextBox.Text);

            // #5 Better range test
            result5textBox.Text = Ex2fCalculations.Calc05(input5AtextBox.Text);


            // #6 Nested if statements           
            result6textBox.Text = Ex2fCalculations.Calc06(input6AtextBox.Text, input6BtextBox.Text);

            // #7 Input Validation
            decimal ethereum = 0m;
            if (input7AtextBox.Text != "")
            {

                decimal dollars = Decimal.Parse(input7AtextBox.Text);
                ethereum = 200m * dollars;
                result7textBox.Text = ethereum.ToString("n2");


            }
            result7textBox.Text = "Invalid input";

            //#8 input validation, calculate total and shipping. Shiping $5 for orders under $50.00
            decimal cost = 0m;
            decimal quantity = 0m;
            if (input8AtextBox.Text != "")
            {
                decimal price = Decimal.Parse(input8AtextBox.Text);
                decimal shipping = 0m;
                if (price < 50)
                    shipping = price + 5m;
                else
                    shipping = price;


            }
            result8textBox.Text = "Invalid input";
            if (input8BtextBox.Text != "")
            {

            }

            result8textBox.Text = "Invalid input";


        }
    }
}

