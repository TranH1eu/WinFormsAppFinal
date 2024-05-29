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
            button1.Location = new Point(264, 63);
            button1.Name = "button1";
            button1.Size = new Size(269, 50);
            button1.TabIndex = 0;
            button1.Text = "Tìm hai số biết tổng và hiệu";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Location = new Point(264, 119);
            button2.Name = "button2";
            button2.Size = new Size(269, 53);
            button2.TabIndex = 1;
            button2.Text = "Tổng dãy số cách đều";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Location = new Point(264, 178);
            button3.Name = "button3";
            button3.Size = new Size(269, 53);
            button3.TabIndex = 2;
            button3.Text = "Kiểm tra số chia hết";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.Location = new Point(264, 237);
            button4.Name = "button4";
            button4.Size = new Size(269, 49);
            button4.TabIndex = 3;
            button4.Text = "Tính diện tích";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.White;
            button5.Location = new Point(264, 292);
            button5.Name = "button5";
            button5.Size = new Size(269, 50);
            button5.TabIndex = 4;
            button5.Text = "Quy đổi đơn vị";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.White;
            button6.ForeColor = SystemColors.ControlText;
            button6.Location = new Point(264, 348);
            button6.Name = "button6";
            button6.Size = new Size(269, 49);
            button6.TabIndex = 5;
            button6.Text = "Quan hệ tỉ lệ";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnExit.Location = new Point(57, 398);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(108, 43);
            btnExit.TabIndex = 6;
            btnExit.Text = "Đăng xuất";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button8.Location = new Point(617, 398);
            button8.Name = "button8";
            button8.Size = new Size(110, 43);
            button8.TabIndex = 7;
            button8.Text = "Thoát";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(277, 19);
            label1.Name = "label1";
            label1.Size = new Size(247, 25);
            label1.TabIndex = 8;
            label1.Text = "Các dạng toán cần tính";
            // 
            // ListItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 467);
            Controls.Add(label1);
            Controls.Add(button8);
            Controls.Add(btnExit);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
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