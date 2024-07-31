namespace CafeApp
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.payButton = new System.Windows.Forms.Button();
            this.cartListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CheesePictureBox = new System.Windows.Forms.PictureBox();
            this.HotDogPictureBox = new System.Windows.Forms.PictureBox();
            this.HamburgerPictureBox = new System.Windows.Forms.PictureBox();
            this.PizzaPictureBox = new System.Windows.Forms.PictureBox();
            this.CupcakePictureBox = new System.Windows.Forms.PictureBox();
            this.PancakePictureBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CheesePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HotDogPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HamburgerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PizzaPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CupcakePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PancakePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.moneyLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(144, 287);
            this.panel1.TabIndex = 0;
            // 
            // moneyLabel
            // 
            this.moneyLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.moneyLabel.Location = new System.Drawing.Point(0, 253);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(144, 34);
            this.moneyLabel.TabIndex = 2;
            this.moneyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Samo Cafe";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::CafeApp.Resource1.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.payButton);
            this.panel2.Controls.Add(this.cartListBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(595, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(144, 287);
            this.panel2.TabIndex = 1;
            // 
            // payButton
            // 
            this.payButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.payButton.Location = new System.Drawing.Point(0, 238);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(144, 49);
            this.payButton.TabIndex = 2;
            this.payButton.Text = "Pay";
            this.payButton.UseVisualStyleBackColor = true;
            this.payButton.Click += new System.EventHandler(this.payButton_Click);
            // 
            // cartListBox
            // 
            this.cartListBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.cartListBox.FormattingEnabled = true;
            this.cartListBox.ItemHeight = 25;
            this.cartListBox.Location = new System.Drawing.Point(0, 34);
            this.cartListBox.Name = "cartListBox";
            this.cartListBox.Size = new System.Drawing.Size(144, 204);
            this.cartListBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 34);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.PizzaPictureBox);
            this.panel3.Controls.Add(this.CupcakePictureBox);
            this.panel3.Controls.Add(this.PancakePictureBox);
            this.panel3.Controls.Add(this.HamburgerPictureBox);
            this.panel3.Controls.Add(this.HotDogPictureBox);
            this.panel3.Controls.Add(this.CheesePictureBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(144, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(451, 287);
            this.panel3.TabIndex = 2;
            // 
            // CheesePictureBox
            // 
            this.CheesePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheesePictureBox.Image = global::CafeApp.Resource1.cheese;
            this.CheesePictureBox.Location = new System.Drawing.Point(0, 0);
            this.CheesePictureBox.Name = "CheesePictureBox";
            this.CheesePictureBox.Size = new System.Drawing.Size(153, 138);
            this.CheesePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.CheesePictureBox.TabIndex = 3;
            this.CheesePictureBox.TabStop = false;
            this.CheesePictureBox.Click += new System.EventHandler(this.CheesePictureBox_Click);
            // 
            // HotDogPictureBox
            // 
            this.HotDogPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HotDogPictureBox.Image = global::CafeApp.Resource1.hotdog;
            this.HotDogPictureBox.Location = new System.Drawing.Point(297, 0);
            this.HotDogPictureBox.Name = "HotDogPictureBox";
            this.HotDogPictureBox.Size = new System.Drawing.Size(153, 138);
            this.HotDogPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.HotDogPictureBox.TabIndex = 6;
            this.HotDogPictureBox.TabStop = false;
            this.HotDogPictureBox.Click += new System.EventHandler(this.HotDogPictureBox_Click);
            // 
            // HamburgerPictureBox
            // 
            this.HamburgerPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HamburgerPictureBox.Image = global::CafeApp.Resource1.hamburger;
            this.HamburgerPictureBox.Location = new System.Drawing.Point(147, 0);
            this.HamburgerPictureBox.Name = "HamburgerPictureBox";
            this.HamburgerPictureBox.Size = new System.Drawing.Size(153, 138);
            this.HamburgerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.HamburgerPictureBox.TabIndex = 7;
            this.HamburgerPictureBox.TabStop = false;
            this.HamburgerPictureBox.Click += new System.EventHandler(this.HamburgerPictureBox_Click);
            // 
            // PizzaPictureBox
            // 
            this.PizzaPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PizzaPictureBox.Image = global::CafeApp.Resource1.pizza;
            this.PizzaPictureBox.Location = new System.Drawing.Point(147, 144);
            this.PizzaPictureBox.Name = "PizzaPictureBox";
            this.PizzaPictureBox.Size = new System.Drawing.Size(153, 138);
            this.PizzaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PizzaPictureBox.TabIndex = 10;
            this.PizzaPictureBox.TabStop = false;
            this.PizzaPictureBox.Click += new System.EventHandler(this.PizzaPictureBox_Click);
            // 
            // CupcakePictureBox
            // 
            this.CupcakePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CupcakePictureBox.Image = global::CafeApp.Resource1.cupcake;
            this.CupcakePictureBox.Location = new System.Drawing.Point(297, 144);
            this.CupcakePictureBox.Name = "CupcakePictureBox";
            this.CupcakePictureBox.Size = new System.Drawing.Size(153, 138);
            this.CupcakePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.CupcakePictureBox.TabIndex = 9;
            this.CupcakePictureBox.TabStop = false;
            this.CupcakePictureBox.Click += new System.EventHandler(this.CupcakePictureBox_Click);
            // 
            // PancakePictureBox
            // 
            this.PancakePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PancakePictureBox.Image = global::CafeApp.Resource1.pancake;
            this.PancakePictureBox.Location = new System.Drawing.Point(0, 144);
            this.PancakePictureBox.Name = "PancakePictureBox";
            this.PancakePictureBox.Size = new System.Drawing.Size(153, 138);
            this.PancakePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PancakePictureBox.TabIndex = 8;
            this.PancakePictureBox.TabStop = false;
            this.PancakePictureBox.Click += new System.EventHandler(this.PancakePictureBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(739, 287);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SamoCafe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CheesePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HotDogPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HamburgerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PizzaPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CupcakePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PancakePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.Button payButton;
        private System.Windows.Forms.ListBox cartListBox;
        private System.Windows.Forms.PictureBox HamburgerPictureBox;
        private System.Windows.Forms.PictureBox HotDogPictureBox;
        private System.Windows.Forms.PictureBox CheesePictureBox;
        private System.Windows.Forms.PictureBox PizzaPictureBox;
        private System.Windows.Forms.PictureBox CupcakePictureBox;
        private System.Windows.Forms.PictureBox PancakePictureBox;
    }
}

