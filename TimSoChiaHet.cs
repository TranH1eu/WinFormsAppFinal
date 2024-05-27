using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WinFormsAppFinal
{
    public partial class TimSoChiaHet : Form
    {

        int check;
        public TimSoChiaHet()
        {
            InitializeComponent();
        }



        private void TimSoChiaHet_Load(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
           
            double num;
            num = double.Parse(NumChecked.Text);
            string finalEqual = "";
            if(ck2.Checked) {
                if (num % 2 == 0) finalEqual += "chia het 2\n";
                else finalEqual += "khong chia het cho 2\n";
            }


            if (ck3.Checked)
            {
                if (num % 3 == 0) finalEqual += "chia het 3\n";
                else finalEqual += "khong chia het cho 3\n";
            }

            if (ck5.Checked)
            {
                if (num % 5 == 0) finalEqual += "chia het 5\n";
                else finalEqual += "khong chia het cho 5\n";
            }
            /*if (check == 1)
            {
                if (num % 2 == 0) finalEqual = "Chia het cho 2";
                else finalEqual += "";
            }
            else if(check == 5)
            {
                if (num % 3 == 0) finalEqual = "Chia het cho 3";
                else finalEqual += "";
            }
            else if (check == 10)
            {
                if (num % 5 == 0) finalEqual = "Chia het cho 5";
                else finalEqual += "";
            }
            else if (check == 6)
            {
                if (num % 3 == 0) finalEqual += "Chia het cho 3\n";
                if (num % 2 == 0) finalEqual += "Chia het cho 2";
                else finalEqual += "";
            }
            else if (check == 11)
            {
                if (num % 5 == 0) finalEqual += "Chia het cho 5\n";
                if (num % 2 == 0) finalEqual += "Chia het cho 2";
                else finalEqual += "";
            }
            else if(check == 15)
            {
                if (num % 5 == 0) finalEqual += "Chia het cho 5\n";
                if (num % 3 == 0) finalEqual += "Chia het cho 3";
                else finalEqual += "";
            }
            else if(check == 16)
            {
                if (num % 2 == 0) finalEqual += "Chia het cho 2\n";
                if (num % 5 == 0) finalEqual += "Chia het cho 5\n";
                if (num % 3 == 0) finalEqual += "Chia het cho 3";
                else finalEqual += "";
            }*/
            MessageBox.Show(finalEqual);
        }

        private void ck2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void ck3_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void ck5_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
