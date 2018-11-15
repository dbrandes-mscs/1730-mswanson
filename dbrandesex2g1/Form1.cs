using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbrandesex2g1
{
    public partial class dbrandes2g1Form : Form
    {
        public dbrandes2g1Form()
        {
            InitializeComponent();
        }

        private void Calcbutton_Click(object sender, EventArgs e)
        {
            //1a) 'Switch' with no default
            resultSwitch01textBox.Text = Ex2gCalculations.Switch01(input1AtextBox.Text);

            //1b) Separate 'if' statements
            resultIf01textBox.Text = Ex2gCalculations.If01(input1AtextBox.Text);

            //1c) if elseif
            resultElseIf01textBox.Text = Ex2gCalculations.ElseIf01(input1AtextBox.Text);

            //1d) Nested If-else
            resultNestedIfElse01textBox.Text = Ex2gCalculations.NestedIfElse01(input1AtextBox.Text);

            //1e) Switch Default
            resultSwitchDefault01textBox.Text = Ex2gCalculations.SwitchDefault01(input1AtextBox.Text);

            //1f) Separate 'if' statements, default value 0
            resultIfDefault01textBox.Text = Ex2gCalculations.IfDefault01(input1AtextBox.Text);

            //1g) if elseif with default value 
            resultElseIfDefault01textBox.Text = Ex2gCalculations.ElseIfDefault01(input1AtextBox.Text);

            //1h) Nested If-else default value
            resultNestedIfElseDefault01textBox.Text = Ex2gCalculations.NestedIfElseDefault01(input1AtextBox.Text);

            // 2a) 'Switch' with no default
            resultSwitch02textBox.Text = Ex2gCalculations.Switch02(input2AtextBox.Text);

            // 2b) Separate 'if' statements
            resultIf02textBox.Text = Ex2gCalculations.If02(input2AtextBox.Text);

            // 2c) if elseif
            resultElseIf02textBox.Text = Ex2gCalculations.ElseIf02(input2AtextBox.Text);

            // 2d) Nested if-else
            resultNestedIfElse02textBox.Text = Ex2gCalculations.NestedIfElse02(input2AtextBox.Text);

        }


    }
}
