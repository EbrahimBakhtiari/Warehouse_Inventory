using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Usf.WinForms.Forms
{
    public class DataGridView : System.Windows.Forms.DataGridView
    {
        public DataGridView() : base()
        {
            this.Font = new Font("B Yekan", 12F, FontStyle.Bold, GraphicsUnit.Point);
            this.AllowUserToAddRows = false;
            this.AllowUserToDeleteRows = false;
            this.BackgroundColor = Color.MistyRose;
            this.ReadOnly = true;
        }
    }
}
