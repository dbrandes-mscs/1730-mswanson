using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbrandesex2c
{
    public partial class dbrandesex2c : Form
    {
        private byte byte1, byte2, byte3;
        private sbyte sbyte1, sbyte2, sbyte3;
        private short short1, short2, short3;
        private ushort ushort1, ushort2, ushort3;
        private int int1, int2, int3;
        private uint uint1, uint2, uint3;
        private long long1, long2, long3;

        private void divideButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.byte3 = Convert.ToByte(this.byte1 / this.byte2);
                byte3textBox.Text = byte3.ToString();
            }

            catch (Exception) { byte3textBox.Text = "error"; byte3 = 0; }

            try
            {
                this.sbyte3 = Convert.ToSByte(this.sbyte1 / this.sbyte2);
                sbyte3textBox.Text = sbyte3.ToString();
            }

            catch (Exception) { sbyte3textBox.Text = "error"; sbyte3 = 0; }

            try
            {
                this.short3 = Convert.ToInt16(this.short1 / this.short2);
                short3textBox.Text = short3.ToString();
            }

            catch (Exception) { short3textBox.Text = "error"; short3 = 0; }

            try
            {
                this.ushort3 = Convert.ToUInt16(this.ushort1 / this.ushort2);
                ushort3textBox.Text = ushort3.ToString();
            }

            catch (Exception) { ushort3textBox.Text = "error"; ushort3 = 0; }

            try
            {
                this.int3 = checked(this.int1 / this.int2);
                int3textBox.Text = int3.ToString();
            }

            catch (Exception) { int3textBox.Text = "error"; }

            try
            {
                this.uint3 = checked(this.uint1 / this.uint2);
                uint3textBox.Text = uint3.ToString();
            }

            catch (Exception) { uint3textBox.Text = "error"; }

            try
            {
                this.long3 = checked(this.long1 / this.long2);
                long3textBox.Text = long3.ToString();
            }

            catch (Exception) { long3textBox.Text = "error"; }

            try
            {
                this.ulong3 = checked(this.ulong1 / this.ulong2);
                ulong3textBox.Text = ulong3.ToString();
            }

            catch (Exception) { ulong3textBox.Text = "error"; }

            try
            {
                this.float3 = checked(this.float1 / this.float2);
                float3textBox.Text = float3.ToString();
            }

            catch (Exception) { float3textBox.Text = "error"; }

            try
            {
                this.double3 = checked(this.double1 / this.double2);
                double3textBox.Text = double3.ToString();
            }

            catch (Exception) { double3textBox.Text = "error"; }

            try
            {
                this.decimal3 = checked(this.decimal1 / this.decimal2);
                decimal3textBox.Text = decimal3.ToString();
            }

            catch (Exception) { decimal3textBox.Text = "error"; }
        }

        private ulong ulong1, ulong2, ulong3;
        private float float1, float2, float3;
        private double double1, double2, double3;
        private decimal decimal1, decimal2, decimal3;

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.byte3 = Convert.ToByte(this.byte1 * this.byte2);
                byte3textBox.Text = byte3.ToString();
            }

            catch (Exception) { byte3textBox.Text = "error"; byte3 = 0; }

            try
            {
                this.sbyte3 = Convert.ToSByte(this.sbyte1 * this.sbyte2);
                sbyte3textBox.Text = sbyte3.ToString();
            }

            catch (Exception) { sbyte3textBox.Text = "error"; sbyte3 = 0; }

            try
            {
                this.short3 = Convert.ToInt16(this.short1 * this.short2);
                short3textBox.Text = short3.ToString();
            }

            catch (Exception) { short3textBox.Text = "error"; short3 = 0; }

            try
            {
                this.ushort3 = Convert.ToUInt16(this.ushort1 * this.ushort2);
                ushort3textBox.Text = ushort3.ToString();
            }

            catch (Exception) { ushort3textBox.Text = "error"; ushort3 = 0; }

            try
            {
                this.int3 = checked(this.int1 * this.int2);
                int3textBox.Text = int3.ToString();
            }

            catch (Exception) { int3textBox.Text = "error"; }

            try
            {
                this.uint3 = checked(this.uint1 * this.uint2);
                uint3textBox.Text = uint3.ToString();
            }

            catch (Exception) { uint3textBox.Text = "error"; }

            try
            {
                this.long3 = checked(this.long1 * this.long2);
                long3textBox.Text = long3.ToString();
            }

            catch (Exception) { long3textBox.Text = "error"; }

            try
            {
                this.ulong3 = checked(this.ulong1 * this.ulong2);
                ulong3textBox.Text = ulong3.ToString();
            }

            catch (Exception) { ulong3textBox.Text = "error"; }

            try
            {
                this.float3 = checked(this.float1 * this.float2);
                float3textBox.Text = float3.ToString();
            }

            catch (Exception) { float3textBox.Text = "error"; }

            try
            {
                this.double3 = checked(this.double1 * this.double2);
                double3textBox.Text = double3.ToString();
            }

            catch (Exception) { double3textBox.Text = "error"; }

            try
            {
                this.decimal3 = checked(this.decimal1 * this.decimal2);
                decimal3textBox.Text = decimal3.ToString();
            }

            catch (Exception) { decimal3textBox.Text = "error"; }
        }
        
        private void input2textBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                byte2 = Convert.ToByte(input2textBox.Text);
                byte2textBox.Text = byte2.ToString();
            }

            catch (Exception) { byte2textBox.Text = "error"; byte2 = 0; }

            try
            {
                sbyte2 = Convert.ToSByte(input2textBox.Text);
                sbyte2textBox.Text = sbyte2.ToString();
            }

            catch (Exception) { sbyte2textBox.Text = "error"; sbyte2 = 0; }

            try
            {
                short2 = Convert.ToInt16(input2textBox.Text);
                short2textBox.Text = short2.ToString();
            }

            catch (Exception) { short2textBox.Text = "error"; short2 = 0; }

            try
            {
                ushort2 = Convert.ToUInt16(input2textBox.Text);
                ushort2textBox.Text = ushort2.ToString();
            }

            catch (Exception) { ushort2textBox.Text = "error";ushort2 = 0; }

            try
            {
                int2 = Convert.ToInt32(input2textBox.Text);
                int2textBox.Text = int2.ToString();
            }

            catch (Exception) { int2textBox.Text = "error"; int2 = 0; }

            try
            {
                uint2 = Convert.ToUInt32(input2textBox.Text);
                uint2textBox.Text = uint2.ToString();
            }

            catch (Exception) { uint2textBox.Text = "error"; uint2 = 0; }

            try
            {
                long2 = Convert.ToInt64(input2textBox.Text);
                long2textBox.Text = long2.ToString();
            }

            catch (Exception) { long2textBox.Text = "error"; long2 = 0; }

            try
            {
                ulong2 = Convert.ToUInt64(input2textBox.Text);
                ulong2textBox.Text = ulong2.ToString();
            }

            catch (Exception) { ulong2textBox.Text = "error"; ulong2 = 0; }

            try
            {
                float2 = Convert.ToSingle(input2textBox.Text);
                float2textBox.Text = float2.ToString();
            }

            catch (Exception) { float2textBox.Text = "error"; float2 = 0.0f; }

            try
            {
                double2 = Convert.ToDouble(input2textBox.Text);
                double2textBox.Text = double2.ToString();
            }

            catch (Exception) { double2textBox.Text = "error"; double2 = 0.0; }
            try
            {
                decimal2 = Convert.ToDecimal(input2textBox.Text);
                decimal2textBox.Text = decimal2.ToString();
            }

            catch (Exception) { double2textBox.Text = "error"; decimal2 = 0m; }
        }

        private void input1textBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                byte1 = Convert.ToByte(input1textBox.Text);
                byte1textBox.Text = byte1.ToString();
            }

            catch (Exception) { byte1textBox.Text = "error"; byte1 = 0; }

            try
            {
                sbyte1 = Convert.ToSByte(input1textBox.Text);
                sbyte1textBox.Text = sbyte1.ToString();
            }

            catch (Exception) { sbyte1textBox.Text = "error";sbyte1 = 0; }

            try
            {
                short1 = Convert.ToInt16(input1textBox.Text);
                short1textBox.Text = short1.ToString();
            }

            catch (Exception) { short1textBox.Text = "error"; short1 = 0; }

            try
            {
                ushort1 = Convert.ToUInt16(input1textBox.Text);
                ushort1textBox.Text = ushort1.ToString();
            }

            catch (Exception) { ushort1textBox.Text = "error"; ushort1 = 0; }

            try
            {
                int1 = Convert.ToInt32(input1textBox.Text);
                int1textBox.Text = int1.ToString();
            }

            catch (Exception) { int1textBox.Text = "error"; int1 = 0; }

            try
            {
                uint1 = Convert.ToUInt32(input1textBox.Text);
                uint1textBox.Text = uint1.ToString();
            }

            catch (Exception) { uint1textBox.Text = "error"; uint1 = 0; }

            try
            {
                long1 = Convert.ToInt64(input1textBox.Text);
                long1textBox.Text = long1.ToString();
            }

            catch (Exception) { long1textBox.Text = "error"; long1 = 0; }

            try
            {
                ulong1 = Convert.ToUInt64(input1textBox.Text);
                ulong1textBox.Text = ulong1.ToString();
            }

            catch (Exception) { ulong1textBox.Text = "error"; ulong1 = 0; }

            try
            {
                float1 = Convert.ToSingle(input1textBox.Text);
                float1textBox.Text = float1.ToString();
            }

            catch (Exception) { float1textBox.Text = "error"; float1 = 0.0f; }

            try
            {
                double1 = Convert.ToDouble(input1textBox.Text);
                double1textBox.Text = double1.ToString();
            }

            catch (Exception) { double1textBox.Text = "error"; double1 = 0.0; }
            try
            {
                decimal1 = Convert.ToDecimal(input1textBox.Text);
                decimal1textBox.Text = decimal1.ToString();
            }

            catch (Exception) { decimal1textBox.Text = "error"; decimal1 = 0m; }
        }

        private void setMaxbutton_Click(object sender, EventArgs e)
        {
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

        
        public dbrandesex2c()
        {
            InitializeComponent();
        }

        private void setMinbutton_Click(object sender, EventArgs e)
        {

            byte1 = Byte.MinValue; byte1textBox.Text = byte1.ToString();
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

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.byte3 = Convert.ToByte(this.byte1 + this.byte2);
                byte3textBox.Text = byte3.ToString();
            }

            catch (Exception) { byte3textBox.Text = "error"; byte3 = 0; }

            try
            {
                this.sbyte3 = Convert.ToSByte(this.sbyte1 + this.sbyte2);
                sbyte3textBox.Text = sbyte3.ToString();
            }

            catch (Exception) { sbyte3textBox.Text = "error"; sbyte3 = 0; }

            try
            {
                this.short3 = Convert.ToInt16(this.short1 + this.short2);
                short3textBox.Text = short3.ToString();
            }

            catch (Exception) { short3textBox.Text = "error"; short3 = 0; }

            try
            {
                this.ushort3 = Convert.ToUInt16(this.ushort1 + this.ushort2);
                ushort3textBox.Text = ushort3.ToString();
            }

            catch (Exception) { ushort3textBox.Text = "error"; ushort3 = 0; }

            try
            {
                this.int3 = checked(this.int1 + this.int2);
                int3textBox.Text = int3.ToString();
            }

            catch (Exception) { int3textBox.Text = "error"; }

            try
            {
                this.uint3 = checked(this.uint1 + this.uint2);
                uint3textBox.Text = uint3.ToString();
            }

            catch (Exception) { uint3textBox.Text = "error"; }

            try
            {
                this.long3 = checked(this.long1 + this.long2);
                long3textBox.Text = long3.ToString();
            }

            catch (Exception) { long3textBox.Text = "error"; }

            try
            {
                this.ulong3 = checked(this.ulong1 + this.ulong2);
                ulong3textBox.Text = ulong3.ToString();
            }

            catch (Exception) { ulong3textBox.Text = "error"; }

            try
            {
                this.float3 = checked(this.float1 + this.float2);
                float3textBox.Text = float3.ToString();
            }

            catch (Exception) { float3textBox.Text = "error"; }

            try
            {
                this.double3 = checked(this.double1 + this.double2);
                double3textBox.Text = double3.ToString();
            }

            catch (Exception) { double3textBox.Text = "error"; }

            try
            {
                this.decimal3 = checked(this.decimal1 + this.decimal2);
                decimal3textBox.Text = decimal3.ToString();
            }

            catch (Exception) { decimal3textBox.Text = "error"; }
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.byte3 = Convert.ToByte(this.byte1 - this.byte2);
                byte3textBox.Text = byte3.ToString();
            }

            catch (Exception) { byte3textBox.Text = "error"; byte3 = 0; }

            try
            {
                this.sbyte3 = Convert.ToSByte(this.sbyte1 - this.sbyte2);
                sbyte3textBox.Text = sbyte3.ToString();
            }

            catch (Exception) { sbyte3textBox.Text = "error"; sbyte3 = 0; }

            try
            {
                this.short3 = Convert.ToInt16(this.short1 - this.short2);
                short3textBox.Text = short3.ToString();
            }

            catch (Exception) { short3textBox.Text = "error"; short3 = 0; }

            try
            {
                this.ushort3 = Convert.ToUInt16(this.ushort1 - this.ushort2);
                ushort3textBox.Text = ushort3.ToString();
            }

            catch (Exception) { ushort3textBox.Text = "error"; ushort3 = 0; }

            try
            {
                this.int3 = checked(this.int1 - this.int2);
                int3textBox.Text = int3.ToString();
            }

            catch (Exception) { int3textBox.Text = "error"; }

            try
            {
                this.uint3 = checked(this.uint1 - this.uint2);
                uint3textBox.Text = uint3.ToString();
            }

            catch (Exception) { uint3textBox.Text = "error"; }

            try
            {
                this.long3 = checked(this.long1 - this.long2);
                long3textBox.Text = long3.ToString();
            }

            catch (Exception) { long3textBox.Text = "error"; }

            try
            {
                this.ulong3 = checked(this.ulong1 - this.ulong2);
                ulong3textBox.Text = ulong3.ToString();
            }

            catch (Exception) { ulong3textBox.Text = "error"; }

            try
            {
                this.float3 = checked(this.float1 - this.float2);
                float3textBox.Text = float3.ToString();
            }

            catch (Exception) { float3textBox.Text = "error"; }

            try
            {
                this.double3 = checked(this.double1 - this.double2);
                double3textBox.Text = double3.ToString();
            }

            catch (Exception) { double3textBox.Text = "error"; }

            try
            {
                this.decimal3 = checked(this.decimal1 - this.decimal2);
                decimal3textBox.Text = decimal3.ToString();
            }

            catch (Exception) { decimal3textBox.Text = "error"; }
        }
    }
 
}
