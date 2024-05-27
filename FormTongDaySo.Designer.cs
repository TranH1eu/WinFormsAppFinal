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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            LastNum = new TextBox();
            FirstNum = new TextBox();
            Space = new TextBox();
            Equal = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(280, 102);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 0;
            label1.Text = "So Dau:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(280, 166);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 1;
            label2.Text = "So Cuoi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(233, 234);
            label3.Name = "label3";
            label3.Size = new Size(137, 20);
            label3.TabIndex = 2;
            label3.Text = "Khoang cach hai so";
            // 
            // LastNum
            // 
            LastNum.Location = new Point(387, 159);
            LastNum.Name = "LastNum";
            LastNum.Size = new Size(125, 27);
            LastNum.TabIndex = 3;
            // 
            // FirstNum
            // 
            FirstNum.Location = new Point(387, 95);
            FirstNum.Name = "FirstNum";
            FirstNum.Size = new Size(125, 27);
            FirstNum.TabIndex = 4;
            // 
            // Space
            // 
            Space.Location = new Point(387, 231);
            Space.Name = "Space";
            Space.Size = new Size(125, 27);
            Space.TabIndex = 5;
            // 
            // Equal
            // 
            Equal.Location = new Point(340, 336);
            Equal.Name = "Equal";
            Equal.Size = new Size(94, 29);
            Equal.TabIndex = 6;
            Equal.Text = "Ket Qua";
            Equal.UseVisualStyleBackColor = true;
            Equal.Click += this.Equal_Click;
            // 
            // FormTongDaySo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Equal);
            Controls.Add(Space);
            Controls.Add(FirstNum);
            Controls.Add(LastNum);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormTongDaySo";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox LastNum;
        private TextBox FirstNum;
        private TextBox Space;
        private Button Equal;
    }
}