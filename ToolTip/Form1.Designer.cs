namespace ToolTip
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
            this.components = new System.ComponentModel.Container();
            this.buttonToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.listBoxToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.textBoxToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonToolTip
            // 
            this.buttonToolTip.ToolTipTitle = "Button";
            // 
            // listBoxToolTip
            // 
            this.listBoxToolTip.ToolTipTitle = "ListBox";
            // 
            // textBoxToolTip
            // 
            this.textBoxToolTip.ToolTipTitle = "Textbox";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(358, 96);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.buttonToolTip.SetToolTip(this.button1, "Bu bir butondur veriyi islemeye yarar.");
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 242);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(358, 148);
            this.listBox1.TabIndex = 1;
            this.listBoxToolTip.SetToolTip(this.listBox1, "bu bir listboxtir veriyi girdi olarak almamizi saglar.");
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(358, 22);
            this.textBox1.TabIndex = 2;
            this.textBoxToolTip.SetToolTip(this.textBox1, "Bu bir textboxtur verileri sirasiyla yazmaya yarar.");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 402);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip buttonToolTip;
        private System.Windows.Forms.ToolTip listBoxToolTip;
        private System.Windows.Forms.ToolTip textBoxToolTip;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

