using Application.IServices;
using Microsoft.Extensions.DependencyInjection;
using MyApplication.Ui;
using System.Resources;

namespace MyApplication
{
    public partial class MainForm : Usf.WinForms.Forms.Form
    {
        public MainForm()
        {
            InitializeComponent();

            #region Language

            ResourceManager resource = new ResourceManager
                ("Resources.DataDictionary", typeof(Resources.DataDictionary).Assembly);

            MenuButton.Text =
                resource.GetString(name: nameof(MenuButton));

            UsersButton.Text =
               resource.GetString(name: nameof(UsersButton));

            ConsomersButton.Text =
                resource.GetString(name: nameof(ConsomersButton));

            CommoditiesButton.Text =
                resource.GetString(name: nameof(CommoditiesButton));

            SupplersButton.Text =
                resource.GetString(name: nameof(SupplersButton));

            StoreroomsButton.Text =
                resource.GetString(name: nameof(StoreroomsButton));

            StorekeepersButton.Text =
                resource.GetString(name: nameof(StorekeepersButton));

            MaesureUnitsButton.Text =
                resource.GetString(name: nameof(MaesureUnitsButton));

            CountriesButton.Text =
                resource.GetString(name: nameof(CountriesButton));

            LoginsHistorButton.Text =
                resource.GetString(name: nameof(LoginsHistorButton));

            AccessButton.Text =
                resource.GetString(name: nameof(AccessButton));

            PasswordButton.Text =
                resource.GetString(name: nameof(PasswordButton));

            BackupButton.Text =
                resource.GetString(name: nameof(BackupButton));

            AboutButton.Text =
                resource.GetString(name: nameof(AboutButton));

            RequestInMainFormButton.Text =
               resource.GetString(name: nameof(RequestInMainFormButton));

            InventoryTransferInMainFormButton.Text =
                resource.GetString(name: nameof(InventoryTransferInMainFormButton));

            FactorInMainFormButton.Text =
                resource.GetString(name: nameof(FactorInMainFormButton));

            ShopingInMainFormButton.Text =
                resource.GetString(name: nameof(ShopingInMainFormButton));

            ReportsInMainFormButton.Text =
                resource.GetString(name: nameof(ReportsInMainFormButton));

            MessagesInMainFormButton.Text =
                resource.GetString(name: nameof(MessagesInMainFormButton));

            this.Text =
                resource.GetString(name: nameof(MainForm));

            #endregion /Language

        }

        // Loaded
        private void MainForm_Load(object sender, EventArgs e)
        {
            if (ApplicationSettings.CurrentCulture == ApplicationSettings.Languages.Farsi)
            {
                this.RightToLeft = RightToLeft.Yes;
                this.RightToLeftLayout = true;
            }
        }

        // Click on Menu Button 
        private void MenuButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolStripMenuItem? Itembutton =
                sender as System.Windows.Forms.ToolStripMenuItem;

            if (Itembutton != null)
            {
                switch (Itembutton.Name)
                {
                    case "UsersButton":
                        {
                            using (var scope = Program.ServiceProvider.CreateScope())
                            {
                                var form = scope.ServiceProvider.GetRequiredService<UsersForm>();
                                form.ShowDialog();
                            }
                            break;
                        }
                    case "ConsomersButton":
                        {
                            new ConsomersForm().ShowDialog();
                            break;
                        }
                    case "CommoditiesButton":
                        {
                            new CommoditiesForm().ShowDialog();
                            break;
                        }
                    case "SupplersButton":
                        {
                            new SupplersForm().ShowDialog();
                            break;
                        }
                    case "AccessButton":
                        {
                            new AccessForm().ShowDialog();
                            break;
                        }
                    case "PasswordButton":
                        {
                            new PasswordForm().ShowDialog();
                            break;
                        }
                    case "BackupButton":
                        {
                            new BackupForm().ShowDialog();
                            break;
                        }
                }
            }
        }

        // Click on Button in the Menu
        private void Button_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolStripButton? button =
                sender as System.Windows.Forms.ToolStripButton;

            if (button != null)
            {
                switch (button.Name)
                {
                    case "RequestInMainFormButton":
                        {
                            new RequestForm().ShowDialog();
                            break;
                        }
                }
            }
        }
    }
}