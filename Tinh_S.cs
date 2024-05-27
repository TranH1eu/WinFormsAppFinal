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
    public partial class Tinh_S : Form
    {
        public Tinh_S()
        {
            InitializeComponent();
        }
        int option = 0;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            option = 1;

        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "Nhập chiều dài:";
            label3.Text = "Nhập chiều rộng:";
            label2.Visible = true;
            label3.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            option = 2;

        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "Nhập đồ dài cạnh:";
            label2.Visible = true;
            textBox1.Visible = true;
            option = 3;

        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "Nhập bán kính:";
            label2.Visible = true;
            textBox1.Visible = true;
            option = 4;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (option == 0)
            {
                label5.Text = "Hãy chọn dạng hình và nhập số liệu!";
            }
            else if (option == 1)
            {
                double a, b, c;
                a = double.Parse(textBox1.Text);
                b = double.Parse(textBox2.Text);
                c = double.Parse(textBox3.Text);
                double P, S;
                P = a + b + c;
                S = Math.Sqrt(P * (P - a) * (P - b) * (P - c));
                label5.Text = "Chu vi của hình tam giác là " + P + "\n Diện tích của hình tam giác là " + S;
                label5.Visible = true;
            }
            else if (option == 2)
            {
                double a, b;
                a = double.Parse(textBox1.Text);
                b = double.Parse(textBox2.Text);
                double P, S;
                P = (a + b) * 2;
                S = a * b;
                label5.Text = "Chu vi của hình chữ nhật là " + P + "\n Diện tích của hình chữ nhật là " + S;
                label5.Visible = true;
            }
            else if (option == 3)
            {
                double a;
                a = double.Parse(textBox1.Text);

                double P, S;
                P = a * 4;
                S = a * a;
                label5.Text = "Chu vi của hình vuông là " + P + "\n Diện tích của hình vuông là " + S;
                label5.Visible = true;
            }
            else
            {
                double a;
                a = double.Parse(textBox1.Text);

                double P, S;
                P = 2 * Math.PI * a;
                S = Math.PI * a * a;
                label5.Text = "Chu vi của hình tròn là " + P + "\n Diện tích của hình tròn là " + S;
                label5.Visible = true;
            }

        }

        private void Tinh_S_Load(object sender, EventArgs e)
        {

        }
    }
}
