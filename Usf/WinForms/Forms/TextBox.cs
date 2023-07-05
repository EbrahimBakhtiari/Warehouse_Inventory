using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usf.WinForms.Forms
{
    public class TextBox : System.Windows.Forms.TextBox
    {
        public TextBox() : base()
        {
            this.BackColor = Color.LemonChiffon;
            this.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            this.Name = "TextBox";
            this.Size = new Size(200, 35);
            this.TextAlign = HorizontalAlignment.Center;
        }
    }
}
