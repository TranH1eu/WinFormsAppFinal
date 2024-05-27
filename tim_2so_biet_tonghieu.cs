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
    public partial class tim_2so_biet_tonghieu : Form
    {
        public tim_2so_biet_tonghieu()
        {
            InitializeComponent();
        }

        private void Button_click(object sender, EventArgs e)
        {
            double Tong, Hieu;

            // Lấy giá trị từ các ô textbox
            Tong = double.Parse(textBox1.Text);
            Hieu = double.Parse(textBox2.Text);

            double bigNum, smallNum;
            bigNum = (Tong + Hieu) / 2;
            smallNum = Tong - bigNum;

            label3.Text = "Giá trị 2 số cần tìm là " + bigNum.ToString() + "và" + smallNum.ToString();
        }

        private void tim_2so_biet_tonghieu_Load(object sender, EventArgs e)
        {

        }
    }

}
