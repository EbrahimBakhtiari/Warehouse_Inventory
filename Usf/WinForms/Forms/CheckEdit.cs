using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usf.WinForms.Forms
{
    public class CheckEdit : DevExpress.XtraEditors.CheckEdit
    {
        public CheckEdit() :base()
        {
            this.Cursor = Cursors.Hand;
            this.EditValue = true;
            this.Location = new Point(90, 224);
            this.Name = "CheckEdit";
            this.Properties.Appearance.Font = new Font("IRANYekan Medium", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            this.Properties.Appearance.ForeColor = Color.Maroon;
            this.Properties.Appearance.Options.UseFont = true;
            this.Properties.Appearance.Options.UseForeColor = true;
            this.Size = new Size(110, 32);
            this.TabIndex = 1;
        }
    }
}
