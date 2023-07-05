using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Usf.WinForms.Forms
{
    public partial class Form : DevExpress.XtraEditors.XtraForm
    {
        public Form()
        {
            InitializeComponent();

            Appearance.BackColor = Color.LightGoldenrodYellow;
            Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            StartPosition = FormStartPosition.CenterScreen;
            Name = "Form";
        }

        public bool IsActiveSlowlyFade { get; set; } = false;

        // Loaded
        private void Form_Load(object sender, EventArgs e)
        {
            if (IsActiveSlowlyFade == true)
            {
                this.Opacity = 0;

                timer1.Start();
            }
        }

        // Timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 100)
            {
                this.Opacity += 0.01;
            }
            else
            {
                timer1.Stop();
            }
        }

        // Form Closing
        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsActiveSlowlyFade == true)
            {
                while (this.Opacity != 0)
                {
                    System.Threading.Thread.Sleep(10);

                    this.Opacity -= 0.01;
                }
            }
        }
    }
}