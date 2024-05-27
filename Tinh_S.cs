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
            label2.Text = "Nhập giá trị cạnh thứ nhất:";
            label3.Text = "Nhập giá trị cạnh thứ hai:";
            label4.Text = "Nhập giá trị cạnh thứ ba:";
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
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
            label4.Visible= false;
            textBox3.Visible= false;
            option = 2;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "Nhập đồ dài cạnh:";
            label2.Visible = true;
            textBox1.Visible = true;
            option = 3;
            label3.Visible= false;
            textBox2.Visible= false;
            label4.Visible= false;
            textBox3.Visible=false;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "Nhập bán kính:";
            label2.Visible = true;
            textBox1.Visible = true;
            option = 4;
            label3.Visible = false;
            textBox2.Visible = false;
            label4.Visible = false;
            textBox3.Visible = false;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";


        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (option == 0 )
            {
                MessageBox.Show("Hãy chọn dạng hình và nhập số liệu!");
            }else if (option == 1)
            {
                double a, b, c;
                a = double.Parse(textBox1.Text);
                b = double.Parse(textBox2.Text);
                c = double.Parse(textBox3.Text);
                double P, S;
                P = a + b + c;
                S = Math.Sqrt(P/2 * (P/2 - a) * (P/2 - b) * (P/2 - c));
                MessageBox.Show( "Chu vi của hình tam giác là " + P + "\nDiện tích của hình tam giác là " + S);
                
            }else if(option == 2)
            {
                double a, b;
                a = double.Parse(textBox1.Text);
                b = double.Parse(textBox2.Text);
                double P, S;
                P =  (a + b) * 2;
                S = a * b;
                MessageBox.Show("Chu vi của hình chữ nhật là " + P + "\nDiện tích của hình chữ nhật là " + S);
                
            }
            else if (option == 3)
            {
                double a;
                a = double.Parse(textBox1.Text);

                double P, S;
                P = a * 4;
                S = a * a;
                MessageBox.Show("Chu vi của hình vuông là " + P + "\nDiện tích của hình vuông là " + S);
               
            }
            else
            {
                double a;
                a = double.Parse(textBox1.Text);

                double P, S;
                P = 2 * Math.PI * a ;
                S = Math.PI * a * a;
                MessageBox.Show("Chu vi của hình tròn là " + P + "\nDiện tích của hình tròn là " + S);
                
            }

        }
    }
}
