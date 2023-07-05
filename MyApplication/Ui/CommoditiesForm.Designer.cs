namespace MyApplication
{
    partial class CommoditiesForm
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            ProductDataGridView = new DataGridView();
            ProductBuyDate = new DataGridViewTextBoxColumn();
            ProductCode = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            ProductCountry = new DataGridViewTextBoxColumn();
            ProductInvoiceNo = new DataGridViewTextBoxColumn();
            ProductSuppler = new DataGridViewTextBoxColumn();
            ProductStoreroom = new DataGridViewTextBoxColumn();
            ProductImage = new DataGridViewTextBoxColumn();
            ProductStoreKepper = new DataGridViewTextBoxColumn();
            ProductStock = new DataGridViewTextBoxColumn();
            ProductUnit = new DataGridViewTextBoxColumn();
            ProductUnitSales = new DataGridViewTextBoxColumn();
            ProductRegistrar = new DataGridViewTextBoxColumn();
            ProductRegisterDate = new DataGridViewTextBoxColumn();
            ProductDescription = new DataGridViewTextBoxColumn();
            SearchLabel = new Usf.WinForms.Forms.Label();
            SearchTextBox = new Usf.WinForms.Forms.TextBox();
            PrintInventoryReceiptButton = new Usf.WinForms.Forms.Button();
            ProductNewButton = new Usf.WinForms.Forms.Button();
            ProductEditButton = new Usf.WinForms.Forms.Button();
            ProductStatusButton = new Usf.WinForms.Forms.Button();
            ProductContextMenuStrip = new ContextMenuStrip(components);
            PriceManagmentToolStripMenuItem = new ToolStripMenuItem();
            StockManagmentToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)ProductDataGridView).BeginInit();
            ProductContextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // ProductDataGridView
            // 
            ProductDataGridView.AllowUserToAddRows = false;
            ProductDataGridView.AllowUserToDeleteRows = false;
            ProductDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ProductDataGridView.BackgroundColor = Color.LemonChiffon;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("B Yekan", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            ProductDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            ProductDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductDataGridView.Columns.AddRange(new DataGridViewColumn[] { ProductBuyDate, ProductCode, ProductName, ProductCountry, ProductInvoiceNo, ProductSuppler, ProductStoreroom, ProductImage, ProductStoreKepper, ProductStock, ProductUnit, ProductUnitSales, ProductRegistrar, ProductRegisterDate, ProductDescription });
            ProductDataGridView.Location = new Point(11, 57);
            ProductDataGridView.Margin = new Padding(4, 5, 4, 5);
            ProductDataGridView.Name = "ProductDataGridView";
            ProductDataGridView.ReadOnly = true;
            ProductDataGridView.RowTemplate.Height = 25;
            ProductDataGridView.Size = new Size(1235, 611);
            ProductDataGridView.TabIndex = 0;
            // 
            // ProductBuyDate
            // 
            ProductBuyDate.HeaderText = "Buy Date";
            ProductBuyDate.Name = "ProductBuyDate";
            ProductBuyDate.ReadOnly = true;
            ProductBuyDate.Width = 160;
            // 
            // ProductCode
            // 
            ProductCode.HeaderText = "Code";
            ProductCode.Name = "ProductCode";
            ProductCode.ReadOnly = true;
            ProductCode.Width = 150;
            // 
            // ProductName
            // 
            ProductName.HeaderText = "Name";
            ProductName.Name = "ProductName";
            ProductName.ReadOnly = true;
            ProductName.Width = 180;
            // 
            // ProductCountry
            // 
            ProductCountry.HeaderText = "Country";
            ProductCountry.Name = "ProductCountry";
            ProductCountry.ReadOnly = true;
            ProductCountry.Width = 80;
            // 
            // ProductInvoiceNo
            // 
            ProductInvoiceNo.HeaderText = "Invoice No";
            ProductInvoiceNo.Name = "ProductInvoiceNo";
            ProductInvoiceNo.ReadOnly = true;
            ProductInvoiceNo.Width = 130;
            // 
            // ProductSuppler
            // 
            ProductSuppler.HeaderText = "Suppler";
            ProductSuppler.Name = "ProductSuppler";
            ProductSuppler.ReadOnly = true;
            ProductSuppler.Width = 150;
            // 
            // ProductStoreroom
            // 
            ProductStoreroom.HeaderText = "Storeroom";
            ProductStoreroom.Name = "ProductStoreroom";
            ProductStoreroom.ReadOnly = true;
            // 
            // ProductImage
            // 
            ProductImage.HeaderText = "Image";
            ProductImage.Name = "ProductImage";
            ProductImage.ReadOnly = true;
            ProductImage.Width = 110;
            // 
            // ProductStoreKepper
            // 
            ProductStoreKepper.HeaderText = "Store Kepper";
            ProductStoreKepper.Name = "ProductStoreKepper";
            ProductStoreKepper.ReadOnly = true;
            ProductStoreKepper.Width = 160;
            // 
            // ProductStock
            // 
            ProductStock.HeaderText = "Stock";
            ProductStock.Name = "ProductStock";
            ProductStock.ReadOnly = true;
            ProductStock.Width = 120;
            // 
            // ProductUnit
            // 
            ProductUnit.HeaderText = "Unit";
            ProductUnit.Name = "ProductUnit";
            ProductUnit.ReadOnly = true;
            ProductUnit.Width = 80;
            // 
            // ProductUnitSales
            // 
            ProductUnitSales.HeaderText = "Unit Sales";
            ProductUnitSales.Name = "ProductUnitSales";
            ProductUnitSales.ReadOnly = true;
            ProductUnitSales.Width = 140;
            // 
            // ProductRegistrar
            // 
            ProductRegistrar.HeaderText = "Registrar";
            ProductRegistrar.Name = "ProductRegistrar";
            ProductRegistrar.ReadOnly = true;
            ProductRegistrar.Width = 150;
            // 
            // ProductRegisterDate
            // 
            ProductRegisterDate.HeaderText = "Register Date";
            ProductRegisterDate.Name = "ProductRegisterDate";
            ProductRegisterDate.ReadOnly = true;
            ProductRegisterDate.Width = 160;
            // 
            // ProductDescription
            // 
            ProductDescription.HeaderText = "Description";
            ProductDescription.Name = "ProductDescription";
            ProductDescription.ReadOnly = true;
            ProductDescription.Width = 500;
            // 
            // SearchLabel
            // 
            SearchLabel.Appearance.Font = new Font("IRANYekan Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SearchLabel.Appearance.ForeColor = Color.Blue;
            SearchLabel.Appearance.Options.UseFont = true;
            SearchLabel.Appearance.Options.UseForeColor = true;
            SearchLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            SearchLabel.Location = new Point(317, 14);
            SearchLabel.Margin = new Padding(3, 4, 3, 4);
            SearchLabel.Name = "SearchLabel";
            SearchLabel.Size = new Size(58, 35);
            SearchLabel.TabIndex = 3;
            SearchLabel.Text = "label1";
            // 
            // SearchTextBox
            // 
            SearchTextBox.Anchor = AnchorStyles.Top;
            SearchTextBox.BackColor = Color.LemonChiffon;
            SearchTextBox.Font = new Font("B Yekan", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SearchTextBox.Location = new Point(439, 5);
            SearchTextBox.Margin = new Padding(4, 5, 4, 5);
            SearchTextBox.Multiline = true;
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(438, 48);
            SearchTextBox.TabIndex = 2;
            SearchTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // PrintInventoryReceiptButton
            // 
            PrintInventoryReceiptButton.Anchor = AnchorStyles.Bottom;
            PrintInventoryReceiptButton.Appearance.BackColor = Color.Pink;
            PrintInventoryReceiptButton.Appearance.Font = new Font("IRANYekan Medium", 18F, FontStyle.Bold, GraphicsUnit.Point);
            PrintInventoryReceiptButton.Appearance.Options.UseBackColor = true;
            PrintInventoryReceiptButton.Appearance.Options.UseFont = true;
            PrintInventoryReceiptButton.Location = new Point(940, 677);
            PrintInventoryReceiptButton.Margin = new Padding(4, 5, 4, 5);
            PrintInventoryReceiptButton.Name = "PrintInventoryReceiptButton";
            PrintInventoryReceiptButton.Size = new Size(249, 75);
            PrintInventoryReceiptButton.TabIndex = 4;
            PrintInventoryReceiptButton.Text = "Inventory Receipt";
            // 
            // ProductNewButton
            // 
            ProductNewButton.Anchor = AnchorStyles.Bottom;
            ProductNewButton.Appearance.BackColor = Color.Pink;
            ProductNewButton.Appearance.Font = new Font("IRANYekan Medium", 18F, FontStyle.Bold, GraphicsUnit.Point);
            ProductNewButton.Appearance.Options.UseBackColor = true;
            ProductNewButton.Appearance.Options.UseFont = true;
            ProductNewButton.Location = new Point(68, 675);
            ProductNewButton.Margin = new Padding(4, 5, 4, 5);
            ProductNewButton.Name = "ProductNewButton";
            ProductNewButton.Size = new Size(249, 75);
            ProductNewButton.TabIndex = 5;
            ProductNewButton.Text = "Add";
            // 
            // ProductEditButton
            // 
            ProductEditButton.Anchor = AnchorStyles.Bottom;
            ProductEditButton.Appearance.BackColor = Color.Pink;
            ProductEditButton.Appearance.Font = new Font("IRANYekan Medium", 18F, FontStyle.Bold, GraphicsUnit.Point);
            ProductEditButton.Appearance.Options.UseBackColor = true;
            ProductEditButton.Appearance.Options.UseFont = true;
            ProductEditButton.Location = new Point(362, 675);
            ProductEditButton.Margin = new Padding(4, 5, 4, 5);
            ProductEditButton.Name = "ProductEditButton";
            ProductEditButton.Size = new Size(249, 75);
            ProductEditButton.TabIndex = 6;
            ProductEditButton.Text = "Edit";
            // 
            // ProductStatusButton
            // 
            ProductStatusButton.Anchor = AnchorStyles.Bottom;
            ProductStatusButton.Appearance.BackColor = Color.Pink;
            ProductStatusButton.Appearance.Font = new Font("IRANYekan Medium", 18F, FontStyle.Bold, GraphicsUnit.Point);
            ProductStatusButton.Appearance.Options.UseBackColor = true;
            ProductStatusButton.Appearance.Options.UseFont = true;
            ProductStatusButton.Location = new Point(651, 675);
            ProductStatusButton.Margin = new Padding(4, 5, 4, 5);
            ProductStatusButton.Name = "ProductStatusButton";
            ProductStatusButton.Size = new Size(249, 75);
            ProductStatusButton.TabIndex = 7;
            ProductStatusButton.Text = "Active/DeActive";
            // 
            // ProductContextMenuStrip
            // 
            ProductContextMenuStrip.Items.AddRange(new ToolStripItem[] { PriceManagmentToolStripMenuItem, StockManagmentToolStripMenuItem });
            ProductContextMenuStrip.Name = "contextMenuStrip1";
            ProductContextMenuStrip.Size = new Size(227, 68);
            ProductContextMenuStrip.Click += ContextMenuItem_Click;
            // 
            // PriceManagmentToolStripMenuItem
            // 
            PriceManagmentToolStripMenuItem.BackColor = Color.Gold;
            PriceManagmentToolStripMenuItem.Font = new Font("IRANYekan Medium", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            PriceManagmentToolStripMenuItem.ForeColor = Color.Maroon;
            PriceManagmentToolStripMenuItem.Name = "PriceManagmentToolStripMenuItem";
            PriceManagmentToolStripMenuItem.Size = new Size(226, 32);
            PriceManagmentToolStripMenuItem.Text = "Price Managment";
            PriceManagmentToolStripMenuItem.Click += ContextMenuItem_Click;
            // 
            // StockManagmentToolStripMenuItem
            // 
            StockManagmentToolStripMenuItem.BackColor = Color.Gold;
            StockManagmentToolStripMenuItem.Font = new Font("IRANYekan Medium", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            StockManagmentToolStripMenuItem.ForeColor = Color.Maroon;
            StockManagmentToolStripMenuItem.Name = "StockManagmentToolStripMenuItem";
            StockManagmentToolStripMenuItem.Size = new Size(226, 32);
            StockManagmentToolStripMenuItem.Text = "Stock Managment";
            StockManagmentToolStripMenuItem.Click += ContextMenuItem_Click;
            // 
            // CommoditiesForm
            // 
            Appearance.BackColor = Color.PaleGreen;
            Appearance.Options.UseBackColor = true;
            Appearance.Options.UseFont = true;
            AutoScaleDimensions = new SizeF(10F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 756);
            Controls.Add(PrintInventoryReceiptButton);
            Controls.Add(ProductNewButton);
            Controls.Add(ProductEditButton);
            Controls.Add(ProductStatusButton);
            Controls.Add(SearchLabel);
            Controls.Add(SearchTextBox);
            Controls.Add(ProductDataGridView);
            Font = new Font("IRANYekan Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(6, 9, 6, 9);
            Name = "CommoditiesForm";
            Text = "CommoditiesForm";
            Load += ProductsForm_Load;
            ((System.ComponentModel.ISupportInitialize)ProductDataGridView).EndInit();
            ProductContextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView ProductDataGridView;
        private Usf.WinForms.Forms.TextBox SearchTextBox;
        private Usf.WinForms.Forms.Label SearchLabel;
        private Usf.WinForms.Forms.Button PrintInventoryReceiptButton;
        private Usf.WinForms.Forms.Button ProductNewButton;
        private Usf.WinForms.Forms.Button ProductEditButton;
        private Usf.WinForms.Forms.Button ProductStatusButton;
        private ToolStripMenuItem PriceManagmentToolStripMenuItem;
        private ToolStripMenuItem StockManagmentToolStripMenuItem;
        private ContextMenuStrip ProductContextMenuStrip;
        private DataGridViewTextBoxColumn ProductBuyDate;
        private DataGridViewTextBoxColumn ProductCode;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn ProductCountry;
        private DataGridViewTextBoxColumn ProductInvoiceNo;
        private DataGridViewTextBoxColumn ProductSuppler;
        private DataGridViewTextBoxColumn ProductStoreroom;
        private DataGridViewTextBoxColumn ProductImage;
        private DataGridViewTextBoxColumn ProductStoreKepper;
        private DataGridViewTextBoxColumn ProductStock;
        private DataGridViewTextBoxColumn ProductUnit;
        private DataGridViewTextBoxColumn ProductUnitSales;
        private DataGridViewTextBoxColumn ProductRegistrar;
        private DataGridViewTextBoxColumn ProductRegisterDate;
        private DataGridViewTextBoxColumn ProductDescription;
    }
}