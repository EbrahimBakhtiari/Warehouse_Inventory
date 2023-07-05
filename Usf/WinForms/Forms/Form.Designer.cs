namespace Usf.WinForms.Forms
{
    partial class Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            // 
            // Form
            // 
            Appearance.BackColor = Color.LightGoldenrodYellow;
            Appearance.Options.UseBackColor = true;
            Appearance.Options.UseFont = true;
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 268);
            Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form";
            FormClosing += Form_FormClosing;
            Load += Form_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
    }
}