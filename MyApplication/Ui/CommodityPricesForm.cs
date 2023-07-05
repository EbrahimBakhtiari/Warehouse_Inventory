using DevExpress.XtraEditors;
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
    public partial class CommodityPricesForm : Usf.WinForms.Forms.Form
    {
        public CommodityPricesForm()
        {
            InitializeComponent();

            #region Language

            ResourceManager resource = new ResourceManager
                ("Resources.DataDictionary", typeof(Resources.DataDictionary).Assembly);

            this.Text =
                resource.GetString(name: nameof(CommodityPricesForm));

            #endregion
        }

        // Loaded
        private void ProductPriceForm_Load(object sender, EventArgs e)
        {
            if (ApplicationSettings.CurrentCulture == ApplicationSettings.Languages.Farsi)
            {
                this.RightToLeft = RightToLeft.Yes;
                this.RightToLeftLayout = true;
            }
        }
    }
}