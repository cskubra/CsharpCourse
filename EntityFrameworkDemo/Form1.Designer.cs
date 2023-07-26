namespace EntityFrameworkDemo
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
            btnRemove = new Button();
            gbxUpdate = new GroupBox();
            btnUpdate = new Button();
            tbxStockAmountUpdate = new TextBox();
            lblNameUpdate = new Label();
            tbxUnitPriceUpdate = new TextBox();
            lblUnitPriceUpdate = new Label();
            tbxNameUpdate = new TextBox();
            lblStockAmountUpdate = new Label();
            gbxAdd = new GroupBox();
            btnAdd = new Button();
            tbxStockAmount = new TextBox();
            lblName = new Label();
            tbxUnitPrice = new TextBox();
            lblUnitPrice = new Label();
            tbxName = new TextBox();
            lblStockAmount = new Label();
            dgwProducts = new DataGridView();
            gbxUpdate.SuspendLayout();
            gbxAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwProducts).BeginInit();
            SuspendLayout();
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(459, 19);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(100, 23);
            btnRemove.TabIndex = 13;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            // 
            // gbxUpdate
            // 
            gbxUpdate.Controls.Add(btnUpdate);
            gbxUpdate.Controls.Add(tbxStockAmountUpdate);
            gbxUpdate.Controls.Add(lblNameUpdate);
            gbxUpdate.Controls.Add(tbxUnitPriceUpdate);
            gbxUpdate.Controls.Add(lblUnitPriceUpdate);
            gbxUpdate.Controls.Add(tbxNameUpdate);
            gbxUpdate.Controls.Add(lblStockAmountUpdate);
            gbxUpdate.Location = new Point(321, 204);
            gbxUpdate.Name = "gbxUpdate";
            gbxUpdate.Size = new Size(280, 192);
            gbxUpdate.TabIndex = 12;
            gbxUpdate.TabStop = false;
            gbxUpdate.Text = "Update a product";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(94, 149);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 23);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // tbxStockAmountUpdate
            // 
            tbxStockAmountUpdate.Location = new Point(138, 108);
            tbxStockAmountUpdate.Name = "tbxStockAmountUpdate";
            tbxStockAmountUpdate.Size = new Size(100, 23);
            tbxStockAmountUpdate.TabIndex = 6;
            // 
            // lblNameUpdate
            // 
            lblNameUpdate.AutoSize = true;
            lblNameUpdate.Location = new Point(51, 31);
            lblNameUpdate.Name = "lblNameUpdate";
            lblNameUpdate.Size = new Size(39, 15);
            lblNameUpdate.TabIndex = 1;
            lblNameUpdate.Text = "Name";
            // 
            // tbxUnitPriceUpdate
            // 
            tbxUnitPriceUpdate.Location = new Point(138, 67);
            tbxUnitPriceUpdate.Name = "tbxUnitPriceUpdate";
            tbxUnitPriceUpdate.Size = new Size(100, 23);
            tbxUnitPriceUpdate.TabIndex = 5;
            // 
            // lblUnitPriceUpdate
            // 
            lblUnitPriceUpdate.AutoSize = true;
            lblUnitPriceUpdate.Location = new Point(51, 70);
            lblUnitPriceUpdate.Name = "lblUnitPriceUpdate";
            lblUnitPriceUpdate.Size = new Size(58, 15);
            lblUnitPriceUpdate.TabIndex = 2;
            lblUnitPriceUpdate.Text = "Unit Price";
            // 
            // tbxNameUpdate
            // 
            tbxNameUpdate.Location = new Point(138, 28);
            tbxNameUpdate.Name = "tbxNameUpdate";
            tbxNameUpdate.Size = new Size(100, 23);
            tbxNameUpdate.TabIndex = 4;
            // 
            // lblStockAmountUpdate
            // 
            lblStockAmountUpdate.AutoSize = true;
            lblStockAmountUpdate.Location = new Point(51, 111);
            lblStockAmountUpdate.Name = "lblStockAmountUpdate";
            lblStockAmountUpdate.Size = new Size(83, 15);
            lblStockAmountUpdate.TabIndex = 3;
            lblStockAmountUpdate.Text = "Stock Amount";
            // 
            // gbxAdd
            // 
            gbxAdd.Controls.Add(btnAdd);
            gbxAdd.Controls.Add(tbxStockAmount);
            gbxAdd.Controls.Add(lblName);
            gbxAdd.Controls.Add(tbxUnitPrice);
            gbxAdd.Controls.Add(lblUnitPrice);
            gbxAdd.Controls.Add(tbxName);
            gbxAdd.Controls.Add(lblStockAmount);
            gbxAdd.Location = new Point(35, 204);
            gbxAdd.Name = "gbxAdd";
            gbxAdd.Size = new Size(280, 192);
            gbxAdd.TabIndex = 11;
            gbxAdd.TabStop = false;
            gbxAdd.Text = "Add a product";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(94, 149);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 23);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // tbxStockAmount
            // 
            tbxStockAmount.Location = new Point(138, 108);
            tbxStockAmount.Name = "tbxStockAmount";
            tbxStockAmount.Size = new Size(100, 23);
            tbxStockAmount.TabIndex = 6;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(51, 31);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            // 
            // tbxUnitPrice
            // 
            tbxUnitPrice.Location = new Point(138, 67);
            tbxUnitPrice.Name = "tbxUnitPrice";
            tbxUnitPrice.Size = new Size(100, 23);
            tbxUnitPrice.TabIndex = 5;
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.AutoSize = true;
            lblUnitPrice.Location = new Point(51, 70);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new Size(58, 15);
            lblUnitPrice.TabIndex = 2;
            lblUnitPrice.Text = "Unit Price";
            // 
            // tbxName
            // 
            tbxName.Location = new Point(138, 28);
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(100, 23);
            tbxName.TabIndex = 4;
            // 
            // lblStockAmount
            // 
            lblStockAmount.AutoSize = true;
            lblStockAmount.Location = new Point(51, 111);
            lblStockAmount.Name = "lblStockAmount";
            lblStockAmount.Size = new Size(83, 15);
            lblStockAmount.TabIndex = 3;
            lblStockAmount.Text = "Stock Amount";
            // 
            // dgwProducts
            // 
            dgwProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwProducts.Location = new Point(12, 48);
            dgwProducts.Name = "dgwProducts";
            dgwProducts.RowTemplate.Height = 25;
            dgwProducts.Size = new Size(597, 150);
            dgwProducts.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 463);
            Controls.Add(btnRemove);
            Controls.Add(gbxUpdate);
            Controls.Add(gbxAdd);
            Controls.Add(dgwProducts);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            gbxUpdate.ResumeLayout(false);
            gbxUpdate.PerformLayout();
            gbxAdd.ResumeLayout(false);
            gbxAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgwProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnRemove;
        private GroupBox gbxUpdate;
        private Button btnUpdate;
        private TextBox tbxStockAmountUpdate;
        private Label lblNameUpdate;
        private TextBox tbxUnitPriceUpdate;
        private Label lblUnitPriceUpdate;
        private TextBox tbxNameUpdate;
        private Label lblStockAmountUpdate;
        private GroupBox gbxAdd;
        private Button btnAdd;
        private TextBox tbxStockAmount;
        private Label lblName;
        private TextBox tbxUnitPrice;
        private Label lblUnitPrice;
        private TextBox tbxName;
        private Label lblStockAmount;
        private DataGridView dgwProducts;
    }
}