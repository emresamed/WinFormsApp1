namespace WinFormsApp3
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
            number1MaskedTextBox = new MaskedTextBox();
            number2MaskedTextBox = new MaskedTextBox();
            operatorComboBox = new ComboBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            resultsListBox = new ListBox();
            processButton = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // number1MaskedTextBox
            // 
            number1MaskedTextBox.Location = new Point(25, 48);
            number1MaskedTextBox.Mask = "00000000";
            number1MaskedTextBox.Name = "number1MaskedTextBox";
            number1MaskedTextBox.Size = new Size(302, 27);
            number1MaskedTextBox.TabIndex = 3;
            number1MaskedTextBox.ValidatingType = typeof(int);
            // 
            // number2MaskedTextBox
            // 
            number2MaskedTextBox.Location = new Point(25, 95);
            number2MaskedTextBox.Mask = "00000000";
            number2MaskedTextBox.Name = "number2MaskedTextBox";
            number2MaskedTextBox.Size = new Size(302, 27);
            number2MaskedTextBox.TabIndex = 4;
            number2MaskedTextBox.ValidatingType = typeof(int);
            // 
            // operatorComboBox
            // 
            operatorComboBox.FormattingEnabled = true;
            operatorComboBox.Items.AddRange(new object[] { "+", "-", "*", "/" });
            operatorComboBox.Location = new Point(25, 26);
            operatorComboBox.Name = "operatorComboBox";
            operatorComboBox.Size = new Size(151, 28);
            operatorComboBox.TabIndex = 6;
            operatorComboBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(number1MaskedTextBox);
            groupBox1.Controls.Add(number2MaskedTextBox);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(348, 152);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sayilar";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ActiveCaption;
            groupBox2.Controls.Add(operatorComboBox);
            groupBox2.Location = new Point(12, 179);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(348, 74);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Operator";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.ActiveCaption;
            groupBox3.Controls.Add(resultsListBox);
            groupBox3.Location = new Point(12, 317);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(348, 121);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Sonuclar";
            // 
            // resultsListBox
            // 
            resultsListBox.FormattingEnabled = true;
            resultsListBox.Location = new Point(6, 26);
            resultsListBox.Name = "resultsListBox";
            resultsListBox.Size = new Size(336, 84);
            resultsListBox.TabIndex = 0;
            // 
            // processButton
            // 
            processButton.BackColor = SystemColors.ActiveCaption;
            processButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            processButton.Location = new Point(37, 259);
            processButton.Name = "processButton";
            processButton.Size = new Size(302, 52);
            processButton.TabIndex = 7;
            processButton.Text = "Islemi Yap";
            processButton.UseVisualStyleBackColor = false;
            processButton.Click += processButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(372, 450);
            Controls.Add(processButton);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private MaskedTextBox number1MaskedTextBox;
        private MaskedTextBox number2MaskedTextBox;
        private ComboBox operatorComboBox;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private ListBox resultsListBox;
        private Button processButton;
    }
}
