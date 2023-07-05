using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;
using MyApplication.Ui;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApplication
{
    public partial class CommoditiesForm : Usf.WinForms.Forms.Form
    {
        public CommoditiesForm()
        {
            InitializeComponent();

            this.ContextMenuStrip = ProductContextMenuStrip;

            #region Language

            ResourceManager resource = new ResourceManager
                ("Resources.DataDictionary", typeof(Resources.DataDictionary).Assembly);

            SearchLabel.Text =
                resource.GetString(name: nameof(SearchLabel));

            ProductNewButton.Text =
                resource.GetString(name: nameof(ProductNewButton));

            ProductEditButton.Text =
                resource.GetString(name: nameof(ProductEditButton));

            ProductStatusButton.Text =
                resource.GetString(name: nameof(ProductStatusButton));

            PrintInventoryReceiptButton.Text =
                resource.GetString(name: nameof(PrintInventoryReceiptButton));

            ProductDataGridView.Columns[0].HeaderText =
                resource.GetString(name: nameof(ProductBuyDate));

            ProductDataGridView.Columns[1].HeaderText =
                resource.GetString(name: nameof(ProductCode));

            ProductDataGridView.Columns[2].HeaderText =
                resource.GetString(name: nameof(ProductName));

            ProductDataGridView.Columns[3].HeaderText =
                resource.GetString(name: nameof(ProductCountry));

            ProductDataGridView.Columns[4].HeaderText =
                resource.GetString(name: nameof(ProductInvoiceNo));

            ProductDataGridView.Columns[5].HeaderText =
                resource.GetString(name: nameof(ProductSuppler));

            ProductDataGridView.Columns[6].HeaderText =
                resource.GetString(name: nameof(ProductStoreroom));

            ProductDataGridView.Columns[7].HeaderText =
                resource.GetString(name: nameof(ProductImage));

            ProductDataGridView.Columns[8].HeaderText =
                resource.GetString(name: nameof(ProductStoreKepper));

            ProductDataGridView.Columns[9].HeaderText =
                resource.GetString(name: nameof(ProductStock));

            ProductDataGridView.Columns[10].HeaderText =
                resource.GetString(name: nameof(ProductUnit));

            ProductDataGridView.Columns[11].HeaderText =
                resource.GetString(name: nameof(ProductUnitSales));

            ProductDataGridView.Columns[12].HeaderText =
                resource.GetString(name: nameof(ProductRegistrar));

            ProductDataGridView.Columns[13].HeaderText =
                resource.GetString(name: nameof(ProductRegisterDate));

            ProductDataGridView.Columns[14].HeaderText =
                resource.GetString(name: nameof(ProductDescription));

            PriceManagmentToolStripMenuItem.Text =
                resource.GetString(name: nameof(PriceManagmentToolStripMenuItem));

            StockManagmentToolStripMenuItem.Text =
               resource.GetString(name: nameof(StockManagmentToolStripMenuItem));

            this.Text =
                resource.GetString(name: nameof(CommoditiesForm));

            #endregion / Language
        }

        // Loaded
        private void ProductsForm_Load(object sender, EventArgs e)
        {
            if (ApplicationSettings.CurrentCulture == ApplicationSettings.Languages.Farsi)
            {
                this.RightToLeft = RightToLeft.Yes;
                this.RightToLeftLayout = true;
            }
        }

        #region  ContextMenu

        // ContextMenu 
        private void ContextMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem? button = sender as ToolStripMenuItem;

            if (button != null)
            {
                switch (button.Name)
                {
                    case "PriceManagmentToolStripMenuItem":
                        {
                            new CommodityPricesForm().ShowDialog();
                            break;
                        }
                    case "StockManagmentToolStripMenuItem":
                        {
                            new CommodityStockForm().ShowDialog();
                            break;
                        }
                }
            }

        }

        #endregion / ContextMenu
    }
}