using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppFinal
{
    public partial class FormTongDaySo : Form
    {

        public FormTongDaySo()
        {
            InitializeComponent();
        }
        public void Equal_Click(object sender, EventArgs e)
        {
            double FirstNumber, LastNumber, KhoangCach;
            
            //lay gia tri tu textbox
            FirstNumber = double.Parse(FirstNum.Text);
            LastNumber = double.Parse(LastNum.Text);
            KhoangCach = double.Parse(Space.Text);

            double Ssh, finalNum;
            Ssh = ((LastNumber - FirstNumber)/KhoangCach) + 1;
            finalNum =((LastNumber+FirstNumber)*Ssh) / 2;
            
            MessageBox.Show("Tong day so la: " + finalNum.ToString());
            
            
        }
    }
}
