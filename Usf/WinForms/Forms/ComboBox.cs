using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usf.WinForms.Forms
{
    
    public class ComboBox : DevExpress.XtraEditors.ComboBoxEdit
    {
        public ComboBox() : base()
        {
            this.Properties.Appearance.BackColor = Color.LemonChiffon;
            this.Properties.AutoHeight = false;
            this.Properties.Appearance.Font = new Font("B Yekan", 12F, FontStyle.Bold, GraphicsUnit.Point);
            this.Properties.Appearance.Options.UseBackColor = true;
            this.Properties.Appearance.Options.UseFont = true;
        }
    }
}
