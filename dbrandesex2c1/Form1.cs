using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbrandesex2c1
{
    public partial class Form1 : Form
    {
        private byte byte1, byte2, byte3;
        private sbyte sbyte1, sbyte2, sbyte3;
        private short short1, short2, short3;
        private ushort ushort1, ushort2, ushort3;
        private int int1, int2, int3;
        private uint uint1, uint2, uint3;

         input2textBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                byte1 = Convert.ToByte(input1textBox.Text);
                byte1textBox.Text = byte1.ToString();
            }

            catch (Exception) { byte1textBox.Text = "error"; }

            try
            {
                sbyte1 = Convert.ToSByte(input1textBox.Text);
                sbyte1textBox.Text = sbyte1.ToString();
            }

            catch (Exception) { sbyte1textBox.Text = "error"; }

            try
            {
                short1 = Convert.ToInt16(input1textBox.Text);
                short1textBox.Text = short1.ToString();
            }

            catch (Exception) { short1textBox.Text = "error"; }

            try
            {
                ushort1 = Convert.ToUInt16(input1textBox.Text);
                ushort1textBox.Text = ushort1.ToString();
            }

            catch (Exception) { ushort1textBox.Text = "error"; }

            try
            {
                int1 = Convert.ToInt32(input1textBox.Text);
                int1textBox.Text = int1.ToString();
            }

            catch (Exception) { int1textBox.Text = "error"; }

            try
            {
                uint1 = Convert.ToUInt32(input1textBox.Text);
                uint1textBox.Text = uint1.ToString();
            }

            catch (Exception) { uint1textBox.Text = "error"; }

            try
            {
                long1 = Convert.ToInt64(input1textBox.Text);
                long1textBox.Text = long1.ToString();
            }

            catch (Exception) { long1textBox.Text = "error"; }

            try
            {
                ulong1 = Convert.ToUInt64(input1textBox.Text);
                ulong1textBox.Text = ulong1.ToString();
            }

            catch (Exception) { ulong1textBox.Text = "error"; }

            try
            {
                float1 = Convert.ToSingle(input1textBox.Text);
                float1textBox.Text = float1.ToString();
            }

            catch (Exception) { float1textBox.Text = "error"; }

            try
            {
                double1 = Convert.ToDouble(input1textBox.Text);
                double1textBox.Text = double1.ToString();
            }

            catch (Exception) { double1textBox.Text = "error"; }
            try
            {
                decimal1 = Convert.ToDecimal(input1textBox.Text);
                decimal1textBox.Text = decimal1.ToString();
            }

            catch (Exception) { decimal1textBox.Text = "error"; }
        }
    }

        private long long1, long2, long3;
        private ulong ulong1, ulong2, ulong3;
        private float float1, float2, float3;
        private double double1, double2, double3;
        private decimal decimal1, decimal2, decimal3;

        public Form1()
        {
            InitializeComponent();
        }

        private void setMinbutton_Click(object sender, EventArgs e)
        {
            
            byte1 = Byte.MinValue;  byte1textBox.Text = byte1.ToString();
            sbyte1 = SByte.MinValue; sbyte1textBox.Text = sbyte1.ToString();
            short1 = Int16.MinValue; short1textBox.Text = short1.ToString();
            ushort1 = UInt16.MinValue; ushort1textBox.Text = ushort1.ToString();
            int1 = Int32.MinValue; int1textBox.Text = int1.ToString();
            uint1 = UInt32.MinValue; uint1textBox.Text = uint1.ToString();
            long1 = Int64.MinValue; long1textBox.Text = long1.ToString();
            ulong1 = UInt64.MinValue; ulong1textBox.Text = ulong1.ToString();
            float1 = Single.MinValue; float1textBox.Text = float1.ToString();
            double1 = Double.MinValue; double1textBox.Text = double1.ToString();
            decimal1 = Decimal.MinValue; decimal1textBox.Text = decimal1.ToString();



        }

        private void setMaxbutton_Click(object sender, EventArgs e)
        {
            byte byte1, byte2, byte3;
            sbyte sbyte1, sbyte2, sbyte3;
            short short1, short2, short3;
            ushort ushort1, ushort2, ushort3;
            int int1, int2, int3;
            uint uint1, uint2, uint3;
            long long1, long2, long3;
            ulong ulong1, ulong2, ulong3;
            float float1, float2, float3;
            double double1, double2, double3;
            decimal decimal1, decimal2, decimal3;
            byte2 = Byte.MaxValue; byte2textBox.Text = byte2.ToString();
            sbyte2 = SByte.MaxValue; sbyte2textBox.Text = sbyte2.ToString();
            short2 = Int16.MaxValue; short2textBox.Text = short2.ToString();
            ushort2 = UInt16.MaxValue; ushort2textBox.Text = ushort2.ToString();
            int2 = Int32.MaxValue; int2textBox.Text = int2.ToString();
            uint2 = UInt32.MaxValue; uint2textBox.Text = uint2.ToString();
            long2 = Int64.MaxValue; long2textBox.Text = long2.ToString();
            ulong2 = UInt64.MaxValue; ulong2textBox.Text = ulong2.ToString();
            float2 = Single.MaxValue; float2textBox.Text = float2.ToString();
            double2 = Double.MaxValue; double2textBox.Text = double2.ToString();
            decimal2 = Decimal.MinValue; decimal2textBox.Text = decimal2.ToString();
        }

        private void sbyte1textBox_TextChanged(object sender, EventArgs e)
        {
        }
        private void byte1textBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void input1textBox_TextChanged(object sender, EventArgs e)
        {           
            try
            {
                byte1 = Convert.ToByte(input1textBox.Text);
                byte1textBox.Text = byte1.ToString();
            }

            catch (Exception) { byte1textBox.Text = "error"; }

            try
            {
                sbyte1 = Convert.ToSByte(input1textBox.Text);
                sbyte1textBox.Text = sbyte1.ToString();
            }

            catch (Exception) { sbyte1textBox.Text = "error"; }

            try
            {
                short1 = Convert.ToInt16(input1textBox.Text);
                short1textBox.Text = short1.ToString();
            }

            catch (Exception) { short1textBox.Text = "error"; }

            try
            {
                ushort1 = Convert.ToUInt16(input1textBox.Text);
                ushort1textBox.Text = ushort1.ToString();
            }

            catch (Exception) { ushort1textBox.Text = "error"; }

            try
            {
                int1 = Convert.ToInt32(input1textBox.Text);
                int1textBox.Text = int1.ToString();
            }

            catch (Exception) { int1textBox.Text = "error"; }

            try
            {
                uint1 = Convert.ToUInt32(input1textBox.Text);
                uint1textBox.Text = uint1.ToString();
            }

            catch (Exception) { uint1textBox.Text = "error"; }

            try
            {
                long1 = Convert.ToInt64(input1textBox.Text);
                long1textBox.Text = long1.ToString();
            }

            catch (Exception) { long1textBox.Text = "error"; }

            try
            {
                ulong1 = Convert.ToUInt64(input1textBox.Text);
                ulong1textBox.Text = ulong1.ToString();
            }

            catch (Exception) { ulong1textBox.Text = "error"; }

            try
            {
                float1 = Convert.ToSingle(input1textBox.Text);
                float1textBox.Text = float1.ToString();
            }

            catch (Exception) { float1textBox.Text = "error"; }

            try
            {
                double1 = Convert.ToDouble(input1textBox.Text);
                double1textBox.Text = double1.ToString();
            }

            catch (Exception) { double1textBox.Text = "error"; }
            try
            {
                decimal1 = Convert.ToDecimal(input1textBox.Text);
                decimal1textBox.Text = decimal1.ToString();
            }

            catch (Exception) { decimal1textBox.Text = "error"; }
        }
    }
}
