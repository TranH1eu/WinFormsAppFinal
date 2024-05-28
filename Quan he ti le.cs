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
    public partial class Quan_he_ti_le : Form
    {
        public Quan_he_ti_le()
        {
            InitializeComponent();
        }

        private void Quan_he_ti_le_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ TextBox
            if (double.TryParse(textBox1.Text, out double ratio) &&
                double.TryParse(textBox2.Text, out double sumOrDifference))
            {
                double a, b;

                if (radioButton1.Checked)
                {
                    // Tìm hai số khi biết tổng và tỉ lệ
                    a = sumOrDifference / (1 + ratio);
                    b = a * ratio;
                    label4.Text = $"Số thứ nhất: {a}";
                    label5.Text = $"Số thứ hai: {b}";
                }
                else if (radioButton2.Checked)
                {
                    // Tìm hai số khi biết hiệu và tỉ lệ
                    a = sumOrDifference / (1 - ratio);
                    b = a * ratio;
                    label4.Text = $"Số thứ nhất: {a}";
                    label5.Text = $"Số thứ hai: {b}";
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn loại phép toán (tổng hoặc hiệu).");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập các giá trị hợp lệ.");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

