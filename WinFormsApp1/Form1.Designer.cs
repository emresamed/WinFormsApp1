namespace WinFormsApp1
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
            GirisYapButton = new Button();
            GirisFormLabel = new Label();
            MailGiris = new TextBox();
            KontrolPaneli = new Panel();
            GirisSonuc = new Label();
            KontrolPaneli.SuspendLayout();
            SuspendLayout();
            // 
            // GirisYapButton
            // 
            GirisYapButton.Anchor = AnchorStyles.None;
            GirisYapButton.Location = new Point(12, 59);
            GirisYapButton.Name = "GirisYapButton";
            GirisYapButton.Size = new Size(458, 54);
            GirisYapButton.TabIndex = 0;
            GirisYapButton.Text = "button1";
            GirisYapButton.UseVisualStyleBackColor = true;
            GirisYapButton.Click += button1_Click;
            // 
            // GirisFormLabel
            // 
            GirisFormLabel.AutoSize = true;
            GirisFormLabel.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            GirisFormLabel.Location = new Point(0, 0);
            GirisFormLabel.Name = "GirisFormLabel";
            GirisFormLabel.Size = new Size(111, 23);
            GirisFormLabel.TabIndex = 1;
            GirisFormLabel.Text = "Giris Formu";
            GirisFormLabel.Click += label1_Click;
            // 
            // MailGiris
            // 
            MailGiris.Location = new Point(12, 26);
            MailGiris.Name = "MailGiris";
            MailGiris.Size = new Size(458, 27);
            MailGiris.TabIndex = 2;
            // 
            // KontrolPaneli
            // 
            KontrolPaneli.BackColor = SystemColors.Highlight;
            KontrolPaneli.Controls.Add(GirisSonuc);
            KontrolPaneli.Location = new Point(72, 191);
            KontrolPaneli.Name = "KontrolPaneli";
            KontrolPaneli.Size = new Size(329, 184);
            KontrolPaneli.TabIndex = 3;
            KontrolPaneli.Paint += KontrolPaneli_Paint;
            // 
            // GirisSonuc
            // 
            GirisSonuc.AutoSize = true;
            GirisSonuc.Location = new Point(131, 68);
            GirisSonuc.Name = "GirisSonuc";
            GirisSonuc.Size = new Size(0, 20);
            GirisSonuc.TabIndex = 0;
            GirisSonuc.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(482, 453);
            Controls.Add(KontrolPaneli);
            Controls.Add(MailGiris);
            Controls.Add(GirisFormLabel);
            Controls.Add(GirisYapButton);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            KontrolPaneli.ResumeLayout(false);
            KontrolPaneli.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button GirisYapButton;
        private Label GirisFormLabel;
        private TextBox MailGiris;
        private Panel KontrolPaneli;
        private Label GirisSonuc;
    }
}
