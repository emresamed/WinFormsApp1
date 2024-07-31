namespace WinFormsApp1
{
    partial class Form2
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
            erkekRadioButton = new RadioButton();
            kadinRadioButton = new RadioButton();
            digerRadioButton = new RadioButton();
            teknolojiCheckBox = new CheckBox();
            muzikCheckBox = new CheckBox();
            resimCheckBox = new CheckBox();
            kaydetButton = new Button();
            SuspendLayout();
            // 
            // erkekRadioButton
            // 
            erkekRadioButton.AutoSize = true;
            erkekRadioButton.Location = new Point(12, 0);
            erkekRadioButton.Name = "erkekRadioButton";
            erkekRadioButton.Size = new Size(65, 24);
            erkekRadioButton.TabIndex = 0;
            erkekRadioButton.TabStop = true;
            erkekRadioButton.Text = "Erkek";
            erkekRadioButton.UseVisualStyleBackColor = true;
            // 
            // kadinRadioButton
            // 
            kadinRadioButton.AutoSize = true;
            kadinRadioButton.Location = new Point(12, 53);
            kadinRadioButton.Name = "kadinRadioButton";
            kadinRadioButton.Size = new Size(68, 24);
            kadinRadioButton.TabIndex = 1;
            kadinRadioButton.TabStop = true;
            kadinRadioButton.Text = "Kadin";
            kadinRadioButton.UseVisualStyleBackColor = true;
            // 
            // digerRadioButton
            // 
            digerRadioButton.AutoSize = true;
            digerRadioButton.Location = new Point(12, 109);
            digerRadioButton.Name = "digerRadioButton";
            digerRadioButton.Size = new Size(67, 24);
            digerRadioButton.TabIndex = 2;
            digerRadioButton.TabStop = true;
            digerRadioButton.Text = "Diger";
            digerRadioButton.UseVisualStyleBackColor = true;
            // 
            // teknolojiCheckBox
            // 
            teknolojiCheckBox.AutoSize = true;
            teknolojiCheckBox.Location = new Point(12, 169);
            teknolojiCheckBox.Name = "teknolojiCheckBox";
            teknolojiCheckBox.Size = new Size(91, 24);
            teknolojiCheckBox.TabIndex = 3;
            teknolojiCheckBox.Text = "Teknoloji";
            teknolojiCheckBox.UseVisualStyleBackColor = true;
            teknolojiCheckBox.CheckedChanged += teknolojiCheckBox_CheckedChanged;
            // 
            // muzikCheckBox
            // 
            muzikCheckBox.AutoSize = true;
            muzikCheckBox.Location = new Point(121, 169);
            muzikCheckBox.Name = "muzikCheckBox";
            muzikCheckBox.Size = new Size(70, 24);
            muzikCheckBox.TabIndex = 4;
            muzikCheckBox.Text = "Muzik";
            muzikCheckBox.UseVisualStyleBackColor = true;
            // 
            // resimCheckBox
            // 
            resimCheckBox.AutoSize = true;
            resimCheckBox.Location = new Point(221, 169);
            resimCheckBox.Name = "resimCheckBox";
            resimCheckBox.Size = new Size(71, 24);
            resimCheckBox.TabIndex = 5;
            resimCheckBox.Text = "Resim";
            resimCheckBox.UseVisualStyleBackColor = true;
            resimCheckBox.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // kaydetButton
            // 
            kaydetButton.Location = new Point(12, 238);
            kaydetButton.Name = "kaydetButton";
            kaydetButton.Size = new Size(315, 82);
            kaydetButton.TabIndex = 6;
            kaydetButton.Text = "Kaydet";
            kaydetButton.UseVisualStyleBackColor = true;
            kaydetButton.Click += kaydetButton_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(339, 359);
            Controls.Add(kaydetButton);
            Controls.Add(resimCheckBox);
            Controls.Add(muzikCheckBox);
            Controls.Add(teknolojiCheckBox);
            Controls.Add(digerRadioButton);
            Controls.Add(kadinRadioButton);
            Controls.Add(erkekRadioButton);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton erkekRadioButton;
        private RadioButton kadinRadioButton;
        private RadioButton digerRadioButton;
        private CheckBox teknolojiCheckBox;
        private CheckBox muzikCheckBox;
        private CheckBox resimCheckBox;
        private Button kaydetButton;
    }
}