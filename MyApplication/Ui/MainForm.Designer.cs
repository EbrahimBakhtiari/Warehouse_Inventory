namespace MyApplication
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            toolStrip1 = new ToolStrip();
            MenuButton = new ToolStripDropDownButton();
            UsersButton = new ToolStripMenuItem();
            ConsomersButton = new ToolStripMenuItem();
            CommoditiesButton = new ToolStripMenuItem();
            SupplersButton = new ToolStripMenuItem();
            StoreroomsButton = new ToolStripMenuItem();
            StorekeepersButton = new ToolStripMenuItem();
            MaesureUnitsButton = new ToolStripMenuItem();
            CountriesButton = new ToolStripMenuItem();
            LoginsHistorButton = new ToolStripMenuItem();
            AccessButton = new ToolStripMenuItem();
            PasswordButton = new ToolStripMenuItem();
            BackupButton = new ToolStripMenuItem();
            AboutButton = new ToolStripMenuItem();
            RequestInMainFormButton = new ToolStripButton();
            InventoryTransferInMainFormButton = new ToolStripButton();
            FactorInMainFormButton = new ToolStripButton();
            ShopingInMainFormButton = new ToolStripButton();
            ReportsInMainFormButton = new ToolStripButton();
            MessagesInMainFormButton = new ToolStripButton();
            pictureBox1 = new PictureBox();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.PowderBlue;
            resources.ApplyResources(toolStrip1, "toolStrip1");
            toolStrip1.Items.AddRange(new ToolStripItem[] { MenuButton, RequestInMainFormButton, InventoryTransferInMainFormButton, FactorInMainFormButton, ShopingInMainFormButton, ReportsInMainFormButton, MessagesInMainFormButton });
            toolStrip1.Name = "toolStrip1";
            // 
            // MenuButton
            // 
            resources.ApplyResources(MenuButton, "MenuButton");
            MenuButton.DropDownItems.AddRange(new ToolStripItem[] { UsersButton, ConsomersButton, CommoditiesButton, SupplersButton, StoreroomsButton, StorekeepersButton, MaesureUnitsButton, CountriesButton, LoginsHistorButton, AccessButton, PasswordButton, BackupButton, AboutButton });
            MenuButton.Name = "MenuButton";
            MenuButton.TextDirection = ToolStripTextDirection.Horizontal;
            // 
            // UsersButton
            // 
            UsersButton.BackColor = Color.LightSkyBlue;
            resources.ApplyResources(UsersButton, "UsersButton");
            UsersButton.Name = "UsersButton";
            UsersButton.Click += MenuButton_Click;
            // 
            // ConsomersButton
            // 
            ConsomersButton.BackColor = Color.DeepSkyBlue;
            resources.ApplyResources(ConsomersButton, "ConsomersButton");
            ConsomersButton.Name = "ConsomersButton";
            ConsomersButton.Click += MenuButton_Click;
            // 
            // CommoditiesButton
            // 
            CommoditiesButton.BackColor = Color.LightSkyBlue;
            resources.ApplyResources(CommoditiesButton, "CommoditiesButton");
            CommoditiesButton.Name = "CommoditiesButton";
            CommoditiesButton.Click += MenuButton_Click;
            // 
            // SupplersButton
            // 
            SupplersButton.BackColor = Color.DeepSkyBlue;
            resources.ApplyResources(SupplersButton, "SupplersButton");
            SupplersButton.Name = "SupplersButton";
            SupplersButton.Click += MenuButton_Click;
            // 
            // StoreroomsButton
            // 
            StoreroomsButton.BackColor = Color.LightSkyBlue;
            resources.ApplyResources(StoreroomsButton, "StoreroomsButton");
            StoreroomsButton.Name = "StoreroomsButton";
            StoreroomsButton.Click += MenuButton_Click;
            // 
            // StorekeepersButton
            // 
            StorekeepersButton.BackColor = Color.DeepSkyBlue;
            resources.ApplyResources(StorekeepersButton, "StorekeepersButton");
            StorekeepersButton.Name = "StorekeepersButton";
            StorekeepersButton.Click += MenuButton_Click;
            // 
            // MaesureUnitsButton
            // 
            MaesureUnitsButton.BackColor = Color.LightSkyBlue;
            resources.ApplyResources(MaesureUnitsButton, "MaesureUnitsButton");
            MaesureUnitsButton.Name = "MaesureUnitsButton";
            MaesureUnitsButton.Click += MenuButton_Click;
            // 
            // CountriesButton
            // 
            CountriesButton.BackColor = Color.DeepSkyBlue;
            resources.ApplyResources(CountriesButton, "CountriesButton");
            CountriesButton.Name = "CountriesButton";
            CountriesButton.Click += MenuButton_Click;
            // 
            // LoginsHistorButton
            // 
            LoginsHistorButton.BackColor = Color.LightSkyBlue;
            resources.ApplyResources(LoginsHistorButton, "LoginsHistorButton");
            LoginsHistorButton.Name = "LoginsHistorButton";
            LoginsHistorButton.Click += MenuButton_Click;
            // 
            // AccessButton
            // 
            AccessButton.BackColor = Color.DeepSkyBlue;
            resources.ApplyResources(AccessButton, "AccessButton");
            AccessButton.Name = "AccessButton";
            AccessButton.Click += MenuButton_Click;
            // 
            // PasswordButton
            // 
            PasswordButton.BackColor = Color.LightSkyBlue;
            resources.ApplyResources(PasswordButton, "PasswordButton");
            PasswordButton.Name = "PasswordButton";
            PasswordButton.Click += MenuButton_Click;
            // 
            // BackupButton
            // 
            BackupButton.BackColor = Color.DeepSkyBlue;
            resources.ApplyResources(BackupButton, "BackupButton");
            BackupButton.Name = "BackupButton";
            BackupButton.Click += MenuButton_Click;
            // 
            // AboutButton
            // 
            AboutButton.BackColor = Color.LightSkyBlue;
            resources.ApplyResources(AboutButton, "AboutButton");
            AboutButton.Name = "AboutButton";
            AboutButton.Click += MenuButton_Click;
            // 
            // RequestInMainFormButton
            // 
            resources.ApplyResources(RequestInMainFormButton, "RequestInMainFormButton");
            RequestInMainFormButton.BackColor = Color.Orange;
            RequestInMainFormButton.Name = "RequestInMainFormButton";
            RequestInMainFormButton.Click += Button_Click;
            // 
            // InventoryTransferInMainFormButton
            // 
            resources.ApplyResources(InventoryTransferInMainFormButton, "InventoryTransferInMainFormButton");
            InventoryTransferInMainFormButton.Name = "InventoryTransferInMainFormButton";
            // 
            // FactorInMainFormButton
            // 
            resources.ApplyResources(FactorInMainFormButton, "FactorInMainFormButton");
            FactorInMainFormButton.Name = "FactorInMainFormButton";
            // 
            // ShopingInMainFormButton
            // 
            resources.ApplyResources(ShopingInMainFormButton, "ShopingInMainFormButton");
            ShopingInMainFormButton.Name = "ShopingInMainFormButton";
            // 
            // ReportsInMainFormButton
            // 
            resources.ApplyResources(ReportsInMainFormButton, "ReportsInMainFormButton");
            ReportsInMainFormButton.Name = "ReportsInMainFormButton";
            // 
            // MessagesInMainFormButton
            // 
            resources.ApplyResources(MessagesInMainFormButton, "MessagesInMainFormButton");
            MessagesInMainFormButton.Name = "MessagesInMainFormButton";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            Appearance.BackColor = (Color)resources.GetObject("MainForm.Appearance.BackColor");
            Appearance.Options.UseBackColor = true;
            Appearance.Options.UseFont = true;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox1);
            Controls.Add(toolStrip1);
            Name = "MainForm";
            Load += MainForm_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton MessagesInMainFormButton;
        private ToolStripButton ReportsInMainFormButton;
        private ToolStripDropDownButton MenuButton;
        private ToolStripMenuItem UsersButton;
        private ToolStripMenuItem AccessButton;
        private ToolStripMenuItem PasswordButton;
        private ToolStripMenuItem BackupButton;
        private PictureBox pictureBox1;
        private ToolStripMenuItem AboutButton;
        private ToolStripMenuItem SupplersButton;
        private ToolStripMenuItem StoreroomsButton;
        private ToolStripMenuItem StorekeepersButton;
        private ToolStripMenuItem MaesureUnitsButton;
        private ToolStripMenuItem CountriesButton;
        private ToolStripMenuItem LoginsHistorButton;
        private ToolStripButton RequestInMainFormButton;
        private ToolStripMenuItem ConsomersButton;
        private ToolStripMenuItem CommoditiesButton;
        private ToolStripButton InventoryTransferInMainFormButton;
        private ToolStripButton FactorInMainFormButton;
        private ToolStripButton ShopingInMainFormButton;
    }
}