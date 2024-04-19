namespace Inventory_Management
{
    partial class ProductManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductManagement));
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.products_BTN = new System.Windows.Forms.Button();
            this.dashboard_BTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.addProduct_category = new System.Windows.Forms.TextBox();
            this.addProduct_clearBTN = new System.Windows.Forms.Button();
            this.addProduct_updateBTN = new System.Windows.Forms.Button();
            this.addProduct_removeBTN = new System.Windows.Forms.Button();
            this.addProduct_addBTN = new System.Windows.Forms.Button();
            this.addProduct_status = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addProduct_stock = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addProduct_price = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addProduct_prodName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addProduct_ID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1035, 45);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
            this.panel2.Controls.Add(this.products_BTN);
            this.panel2.Controls.Add(this.dashboard_BTN);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 542);
            this.panel2.TabIndex = 2;
            // 
            // products_BTN
            // 
            this.products_BTN.FlatAppearance.BorderSize = 0;
            this.products_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.products_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.products_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.products_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.products_BTN.ForeColor = System.Drawing.Color.White;
            this.products_BTN.Location = new System.Drawing.Point(0, 263);
            this.products_BTN.Name = "products_BTN";
            this.products_BTN.Size = new System.Drawing.Size(200, 37);
            this.products_BTN.TabIndex = 3;
            this.products_BTN.Text = "Product Management";
            this.products_BTN.UseVisualStyleBackColor = true;
            this.products_BTN.Click += new System.EventHandler(this.products_BTN_Click);
            // 
            // dashboard_BTN
            // 
            this.dashboard_BTN.FlatAppearance.BorderSize = 0;
            this.dashboard_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.dashboard_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.dashboard_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboard_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_BTN.ForeColor = System.Drawing.Color.White;
            this.dashboard_BTN.Location = new System.Drawing.Point(0, 202);
            this.dashboard_BTN.Name = "dashboard_BTN";
            this.dashboard_BTN.Size = new System.Drawing.Size(200, 37);
            this.dashboard_BTN.TabIndex = 1;
            this.dashboard_BTN.Text = "Dashboard";
            this.dashboard_BTN.UseVisualStyleBackColor = true;
            this.dashboard_BTN.Click += new System.EventHandler(this.dashboard_BTN_Click);
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.addProduct_category);
            this.panel3.Controls.Add(this.addProduct_clearBTN);
            this.panel3.Controls.Add(this.addProduct_updateBTN);
            this.panel3.Controls.Add(this.addProduct_removeBTN);
            this.panel3.Controls.Add(this.addProduct_addBTN);
            this.panel3.Controls.Add(this.addProduct_status);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.addProduct_stock);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.addProduct_price);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.addProduct_prodName);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.addProduct_ID);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(216, 364);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(793, 211);
            this.panel3.TabIndex = 4;
            // 
            // addProduct_category
            // 
            this.addProduct_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProduct_category.Location = new System.Drawing.Point(136, 110);
            this.addProduct_category.Name = "addProduct_category";
            this.addProduct_category.Size = new System.Drawing.Size(177, 24);
            this.addProduct_category.TabIndex = 17;
            // 
            // addProduct_clearBTN
            // 
            this.addProduct_clearBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
            this.addProduct_clearBTN.FlatAppearance.BorderSize = 0;
            this.addProduct_clearBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProduct_clearBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProduct_clearBTN.ForeColor = System.Drawing.Color.White;
            this.addProduct_clearBTN.Location = new System.Drawing.Point(541, 153);
            this.addProduct_clearBTN.Name = "addProduct_clearBTN";
            this.addProduct_clearBTN.Size = new System.Drawing.Size(88, 40);
            this.addProduct_clearBTN.TabIndex = 16;
            this.addProduct_clearBTN.Text = "Clear";
            this.addProduct_clearBTN.UseVisualStyleBackColor = false;
            this.addProduct_clearBTN.Click += new System.EventHandler(this.addProduct_clearBTN_Click);
            // 
            // addProduct_updateBTN
            // 
            this.addProduct_updateBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
            this.addProduct_updateBTN.FlatAppearance.BorderSize = 0;
            this.addProduct_updateBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProduct_updateBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProduct_updateBTN.ForeColor = System.Drawing.Color.White;
            this.addProduct_updateBTN.Location = new System.Drawing.Point(412, 153);
            this.addProduct_updateBTN.Name = "addProduct_updateBTN";
            this.addProduct_updateBTN.Size = new System.Drawing.Size(88, 40);
            this.addProduct_updateBTN.TabIndex = 15;
            this.addProduct_updateBTN.Text = "Update";
            this.addProduct_updateBTN.UseVisualStyleBackColor = false;
            this.addProduct_updateBTN.Click += new System.EventHandler(this.addProduct_updateBTN_Click);
            // 
            // addProduct_removeBTN
            // 
            this.addProduct_removeBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
            this.addProduct_removeBTN.FlatAppearance.BorderSize = 0;
            this.addProduct_removeBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProduct_removeBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProduct_removeBTN.ForeColor = System.Drawing.Color.White;
            this.addProduct_removeBTN.Location = new System.Drawing.Point(225, 153);
            this.addProduct_removeBTN.Name = "addProduct_removeBTN";
            this.addProduct_removeBTN.Size = new System.Drawing.Size(88, 40);
            this.addProduct_removeBTN.TabIndex = 14;
            this.addProduct_removeBTN.Text = "Remove";
            this.addProduct_removeBTN.UseVisualStyleBackColor = false;
            this.addProduct_removeBTN.Click += new System.EventHandler(this.addProduct_removeBTN_Click);
            // 
            // addProduct_addBTN
            // 
            this.addProduct_addBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
            this.addProduct_addBTN.FlatAppearance.BorderSize = 0;
            this.addProduct_addBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProduct_addBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProduct_addBTN.ForeColor = System.Drawing.Color.White;
            this.addProduct_addBTN.Location = new System.Drawing.Point(96, 153);
            this.addProduct_addBTN.Name = "addProduct_addBTN";
            this.addProduct_addBTN.Size = new System.Drawing.Size(88, 40);
            this.addProduct_addBTN.TabIndex = 13;
            this.addProduct_addBTN.Text = "Add";
            this.addProduct_addBTN.UseVisualStyleBackColor = false;
            this.addProduct_addBTN.Click += new System.EventHandler(this.addProduct_addBTN_Click);
            // 
            // addProduct_status
            // 
            this.addProduct_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addProduct_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProduct_status.FormattingEnabled = true;
            this.addProduct_status.Items.AddRange(new object[] {
            "Available",
            "Not Available"});
            this.addProduct_status.Location = new System.Drawing.Point(459, 108);
            this.addProduct_status.Name = "addProduct_status";
            this.addProduct_status.Size = new System.Drawing.Size(177, 26);
            this.addProduct_status.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(399, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "Status:";
            // 
            // addProduct_stock
            // 
            this.addProduct_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProduct_stock.Location = new System.Drawing.Point(459, 64);
            this.addProduct_stock.Name = "addProduct_stock";
            this.addProduct_stock.Size = new System.Drawing.Size(139, 24);
            this.addProduct_stock.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(402, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Stock:";
            // 
            // addProduct_price
            // 
            this.addProduct_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProduct_price.Location = new System.Drawing.Point(459, 23);
            this.addProduct_price.Name = "addProduct_price";
            this.addProduct_price.Size = new System.Drawing.Size(139, 24);
            this.addProduct_price.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(407, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Category:";
            // 
            // addProduct_prodName
            // 
            this.addProduct_prodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProduct_prodName.Location = new System.Drawing.Point(136, 64);
            this.addProduct_prodName.Name = "addProduct_prodName";
            this.addProduct_prodName.Size = new System.Drawing.Size(177, 24);
            this.addProduct_prodName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Product Name:";
            // 
            // addProduct_ID
            // 
            this.addProduct_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProduct_ID.Location = new System.Drawing.Point(136, 23);
            this.addProduct_ID.Name = "addProduct_ID";
            this.addProduct_ID.Size = new System.Drawing.Size(53, 24);
            this.addProduct_ID.TabIndex = 1;
            this.addProduct_ID.TextChanged += new System.EventHandler(this.addProduct_ID_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(48, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "Product ID:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Location = new System.Drawing.Point(216, 51);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(793, 300);
            this.panel4.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(14, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 24);
            this.label9.TabIndex = 9;
            this.label9.Text = "All Products";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(761, 248);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ProductManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 587);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductManagement";
            this.Load += new System.EventHandler(this.ProductManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button products_BTN;
        private System.Windows.Forms.Button dashboard_BTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox addProduct_category;
        private System.Windows.Forms.Button addProduct_clearBTN;
        private System.Windows.Forms.Button addProduct_updateBTN;
        private System.Windows.Forms.Button addProduct_removeBTN;
        private System.Windows.Forms.Button addProduct_addBTN;
        private System.Windows.Forms.ComboBox addProduct_status;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox addProduct_stock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox addProduct_price;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addProduct_prodName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addProduct_ID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}