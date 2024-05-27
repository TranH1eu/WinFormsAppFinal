
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            FirstNum = new Label();
            LastNum = new Label();
            txtUser = new TextBox();
            txtPass = new TextBox();
            btnLogin = new Button();
            btnExit = new Button();
            label1 = new Label();
            panel1 = new Panel();
            linkLabel1 = new LinkLabel();
            checkBox1 = new CheckBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // FirstNum
            // 
            FirstNum.AutoSize = true;
            FirstNum.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            FirstNum.Location = new Point(14, 19);
            FirstNum.Margin = new Padding(4, 0, 4, 0);
            FirstNum.Name = "FirstNum";
            FirstNum.Size = new Size(88, 20);
            FirstNum.TabIndex = 0;
            FirstNum.Text = "Tài khoản";
            FirstNum.Click += FirstNum_Click;
            // 
            // LastNum
            // 
            LastNum.AutoSize = true;
            LastNum.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            LastNum.Location = new Point(14, 74);
            LastNum.Margin = new Padding(4, 0, 4, 0);
            LastNum.Name = "LastNum";
            LastNum.Size = new Size(85, 20);
            LastNum.TabIndex = 1;
            LastNum.Text = "Mật khẩu";
            LastNum.Click += LastNum_Click;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(111, 11);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(224, 28);
            txtUser.TabIndex = 3;
            txtUser.TextChanged += textBox1_TextChanged;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(111, 66);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(224, 28);
            txtPass.TabIndex = 4;
            txtPass.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnLogin.Location = new Point(21, 186);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(146, 40);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(195, 186);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(140, 40);
            btnExit.TabIndex = 6;
            btnExit.Text = "Đăng ký";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(91, 151);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtUser);
            panel1.Controls.Add(FirstNum);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(LastNum);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(txtPass);
            panel1.Location = new Point(209, 83);
            panel1.Name = "panel1";
            panel1.Size = new Size(360, 248);
            panel1.TabIndex = 8;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            linkLabel1.Location = new Point(219, 118);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(116, 19);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Quên mật khẩu?";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            checkBox1.Location = new Point(22, 118);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(81, 23);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "ghi nhớ";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(750, 437);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
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
        private Panel panel1;
        private CheckBox checkBox1;
        private LinkLabel linkLabel1;
    }
}
