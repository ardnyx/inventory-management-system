namespace Inventory_Management
{
    partial class Main_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dashbord_BTN = new System.Windows.Forms.Button();
            this.categories_BTN = new System.Windows.Forms.Button();
            this.products_BTN = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inventoryValue = new System.Windows.Forms.Label();
            this.remainingStocks = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.items_lowInStock = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1035, 45);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
            this.panel2.Controls.Add(this.products_BTN);
            this.panel2.Controls.Add(this.categories_BTN);
            this.panel2.Controls.Add(this.dashbord_BTN);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 542);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome, Admin";
            // 
            // dashbord_BTN
            // 
            this.dashbord_BTN.FlatAppearance.BorderSize = 0;
            this.dashbord_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.dashbord_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.dashbord_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashbord_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashbord_BTN.ForeColor = System.Drawing.Color.White;
            this.dashbord_BTN.Location = new System.Drawing.Point(0, 202);
            this.dashbord_BTN.Name = "dashbord_BTN";
            this.dashbord_BTN.Size = new System.Drawing.Size(200, 37);
            this.dashbord_BTN.TabIndex = 1;
            this.dashbord_BTN.Text = "Dashboard";
            this.dashbord_BTN.UseVisualStyleBackColor = true;
            this.dashbord_BTN.Click += new System.EventHandler(this.dashbord_BTN_Click);
            // 
            // categories_BTN
            // 
            this.categories_BTN.FlatAppearance.BorderSize = 0;
            this.categories_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.categories_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.categories_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categories_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categories_BTN.ForeColor = System.Drawing.Color.White;
            this.categories_BTN.Location = new System.Drawing.Point(0, 254);
            this.categories_BTN.Name = "categories_BTN";
            this.categories_BTN.Size = new System.Drawing.Size(200, 37);
            this.categories_BTN.TabIndex = 2;
            this.categories_BTN.Text = "Categories";
            this.categories_BTN.UseVisualStyleBackColor = true;
            this.categories_BTN.Click += new System.EventHandler(this.categories_BTN_Click);
            // 
            // products_BTN
            // 
            this.products_BTN.FlatAppearance.BorderSize = 0;
            this.products_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.products_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.products_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.products_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.products_BTN.ForeColor = System.Drawing.Color.White;
            this.products_BTN.Location = new System.Drawing.Point(0, 308);
            this.products_BTN.Name = "products_BTN";
            this.products_BTN.Size = new System.Drawing.Size(200, 37);
            this.products_BTN.TabIndex = 3;
            this.products_BTN.Text = "Product Management";
            this.products_BTN.UseVisualStyleBackColor = true;
            this.products_BTN.Click += new System.EventHandler(this.products_BTN_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
            this.label2.Location = new System.Drawing.Point(149, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Inventory Management System";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
            this.panel3.Controls.Add(this.inventoryValue);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Location = new System.Drawing.Point(234, 89);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(761, 129);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
            this.panel4.Controls.Add(this.remainingStocks);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(234, 247);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(761, 129);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
            this.panel5.Controls.Add(this.items_lowInStock);
            this.panel5.Controls.Add(this.pictureBox4);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Location = new System.Drawing.Point(234, 403);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(761, 129);
            this.panel5.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(20, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(76, 78);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Location = new System.Drawing.Point(20, 27);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(76, 78);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.Location = new System.Drawing.Point(20, 26);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(76, 78);
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(102, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(373, 55);
            this.label3.TabIndex = 4;
            this.label3.Text = "Inventory Value";
            // 
            // inventoryValue
            // 
            this.inventoryValue.AutoSize = true;
            this.inventoryValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryValue.ForeColor = System.Drawing.Color.White;
            this.inventoryValue.Location = new System.Drawing.Point(105, 20);
            this.inventoryValue.Name = "inventoryValue";
            this.inventoryValue.Size = new System.Drawing.Size(37, 39);
            this.inventoryValue.TabIndex = 5;
            this.inventoryValue.Text = "0";
            // 
            // remainingStocks
            // 
            this.remainingStocks.AutoSize = true;
            this.remainingStocks.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remainingStocks.ForeColor = System.Drawing.Color.White;
            this.remainingStocks.Location = new System.Drawing.Point(105, 22);
            this.remainingStocks.Name = "remainingStocks";
            this.remainingStocks.Size = new System.Drawing.Size(37, 39);
            this.remainingStocks.TabIndex = 7;
            this.remainingStocks.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(102, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(427, 55);
            this.label6.TabIndex = 6;
            this.label6.Text = "Remaining Stocks";
            // 
            // items_lowInStock
            // 
            this.items_lowInStock.AutoSize = true;
            this.items_lowInStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.items_lowInStock.ForeColor = System.Drawing.Color.White;
            this.items_lowInStock.Location = new System.Drawing.Point(105, 20);
            this.items_lowInStock.Name = "items_lowInStock";
            this.items_lowInStock.Size = new System.Drawing.Size(37, 39);
            this.items_lowInStock.TabIndex = 9;
            this.items_lowInStock.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(102, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(444, 55);
            this.label8.TabIndex = 8;
            this.label8.Text = "Items Low in Stock";
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 587);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main_Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button products_BTN;
        private System.Windows.Forms.Button categories_BTN;
        private System.Windows.Forms.Button dashbord_BTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label inventoryValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label remainingStocks;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label items_lowInStock;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label8;
    }
}