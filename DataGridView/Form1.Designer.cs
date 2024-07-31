namespace DataGridView
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Baslik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Konu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Icerik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.baslikTextBox = new System.Windows.Forms.TextBox();
            this.konuTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.icerikRichTextBox = new System.Windows.Forms.RichTextBox();
            this.veriButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Baslik,
            this.Konu,
            this.Icerik});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(852, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // Baslik
            // 
            this.Baslik.HeaderText = "Baslik";
            this.Baslik.MinimumWidth = 6;
            this.Baslik.Name = "Baslik";
            this.Baslik.Width = 150;
            // 
            // Konu
            // 
            this.Konu.HeaderText = "Konu";
            this.Konu.MinimumWidth = 6;
            this.Konu.Name = "Konu";
            this.Konu.Width = 150;
            // 
            // Icerik
            // 
            this.Icerik.HeaderText = "Icerik";
            this.Icerik.MinimumWidth = 6;
            this.Icerik.Name = "Icerik";
            this.Icerik.Width = 500;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Baslik";
            // 
            // baslikTextBox
            // 
            this.baslikTextBox.Location = new System.Drawing.Point(16, 203);
            this.baslikTextBox.Name = "baslikTextBox";
            this.baslikTextBox.Size = new System.Drawing.Size(823, 22);
            this.baslikTextBox.TabIndex = 2;
            // 
            // konuTextBox
            // 
            this.konuTextBox.Location = new System.Drawing.Point(16, 276);
            this.konuTextBox.Name = "konuTextBox";
            this.konuTextBox.Size = new System.Drawing.Size(823, 22);
            this.konuTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Konu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Icerik";
            // 
            // icerikRichTextBox
            // 
            this.icerikRichTextBox.Location = new System.Drawing.Point(16, 350);
            this.icerikRichTextBox.Name = "icerikRichTextBox";
            this.icerikRichTextBox.Size = new System.Drawing.Size(823, 96);
            this.icerikRichTextBox.TabIndex = 6;
            this.icerikRichTextBox.Text = "";
            // 
            // veriButton
            // 
            this.veriButton.Location = new System.Drawing.Point(212, 452);
            this.veriButton.Name = "veriButton";
            this.veriButton.Size = new System.Drawing.Size(455, 63);
            this.veriButton.TabIndex = 7;
            this.veriButton.Text = "Veriyi Isle";
            this.veriButton.UseVisualStyleBackColor = true;
            this.veriButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 547);
            this.Controls.Add(this.veriButton);
            this.Controls.Add(this.icerikRichTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.konuTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.baslikTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Baslik;
        private System.Windows.Forms.DataGridViewTextBoxColumn Konu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Icerik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox baslikTextBox;
        private System.Windows.Forms.TextBox konuTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox icerikRichTextBox;
        private System.Windows.Forms.Button veriButton;
    }
}

