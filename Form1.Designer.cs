
namespace WinFormsAppFinal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            FirstNum = new Label();
            LastNum = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // FirstNum
            // 
            FirstNum.AutoSize = true;
            FirstNum.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            FirstNum.Location = new Point(234, 128);
            FirstNum.Margin = new Padding(4, 0, 4, 0);
            FirstNum.Name = "FirstNum";
            FirstNum.Size = new Size(90, 20);
            FirstNum.TabIndex = 0;
            FirstNum.Text = "Tai Khoan";
            FirstNum.Click += FirstNum_Click;
            // 
            // LastNum
            // 
            LastNum.AutoSize = true;
            LastNum.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            LastNum.Location = new Point(235, 191);
            LastNum.Margin = new Padding(4, 0, 4, 0);
            LastNum.Name = "LastNum";
            LastNum.Size = new Size(89, 20);
            LastNum.TabIndex = 1;
            LastNum.Text = "Mat Khau";
            LastNum.Click += LastNum_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(370, 120);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(224, 28);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(370, 183);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(224, 28);
            textBox2.TabIndex = 4;
            textBox2.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.Location = new Point(234, 273);
            button1.Name = "button1";
            button1.Size = new Size(150, 40);
            button1.TabIndex = 5;
            button1.Text = "Dang Nhap";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(445, 273);
            button2.Name = "button2";
            button2.Size = new Size(149, 40);
            button2.TabIndex = 6;
            button2.Text = "Thoat";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(769, 428);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(LastNum);
            Controls.Add(FirstNum);
            Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void FirstNum_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LastNum_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label FirstNum;
        private Label LastNum;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
    }
}
