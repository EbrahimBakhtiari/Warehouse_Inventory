using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usf.WinForms.Forms
{
    public class ButtonSimlpe : DevExpress.XtraEditors.SimpleButton
    {
        public ButtonSimlpe() : base()
        {
            this.Appearance.BackColor = Color.PowderBlue;
            this.Appearance.BorderColor = Color.PaleGreen;
            this.Appearance.Font = new Font("IRANYekan Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            this.Appearance.ForeColor = Color.Maroon;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseBorderColor = true;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.Cursor = Cursors.Hand;
            this.Location = new Point(54, 92);
            this.Name = "SimpleButton";
            this.Size = new Size(180, 50);
            this.TabIndex = 1;
            this.Text = "SimpleButton";
        }
    }
}
