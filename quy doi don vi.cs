using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsAppFinal
{
    public partial class quy_doi_don_vi : Form
    {
        public quy_doi_don_vi()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new string[] { "km", "m", "dm", "cm" });
            comboBox1.SelectedIndex = 0;
            comboBox2.Items.AddRange(new string[] { "km", "m", "dm", "cm" });
            comboBox2.SelectedIndex = 1;
            button1.Click += button1_Click;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ TextBox
            if (double.TryParse(textBox1.Text, out double value))
            {
                if (comboBox1.SelectedItem != null && comboBox2.SelectedItem != null)
                {
                    string fromUnit = comboBox1.SelectedItem.ToString();
                    string toUnit = comboBox2.SelectedItem.ToString();

                    // Thực hiện chuyển đổi
                    double convertedValue = ConvertLength(value, fromUnit, toUnit);

                    // Hiển thị kết quả
                    textBox2.Text = $"{convertedValue}";
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn đơn vị chuyển đổi.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một số hợp lệ.");
            }
        }
        private double ConvertLength(double value, string fromUnit, string toUnit)
        {
            // Đổi tất cả về mét
            double valueInMeters = value;
            switch (fromUnit)
            {
                case "km":
                    valueInMeters = value * 1000;
                    break;
                case "m":
                    valueInMeters = value;
                    break;
                case "dm":
                    valueInMeters = value / 10;
                    break;
                case "cm":
                    valueInMeters = value / 100;
                    break;
            }

            // Đổi từ mét sang đơn vị đích
            double convertedValue = valueInMeters;
            switch (toUnit)
            {
                case "km":
                    convertedValue = valueInMeters / 1000;
                    break;
                case "m":
                    convertedValue = valueInMeters;
                    break;
                case "dm":
                    convertedValue = valueInMeters * 10;
                    break;
                case "cm":
                    convertedValue = valueInMeters * 100;
                    break;
            }

            return convertedValue;
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

       
    }
}
