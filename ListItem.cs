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
    public partial class ListItem : Form
    {

        bool isThoat = true;

        public ListItem()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            isThoat = false;
            this.Close();
            Form1 f = new Form1();
            f.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (isThoat = true)
            {
                Application.Exit();
            }
        }

        private void ListItem_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isThoat)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tim_2so_biet_tonghieu t = new tim_2so_biet_tonghieu();
            t.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormTongDaySo t = new FormTongDaySo();
            t.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            TimSoChiaHet t = new TimSoChiaHet();
            t.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Tinh_S t = new Tinh_S();
            t.Show();
        }
    }

}
