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
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Location = new Point(286, 79);
            button1.Name = "button1";
            button1.Size = new Size(225, 29);
            button1.TabIndex = 0;
            button1.Text = "Tim hai so biet tong hieu";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Location = new Point(286, 133);
            button2.Name = "button2";
            button2.Size = new Size(225, 29);
            button2.TabIndex = 1;
            button2.Text = "Tong day so";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Location = new Point(286, 193);
            button3.Name = "button3";
            button3.Size = new Size(225, 29);
            button3.TabIndex = 2;
            button3.Text = "So chia het";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.Location = new Point(286, 248);
            button4.Name = "button4";
            button4.Size = new Size(225, 29);
            button4.TabIndex = 3;
            button4.Text = "Tinh dien tich";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.White;
            button5.Location = new Point(286, 301);
            button5.Name = "button5";
            button5.Size = new Size(225, 29);
            button5.TabIndex = 4;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.White;
            button6.ForeColor = SystemColors.ControlText;
            button6.Location = new Point(286, 359);
            button6.Name = "button6";
            button6.Size = new Size(225, 29);
            button6.TabIndex = 5;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(558, 409);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(89, 29);
            btnExit.TabIndex = 6;
            btnExit.Text = "Dang Xuat";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // button8
            // 
            button8.Location = new Point(677, 409);
            button8.Name = "button8";
            button8.Size = new Size(100, 29);
            button8.TabIndex = 7;
            button8.Text = "Thoat";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // ListItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 467);
            Controls.Add(button8);
            Controls.Add(btnExit);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "ListItem";
            Text = "Form2";
            FormClosed += ListItem_FormClosed;
            ResumeLayout(false);
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
    }
}