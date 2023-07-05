namespace MyApplication.Ui
{
    partial class CommodityPricesForm
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
            // CommodityPricesForm
            // 
            Appearance.BackColor = Color.LightGoldenrodYellow;
            Appearance.Options.UseBackColor = true;
            Appearance.Options.UseFont = true;
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 392);
            Margin = new Padding(7, 6, 7, 6);
            Name = "CommodityPricesForm";
            Text = "CommodityPricesForm";
            Load += ProductPriceForm_Load;
            ResumeLayout(false);
        }

        #endregion
    }
}