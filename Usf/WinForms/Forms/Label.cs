using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usf.WinForms.Forms
{
    public class Label : DevExpress.XtraEditors.LabelControl
    {
        public Label() : base()
        {
            this.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            this.ForeColor = Color.Teal;
            this.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.Name = "Label";
            this.Size = new Size(120, 30);
        }
    }
}
