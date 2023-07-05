using DevExpress.XtraEditors;
using DevExpress.XtraPivotGrid;
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

namespace MyApplication.Ui
{
    public partial class RequestForm : Usf.WinForms.Forms.Form
    {
        public RequestForm()
        {
            InitializeComponent();

            #region Language

            ResourceManager resource = new ResourceManager
               ("Resources.DataDictionary", typeof(Resources.DataDictionary).Assembly);

            SearchCustomerLabel.Text =
                resource.GetString(name: nameof(SearchCustomerLabel));

            SearchProductLabel.Text =
                resource.GetString(name: nameof(SearchProductLabel));

            CustomerInRequestFormDataGridView.Columns[0].HeaderText =
                resource.GetString(name: nameof(CustomerCode));

            CustomerInRequestFormDataGridView.Columns[1].HeaderText =
                resource.GetString(name: nameof(FirstName));

            CustomerInRequestFormDataGridView.Columns[2].HeaderText =
                resource.GetString(name: nameof(LastName));

            CustomerInRequestFormDataGridView.Columns[3].HeaderText =
                resource.GetString(name: nameof(Tel));

            CustomerInRequestFormDataGridView.Columns[4].HeaderText =
                resource.GetString(name: nameof(CustomerType));

            ProductInRequestFormDataGridView.Columns[0].HeaderText =
                resource.GetString(name: nameof(ProductCode));

            ProductInRequestFormDataGridView.Columns[1].HeaderText =
                resource.GetString(name: nameof(ProductName));

            ProductInRequestFormDataGridView.Columns[2].HeaderText =
                resource.GetString(name: nameof(ProductLastPrice));

            ProductInRequestFormDataGridView.Columns[3].HeaderText =
                resource.GetString(name: nameof(ProductLastStock));

            ProductInRequestFormDataGridView.Columns[4].HeaderText =
                resource.GetString(name: nameof(ProductUnit));

            InventoryTransferButton.Text =
                resource.GetString(name: nameof(InventoryTransferButton));

            InvoiceButton.Text =
                resource.GetString(name: nameof(InvoiceButton));

            CountLabel.Text =
                resource.GetString(name: nameof(CountLabel));

            AddToRequestButton.Text =
                resource.GetString(name: nameof(AddToRequestButton));

            AddToShopingButton.Text =
                resource.GetString(name: nameof(AddToShopingButton));

            RequestFormDataGridView.Columns[0].HeaderText =
                resource.GetString(name: nameof(RequestRow));

            RequestFormDataGridView.Columns[1].HeaderText =
                resource.GetString(name: nameof(RequestProductName));

            RequestFormDataGridView.Columns[2].HeaderText =
                resource.GetString(name: nameof(RequestProductCount));

            RequestFormDataGridView.Columns[3].HeaderText =
                resource.GetString(name: nameof(RequestProductUnit));

            RequestFormDataGridView.Columns[4].HeaderText =
                resource.GetString(name: nameof(RequestProductPrice));

            PrintInventoryTransferButton.Text =
                resource.GetString(name: nameof(PrintInventoryTransferButton));

            PrintInvoiceButton.Text =
                resource.GetString(name: nameof(PrintInvoiceButton));

            DeleteButton.Text =
                resource.GetString(name: nameof(DeleteButton));

            NumberLabel.Text =
                resource.GetString(name: nameof(NumberLabel));

            DateLabel.Text =
                resource.GetString(name: nameof(DateLabel));

            RegistrarLabel.Text =
                resource.GetString(name: nameof(RegistrarLabel));

            CustomerLabel.Text =
                resource.GetString(name: nameof(CustomerLabel));

            TotalAmountLabel.Text =
                resource.GetString(name: nameof(TotalAmountLabel));

            RialsLabel.Text =
                resource.GetString(name: nameof(RialsLabel));

            this.Text =
                resource.GetString(name: nameof(RequestForm));

            #endregion /Language

        }

        // Loaded
        private void InventoryTransferForm_Load(object sender, EventArgs e)
        {
            if (ApplicationSettings.CurrentCulture == ApplicationSettings.Languages.Farsi)
            {
                SearchCustomerTextBox.Focus();
                this.RightToLeft = RightToLeft.Yes;
                this.RightToLeftLayout = true;
            }
        }
    }
}