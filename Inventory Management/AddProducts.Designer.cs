namespace Inventory_Management
{
    partial class AddProducts
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
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
            this.addProduct_category = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addProduct_prodName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addProduct_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(889, 315);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(14, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "All Products";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(857, 263);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.addProduct_clearBTN);
            this.panel2.Controls.Add(this.addProduct_updateBTN);
            this.panel2.Controls.Add(this.addProduct_removeBTN);
            this.panel2.Controls.Add(this.addProduct_addBTN);
            this.panel2.Controls.Add(this.addProduct_status);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.addProduct_stock);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.addProduct_price);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.addProduct_category);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.addProduct_prodName);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.addProduct_ID);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(16, 346);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(889, 261);
            this.panel2.TabIndex = 1;
            // 
            // addProduct_clearBTN
            // 
            this.addProduct_clearBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
            this.addProduct_clearBTN.FlatAppearance.BorderSize = 0;
            this.addProduct_clearBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProduct_clearBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProduct_clearBTN.ForeColor = System.Drawing.Color.White;
            this.addProduct_clearBTN.Location = new System.Drawing.Point(548, 199);
            this.addProduct_clearBTN.Name = "addProduct_clearBTN";
            this.addProduct_clearBTN.Size = new System.Drawing.Size(103, 34);
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
            this.addProduct_updateBTN.Location = new System.Drawing.Point(419, 199);
            this.addProduct_updateBTN.Name = "addProduct_updateBTN";
            this.addProduct_updateBTN.Size = new System.Drawing.Size(103, 34);
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
            this.addProduct_removeBTN.Location = new System.Drawing.Point(223, 199);
            this.addProduct_removeBTN.Name = "addProduct_removeBTN";
            this.addProduct_removeBTN.Size = new System.Drawing.Size(103, 34);
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
            this.addProduct_addBTN.Location = new System.Drawing.Point(94, 199);
            this.addProduct_addBTN.Name = "addProduct_addBTN";
            this.addProduct_addBTN.Size = new System.Drawing.Size(103, 34);
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
            this.addProduct_status.Location = new System.Drawing.Point(456, 142);
            this.addProduct_status.Name = "addProduct_status";
            this.addProduct_status.Size = new System.Drawing.Size(208, 26);
            this.addProduct_status.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(396, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "Status:";
            // 
            // addProduct_stock
            // 
            this.addProduct_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProduct_stock.Location = new System.Drawing.Point(456, 98);
            this.addProduct_stock.Name = "addProduct_stock";
            this.addProduct_stock.Size = new System.Drawing.Size(170, 24);
            this.addProduct_stock.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(399, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Stock:";
            // 
            // addProduct_price
            // 
            this.addProduct_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProduct_price.Location = new System.Drawing.Point(456, 57);
            this.addProduct_price.Name = "addProduct_price";
            this.addProduct_price.Size = new System.Drawing.Size(170, 24);
            this.addProduct_price.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(404, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Price:";
            // 
            // addProduct_category
            // 
            this.addProduct_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addProduct_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProduct_category.FormattingEnabled = true;
            this.addProduct_category.Location = new System.Drawing.Point(133, 142);
            this.addProduct_category.Name = "addProduct_category";
            this.addProduct_category.Size = new System.Drawing.Size(208, 26);
            this.addProduct_category.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Category:";
            // 
            // addProduct_prodName
            // 
            this.addProduct_prodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProduct_prodName.Location = new System.Drawing.Point(133, 98);
            this.addProduct_prodName.Name = "addProduct_prodName";
            this.addProduct_prodName.Size = new System.Drawing.Size(208, 24);
            this.addProduct_prodName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Product Name:";
            // 
            // addProduct_ID
            // 
            this.addProduct_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProduct_ID.Location = new System.Drawing.Point(133, 57);
            this.addProduct_ID.Name = "addProduct_ID";
            this.addProduct_ID.Size = new System.Drawing.Size(64, 24);
            this.addProduct_ID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product ID:";
            // 
            // AddProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddProducts";
            this.Size = new System.Drawing.Size(920, 625);
            this.Load += new System.EventHandler(this.AddProducts_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addProduct_addBTN;
        private System.Windows.Forms.TextBox addProduct_stock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox addProduct_price;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox addProduct_category;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addProduct_prodName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addProduct_ID;
        private System.Windows.Forms.Button addProduct_clearBTN;
        private System.Windows.Forms.Button addProduct_updateBTN;
        private System.Windows.Forms.Button addProduct_removeBTN;
        private System.Windows.Forms.ComboBox addProduct_status;
        private System.Windows.Forms.Label label7;
    }
}
