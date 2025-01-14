using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace textboxes
{
    public partial class Form1 : Form
    {
        int total = 0;
        int totalB = 0;
        int[] bits=new int[8];
        int[] bitsB = new int[8];
        public Form1()
        {
            InitializeComponent();
        }

        private void Calc()
        {
            //clear the total
            total = 0;
            if (bits[0]!=0) total += 1;
            if (bits[1] != 0) total += 2;
            if (bits[2] != 0) total += 4;
            if (bits[3] != 0) total += 8;
            if (bits[4] != 0) total += 16;
            if (bits[5] != 0) total += 32;
            if (bits[6] != 0) total += 64;
            if (bits[7] != 0) total += 128;
TotalLabel.Text=total.ToString();
        }
        private void CalcB()
        {
            //clear the total
            totalB = 0;
            if (bitsB[0] != 0) totalB += 1;
            if (bitsB[1] != 0) totalB += 2;
            if (bitsB[2] != 0) totalB += 4;
            if (bitsB[3] != 0) totalB += 8;
            if (bitsB[4] != 0) totalB += 16;
            if (bitsB[5] != 0) totalB += 32;
            if (bitsB[6] != 0) totalB += 64;
            if (bitsB[7] != 0) totalB += 128;
            TotalLabelB.Text = totalB.ToString();
        }
        private void bit8_TextChanged(object sender, EventArgs e)
        {
            if (bit1.Text == "1")
                bits[0] = 1;
            else
                bits[0] = 0;
            if (bit2.Text == "1")
                bits[1] = 1;
            else
                bits[1] = 0;
            if (bit3.Text == "1")
                bits[2] = 1;
            else
                bits[2] = 0;
            if (bit4.Text == "1")
                bits[3] = 1;
            else
                bits[3] = 0;
            if (bit5.Text == "1")
                bits[4] = 1;
            else
                bits[4] = 0;
            if (bit6.Text == "1")
                bits[5] = 1;
            else
                bits[5] = 0;
            if (bit7.Text == "1")
                bits[6] = 1;
            else
                bits[6] = 0;
            if (bit8.Text == "1")
                bits[7] = 1;
            else
                bits[7] = 0;
            Calc();
        }

        private void bitb8_TextChanged(object sender, EventArgs e)
        {
            if (bitb1.Text == "1")
                bitsB[0] = 1;
            else
                bitsB[0] = 0;
            if (bitb2.Text == "1")
                bitsB[1] = 1;
            else
                bits[1] = 0;
            if (bitb3.Text == "1")
                bitsB[2] = 1;
            else
                bitsB[2] = 0;
            if (bitb4.Text == "1")
                bitsB[3] = 1;
            else
                bitsB[3] = 0;
            if (bitb5.Text == "1")
                bitsB[4] = 1;
            else
                bitsB[4] = 0;
            if (bitb6.Text == "1")
                bitsB[5] = 1;
            else
                bitsB[5] = 0;
            if (bitb7.Text == "1")
                bitsB[6] = 1;
            else
                bitsB[6] = 0;
            if (bitb8.Text == "1")
                bitsB[7] = 1;
            else
                bitsB[7] = 0;
            CalcB();
        }
    }
}
