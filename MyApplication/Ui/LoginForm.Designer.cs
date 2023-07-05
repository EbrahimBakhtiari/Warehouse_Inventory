namespace MyApplication
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            LanguageLabel = new Usf.WinForms.Forms.Label();
            panel1 = new Panel();
            SystemNameLabel = new Usf.WinForms.Forms.LabelControl();
            panel2 = new Panel();
            formAssistant1 = new DevExpress.XtraBars.FormAssistant();
            UsernameLabelControl = new Usf.WinForms.Forms.LabelControl();
            UsernameTextBox = new Usf.WinForms.Forms.TextEdit();
            PasswordTextBox = new Usf.WinForms.Forms.TextEdit();
            EnterButton = new Usf.WinForms.Forms.ButtonSimlpe();
            ExitButton = new Usf.WinForms.Forms.ButtonSimlpe();
            PasswordLabelControl = new Usf.WinForms.Forms.LabelControl();
            label1 = new Usf.WinForms.Forms.Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UsernameTextBox.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PasswordTextBox.Properties).BeginInit();
            SuspendLayout();
            // 
            // LanguageLabel
            // 
            LanguageLabel.Appearance.Font = (Font)resources.GetObject("LanguageLabel.Appearance.Font");
            LanguageLabel.Appearance.ForeColor = (Color)resources.GetObject("LanguageLabel.Appearance.ForeColor");
            LanguageLabel.Appearance.Options.UseFont = true;
            LanguageLabel.Appearance.Options.UseForeColor = true;
            resources.ApplyResources(LanguageLabel, "LanguageLabel");
            LanguageLabel.Cursor = Cursors.Hand;
            LanguageLabel.Name = "LanguageLabel";
            LanguageLabel.Click += LanguageLabel_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Orange;
            panel1.Controls.Add(SystemNameLabel);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // SystemNameLabel
            // 
            SystemNameLabel.Appearance.Font = (Font)resources.GetObject("SystemNameLabel.Appearance.Font");
            SystemNameLabel.Appearance.ForeColor = (Color)resources.GetObject("SystemNameLabel.Appearance.ForeColor");
            SystemNameLabel.Appearance.Options.UseFont = true;
            SystemNameLabel.Appearance.Options.UseForeColor = true;
            SystemNameLabel.Appearance.Options.UseTextOptions = true;
            SystemNameLabel.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            SystemNameLabel.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            resources.ApplyResources(SystemNameLabel, "SystemNameLabel");
            SystemNameLabel.Name = "SystemNameLabel";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Orange;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(LanguageLabel);
            resources.ApplyResources(panel2, "panel2");
            panel2.Name = "panel2";
            // 
            // UsernameLabelControl
            // 
            UsernameLabelControl.Appearance.Font = (Font)resources.GetObject("UsernameLabelControl.Appearance.Font");
            UsernameLabelControl.Appearance.ForeColor = (Color)resources.GetObject("UsernameLabelControl.Appearance.ForeColor");
            UsernameLabelControl.Appearance.Options.UseFont = true;
            UsernameLabelControl.Appearance.Options.UseForeColor = true;
            resources.ApplyResources(UsernameLabelControl, "UsernameLabelControl");
            UsernameLabelControl.Name = "UsernameLabelControl";
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.IsActiveVHText = true;
            resources.ApplyResources(UsernameTextBox, "UsernameTextBox");
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Properties.Appearance.BackColor = (Color)resources.GetObject("UsernameTextBox.Properties.Appearance.BackColor");
            UsernameTextBox.Properties.Appearance.Font = (Font)resources.GetObject("UsernameTextBox.Properties.Appearance.Font");
            UsernameTextBox.Properties.Appearance.Options.UseBackColor = true;
            UsernameTextBox.Properties.Appearance.Options.UseFont = true;
            UsernameTextBox.Properties.Appearance.Options.UseTextOptions = true;
            UsernameTextBox.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            UsernameTextBox.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            UsernameTextBox.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            UsernameTextBox.Properties.AutoHeight = (bool)resources.GetObject("UsernameTextBox.Properties.AutoHeight");
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.IsActiveVHText = true;
            resources.ApplyResources(PasswordTextBox, "PasswordTextBox");
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Properties.Appearance.BackColor = (Color)resources.GetObject("PasswordTextBox.Properties.Appearance.BackColor");
            PasswordTextBox.Properties.Appearance.Font = (Font)resources.GetObject("PasswordTextBox.Properties.Appearance.Font");
            PasswordTextBox.Properties.Appearance.Options.UseBackColor = true;
            PasswordTextBox.Properties.Appearance.Options.UseFont = true;
            PasswordTextBox.Properties.Appearance.Options.UseTextOptions = true;
            PasswordTextBox.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            PasswordTextBox.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            PasswordTextBox.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            PasswordTextBox.Properties.AutoHeight = (bool)resources.GetObject("PasswordTextBox.Properties.AutoHeight");
            // 
            // EnterButton
            // 
            EnterButton.Appearance.BackColor = (Color)resources.GetObject("EnterButton.Appearance.BackColor");
            EnterButton.Appearance.BorderColor = (Color)resources.GetObject("EnterButton.Appearance.BorderColor");
            EnterButton.Appearance.Font = (Font)resources.GetObject("EnterButton.Appearance.Font");
            EnterButton.Appearance.ForeColor = (Color)resources.GetObject("EnterButton.Appearance.ForeColor");
            EnterButton.Appearance.Options.UseBackColor = true;
            EnterButton.Appearance.Options.UseBorderColor = true;
            EnterButton.Appearance.Options.UseFont = true;
            EnterButton.Appearance.Options.UseForeColor = true;
            resources.ApplyResources(EnterButton, "EnterButton");
            EnterButton.Name = "EnterButton";
            EnterButton.Click += EnterButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Appearance.BackColor = (Color)resources.GetObject("ExitButton.Appearance.BackColor");
            ExitButton.Appearance.BorderColor = (Color)resources.GetObject("ExitButton.Appearance.BorderColor");
            ExitButton.Appearance.Font = (Font)resources.GetObject("ExitButton.Appearance.Font");
            ExitButton.Appearance.ForeColor = (Color)resources.GetObject("ExitButton.Appearance.ForeColor");
            ExitButton.Appearance.Options.UseBackColor = true;
            ExitButton.Appearance.Options.UseBorderColor = true;
            ExitButton.Appearance.Options.UseFont = true;
            ExitButton.Appearance.Options.UseForeColor = true;
            resources.ApplyResources(ExitButton, "ExitButton");
            ExitButton.Name = "ExitButton";
            ExitButton.Click += ExitButton_Click;
            // 
            // PasswordLabelControl
            // 
            PasswordLabelControl.Appearance.Font = (Font)resources.GetObject("PasswordLabelControl.Appearance.Font");
            PasswordLabelControl.Appearance.ForeColor = (Color)resources.GetObject("PasswordLabelControl.Appearance.ForeColor");
            PasswordLabelControl.Appearance.Options.UseFont = true;
            PasswordLabelControl.Appearance.Options.UseForeColor = true;
            resources.ApplyResources(PasswordLabelControl, "PasswordLabelControl");
            PasswordLabelControl.Name = "PasswordLabelControl";
            // 
            // label1
            // 
            label1.Appearance.Font = (Font)resources.GetObject("label1.Appearance.Font");
            label1.Appearance.ForeColor = (Color)resources.GetObject("label1.Appearance.ForeColor");
            label1.Appearance.Options.UseFont = true;
            label1.Appearance.Options.UseForeColor = true;
            resources.ApplyResources(label1, "label1");
            label1.Cursor = Cursors.Hand;
            label1.Name = "label1";
            // 
            // LoginForm
            // 
            AcceptButton = EnterButton;
            Appearance.BackColor = (Color)resources.GetObject("LoginForm.Appearance.BackColor");
            Appearance.Options.UseBackColor = true;
            Appearance.Options.UseFont = true;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = ExitButton;
            ControlBox = false;
            Controls.Add(ExitButton);
            Controls.Add(EnterButton);
            Controls.Add(PasswordTextBox);
            Controls.Add(UsernameTextBox);
            Controls.Add(PasswordLabelControl);
            Controls.Add(UsernameLabelControl);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            IsActiveSlowlyFade = true;
            Name = "LoginForm";
            Load += LoginForm_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)UsernameTextBox.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)PasswordTextBox.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Usf.WinForms.Forms.Label LanguageLabel;
        private Panel panel1;
        private Panel panel2;
        private DevExpress.XtraBars.FormAssistant formAssistant1;
        private Usf.WinForms.Forms.LabelControl SystemNameLabel;
        private Usf.WinForms.Forms.LabelControl UsernameLabelControl;
        private Usf.WinForms.Forms.TextEdit UsernameTextBox;
        private Usf.WinForms.Forms.TextEdit PasswordTextBox;
        private Usf.WinForms.Forms.ButtonSimlpe EnterButton;
        private Usf.WinForms.Forms.ButtonSimlpe ExitButton;
        private Usf.WinForms.Forms.LabelControl PasswordLabelControl;
        private Usf.WinForms.Forms.Label label1;
    }
}