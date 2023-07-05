using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usf.WinForms.Forms
{
    public class TextEdit : DevExpress.XtraEditors.TextEdit
    {
        public bool IsActiveVHText { get; set; } = true;

        public TextEdit() : base()
        {
            this.Location = new Point(71, 48);
            this.Name = "TextEdit";
            this.Properties.Appearance.BackColor = Color.LemonChiffon;
            this.Properties.Appearance.Font = new Font("B Yekan", 12F, FontStyle.Bold, GraphicsUnit.Point);
            this.Properties.Appearance.Options.UseBackColor = true;
            this.Properties.Appearance.Options.UseFont = true;
            this.Properties.Appearance.Options.UseTextOptions = true;
            this.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.Properties.AutoHeight = false;
            this.Size = new Size(150, 32);
            this.TabIndex = 1;
            if (IsActiveVHText)
            {
                this.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                this.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            }
        }
    }
}
