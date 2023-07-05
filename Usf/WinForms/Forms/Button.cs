using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usf.WinForms.Forms
{
    public class Button : DevExpress.XtraEditors.SimpleButton
    {
        public Button() : base()
        {
            this.Font = new Font("IRANYekan Medium", 16F, FontStyle.Bold, GraphicsUnit.Point);
            this.Cursor = Cursors.Hand;
            this.Name = "Button";
            this.Size = new Size(120, 40);
            this.BackColor = Color.Aquamarine;
            this.Appearance.ForeColor = Color.Maroon;
        }
    }
}
