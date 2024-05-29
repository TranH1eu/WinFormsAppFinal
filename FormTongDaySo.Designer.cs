namespace WinFormsAppFinal
{
    partial class FormTongDaySo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTongDaySo));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            LastNum = new TextBox();
            FirstNum = new TextBox();
            Space = new TextBox();
            Equal = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(48, 12);
            label1.Name = "label1";
            label1.Size = new Size(118, 23);
            label1.TabIndex = 0;
            label1.Text = "Số hạng đầu:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label2.Location = new Point(48, 80);
            label2.Name = "label2";
            label2.Size = new Size(122, 23);
            label2.TabIndex = 1;
            label2.Text = "Số hạng cuối:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label3.Location = new Point(44, 148);
            label3.Name = "label3";
            label3.Size = new Size(124, 23);
            label3.TabIndex = 2;
            label3.Text = "Khoảng cách:";
            // 
            // LastNum
            // 
            LastNum.Location = new Point(224, 76);
            LastNum.Name = "LastNum";
            LastNum.Size = new Size(125, 27);
            LastNum.TabIndex = 3;
            // 
            // FirstNum
            // 
            FirstNum.Location = new Point(224, 12);
            FirstNum.Name = "FirstNum";
            FirstNum.Size = new Size(125, 27);
            FirstNum.TabIndex = 4;
            // 
            // Space
            // 
            Space.Location = new Point(224, 148);
            Space.Name = "Space";
            Space.Size = new Size(125, 27);
            Space.TabIndex = 5;
            // 
            // Equal
            // 
            Equal.AutoEllipsis = true;
            Equal.BackColor = Color.White;
            Equal.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            Equal.Location = new Point(345, 337);
            Equal.Name = "Equal";
            Equal.Size = new Size(116, 41);
            Equal.TabIndex = 6;
            Equal.Text = "Kết Quả";
            Equal.UseVisualStyleBackColor = false;
            Equal.Click += Equal_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(Space);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(FirstNum);
            panel1.Controls.Add(LastNum);
            panel1.Location = new Point(212, 115);
            panel1.Name = "panel1";
            panel1.Size = new Size(394, 186);
            panel1.TabIndex = 7;
            // 
            // FormTongDaySo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(Equal);
            ForeColor = SystemColors.ControlText;
            Name = "FormTongDaySo";
            RightToLeft = RightToLeft.No;
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox LastNum;
        private TextBox FirstNum;
        private TextBox Space;
        private Button Equal;
        private Panel panel1;
    }
}