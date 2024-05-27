
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
            Space = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            btnKq = new Button();
            SuspendLayout();
            // 
            // FirstNum
            // 
            FirstNum.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            FirstNum.AutoSize = true;
            FirstNum.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            FirstNum.Location = new Point(216, 83);
            FirstNum.Margin = new Padding(4, 0, 4, 0);
            FirstNum.Name = "FirstNum";
            FirstNum.Size = new Size(97, 20);
            FirstNum.TabIndex = 0;
            FirstNum.Text = "So dau tien";
            FirstNum.Click += FirstNum_Click;
            // 
            // LastNum
            // 
            LastNum.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LastNum.AutoSize = true;
            LastNum.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            LastNum.Location = new Point(216, 146);
            LastNum.Margin = new Padding(4, 0, 4, 0);
            LastNum.Name = "LastNum";
            LastNum.Size = new Size(143, 20);
            LastNum.TabIndex = 1;
            LastNum.Text = "So dau cuoi cung";
            LastNum.Click += LastNum_Click;
            // 
            // Space
            // 
            Space.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Space.AutoSize = true;
            Space.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            Space.Location = new Point(216, 210);
            Space.Margin = new Padding(4, 0, 4, 0);
            Space.Name = "Space";
            Space.Size = new Size(107, 20);
            Space.TabIndex = 2;
            Space.Text = "khoang cach";
            Space.Click += Space_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(361, 75);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(205, 28);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Location = new Point(361, 138);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(205, 28);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox3.Location = new Point(361, 202);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(205, 28);
            textBox3.TabIndex = 5;
            // 
            // btnKq
            // 
            btnKq.AccessibleRole = AccessibleRole.None;
            btnKq.BackColor = SystemColors.ActiveCaption;
            btnKq.Location = new Point(361, 284);
            btnKq.Name = "btnKq";
            btnKq.Size = new Size(94, 35);
            btnKq.TabIndex = 6;
            btnKq.Text = "Ket Qua";
            btnKq.UseVisualStyleBackColor = false;
            btnKq.Click += btnKq_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(801, 424);
            Controls.Add(btnKq);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(Space);
            Controls.Add(LastNum);
            Controls.Add(FirstNum);
            Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "TongDaySo";
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
        private Label Space;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button btnKq;
    }
}
