namespace WinFormsAppFinal
{
    partial class TimSoChiaHet
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
            btnCheck = new Button();
            NumChecked = new TextBox();
            label1 = new Label();
            ck5 = new CheckBox();
            ck3 = new CheckBox();
            ck2 = new CheckBox();
            SuspendLayout();
            // 
            // btnCheck
            // 
            btnCheck.Location = new Point(351, 330);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(94, 29);
            btnCheck.TabIndex = 0;
            btnCheck.Text = "Kiem Tra";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // NumChecked
            // 
            NumChecked.Location = new Point(387, 97);
            NumChecked.Name = "NumChecked";
            NumChecked.Size = new Size(125, 27);
            NumChecked.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(286, 104);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 5;
            label1.Text = "Nhap So:";
            // 
            // ck5
            // 
            ck5.AutoSize = true;
            ck5.Location = new Point(317, 263);
            ck5.Name = "ck5";
            ck5.Size = new Size(183, 24);
            ck5.TabIndex = 4;
            ck5.Text = "Kiem tra chia het cho 5";
            ck5.UseVisualStyleBackColor = true;
            ck5.CheckedChanged += ck5_CheckedChanged;
            // 
            // ck3
            // 
            ck3.AutoSize = true;
            ck3.Location = new Point(317, 209);
            ck3.Name = "ck3";
            ck3.Size = new Size(183, 24);
            ck3.TabIndex = 3;
            ck3.Text = "Kiem tra chia het cho 3";
            ck3.UseVisualStyleBackColor = true;
            ck3.CheckedChanged += ck3_CheckedChanged;
            // 
            // ck2
            // 
            ck2.AutoSize = true;
            ck2.Location = new Point(317, 158);
            ck2.Name = "ck2";
            ck2.Size = new Size(183, 24);
            ck2.TabIndex = 2;
            ck2.Text = "Kiem tra chia het cho 2";
            ck2.UseVisualStyleBackColor = true;
            ck2.CheckedChanged += ck2_CheckedChanged;
            // 
            // TimSoChiaHet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ck5);
            Controls.Add(ck3);
            Controls.Add(ck2);
            Controls.Add(label1);
            Controls.Add(NumChecked);
            Controls.Add(btnCheck);
            Name = "TimSoChiaHet";
            StartPosition = FormStartPosition.CenterParent;
            Text = "TimSoChiaHet";
            Load += TimSoChiaHet_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCheck;
        private TextBox NumChecked;
        private Label label1;
        private CheckBox ck5;
        private CheckBox ck3;
        private CheckBox ck2;
    }
}