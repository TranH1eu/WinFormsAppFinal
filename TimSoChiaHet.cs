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
                if (num % 2 == 0) finalEqual +="Số " + NumChecked.Text + " chia hết cho 2\n";
                else finalEqual += "Số " + NumChecked.Text + " không chia hết cho 2\n";
            }


            if (ck3.Checked)
            {
                if (num % 3 == 0) finalEqual += "Số " + NumChecked.Text + " chia hết cho 3\n";
                else finalEqual += "Số " + NumChecked.Text + " không chia hết cho 3\n";
            }

            if (ck5.Checked)
            {
                if (num % 5 == 0) finalEqual += "Số " + NumChecked.Text + " chia hết cho 5\n";
                else finalEqual += "Số " + NumChecked.Text + " không chia hết cho 2\n";
            }
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
