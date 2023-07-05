using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usf.WinForms.Forms
{
    public class LabelControl : DevExpress.XtraEditors.LabelControl
    {
        public LabelControl() : base()
        {
            this.Appearance.Font = new Font("IRANYekan Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            this.Appearance.ForeColor = Color.Maroon;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.Location = new Point(90, 12);
            this.Name = "LabelControl";
            this.Size = new Size(120, 30);
            this.TabIndex = 0;
            this.Text = "LabelControl";
        }
    }
}
