namespace MyApplication
{
    partial class ConsomersForm
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
            SuspendLayout();
            // 
            // ConsomersForm
            // 
            Appearance.BackColor = Color.LightGoldenrodYellow;
            Appearance.Options.UseBackColor = true;
            Appearance.Options.UseFont = true;
            AutoScaleDimensions = new SizeF(10F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 756);
            Font = new Font("IRANYekan Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(7, 9, 7, 9);
            Name = "ConsomersForm";
            Text = "CustomerForm";
            Load += CustomerForm_Load;
            ResumeLayout(false);
        }

        #endregion
    }
}