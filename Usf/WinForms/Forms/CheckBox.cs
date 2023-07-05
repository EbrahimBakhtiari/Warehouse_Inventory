using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usf.WinForms.Forms
{
    public class CheckBox : System.Windows.Forms.CheckBox
    {
        public CheckBox() : base()
        {
            this.AutoSize = true;
            this.ForeColor = Color.Teal;
            this.Name = "CheckBox";
            this.Size = new Size(115, 23);
            this.UseVisualStyleBackColor = true;
        }
    }
}
