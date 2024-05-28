namespace WinFormsAppFinal
{
    partial class ListItem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            btnExit = new Button();
            button8 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Location = new Point(250, 59);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(197, 22);
            button1.TabIndex = 0;
            button1.Text = "Tim hai so biet tong hieu";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Location = new Point(250, 100);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(197, 22);
            button2.TabIndex = 1;
            button2.Text = "Tong day so";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Location = new Point(250, 145);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(197, 22);
            button3.TabIndex = 2;
            button3.Text = "So chia het";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.Location = new Point(250, 186);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(197, 22);
            button4.TabIndex = 3;
            button4.Text = "Tinh dien tich";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.White;
            button5.Location = new Point(250, 226);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(197, 22);
            button5.TabIndex = 4;
            button5.Text = "Quy doi don vi";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.White;
            button6.ForeColor = SystemColors.ControlText;
            button6.Location = new Point(250, 269);
            button6.Margin = new Padding(3, 2, 3, 2);
            button6.Name = "button6";
            button6.Size = new Size(197, 22);
            button6.TabIndex = 5;
            button6.Text = "Quan he ti le";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(488, 307);
            btnExit.Margin = new Padding(3, 2, 3, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(78, 22);
            btnExit.TabIndex = 6;
            btnExit.Text = "Dang Xuat";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // button8
            // 
            button8.Location = new Point(592, 307);
            button8.Margin = new Padding(3, 2, 3, 2);
            button8.Name = "button8";
            button8.Size = new Size(88, 22);
            button8.TabIndex = 7;
            button8.Text = "Thoat";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(242, 14);
            label1.Name = "label1";
            label1.Size = new Size(190, 20);
            label1.TabIndex = 8;
            label1.Text = "Các dạng toán cần tính";
            // 
            // ListItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(690, 350);
            Controls.Add(label1);
            Controls.Add(button8);
            Controls.Add(btnExit);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ListItem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            FormClosed += ListItem_FormClosed;
            Load += ListItem_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button btnExit;
        private Button button8;
        private Label label1;
    }
}