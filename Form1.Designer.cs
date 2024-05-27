
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
            txtUser = new TextBox();
            txtPass = new TextBox();
            btnLogin = new Button();
            btnExit = new Button();
            label1 = new Label();
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
            // txtUser
            // 
            txtUser.Location = new Point(370, 120);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(224, 28);
            txtUser.TabIndex = 3;
            txtUser.TextChanged += textBox1_TextChanged;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(370, 183);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(224, 28);
            txtPass.TabIndex = 4;
            txtPass.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(234, 313);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(150, 40);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Dang Nhap";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(445, 313);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(149, 40);
            btnExit.TabIndex = 6;
            btnExit.Text = "Thoat";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 163);
            label1.Location = new Point(331, 280);
            label1.Name = "label1";
            label1.Size = new Size(169, 15);
            label1.TabIndex = 7;
  //          label1.Text = "Sai tai khoan hoac mat khau!";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(769, 428);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
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
        private TextBox txtUser;
        private TextBox txtPass;
        private Button btnLogin;
        private Button btnExit;
        private Label label1;
    }
}
