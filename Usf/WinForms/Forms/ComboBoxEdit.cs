using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usf.WinForms.Forms
{
    public class ComboBoxEdit : DevExpress.XtraEditors.ComboBoxEdit
    {
        public ComboBoxEdit() : base()
        {
            this.Location = new Point(71, 173);
            this.Name = "ComboBoxEdit";
            this.Properties.Appearance.BackColor = Color.LemonChiffon;
            this.Properties.Appearance.Font = new Font("IRANYekan Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            this.Properties.Appearance.Options.UseBackColor = true;
            this.Properties.Appearance.Options.UseFont = true;
            this.Properties.Appearance.Options.UseTextOptions = true;
            this.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Properties.AutoHeight = false;
            this.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            this.Size = new Size(150, 32);
            this.TabIndex = 1;
        }
    }
}
