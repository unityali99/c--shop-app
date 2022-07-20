
using LoginForm.Properties;

namespace LoginForm
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.BtnLogin = new System.Windows.Forms.Button();
            this.LabelUser = new DevExpress.XtraEditors.LabelControl();
            this.LabelPass = new DevExpress.XtraEditors.LabelControl();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.TxtBoxPass = new CustomControls.NumericTxtBox.NumericTextBox();
            this.TxtBoxUser = new CustomControls.StringTxtBox.StringTextBox();
            this.BtnSignUp = new System.Windows.Forms.Button();
            this.ChkBoxRemember = new System.Windows.Forms.CheckBox();
            this.LabelRemember = new System.Windows.Forms.Label();
            this.LblShowPass = new System.Windows.Forms.Label();
            this.ChkBoxShowPass = new System.Windows.Forms.CheckBox();
            this.linkLabelForgotPass = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(6, 170);
            this.BtnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(275, 36);
            this.BtnLogin.TabIndex = 4;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // LabelUser
            // 
            this.LabelUser.Appearance.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LabelUser.Appearance.Options.UseFont = true;
            this.LabelUser.Location = new System.Drawing.Point(316, 11);
            this.LabelUser.Margin = new System.Windows.Forms.Padding(4);
            this.LabelUser.Name = "LabelUser";
            this.LabelUser.Size = new System.Drawing.Size(67, 28);
            this.LabelUser.TabIndex = 7;
            this.LabelUser.Text = ": نام کاربری";
            // 
            // LabelPass
            // 
            this.LabelPass.Appearance.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LabelPass.Appearance.Options.UseFont = true;
            this.LabelPass.Location = new System.Drawing.Point(317, 61);
            this.LabelPass.Margin = new System.Windows.Forms.Padding(4);
            this.LabelPass.Name = "LabelPass";
            this.LabelPass.Size = new System.Drawing.Size(58, 28);
            this.LabelPass.TabIndex = 6;
            this.LabelPass.Text = ": رمز عبور";
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(289, 170);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(112, 36);
            this.BtnCancel.TabIndex = 6;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // TxtBoxPass
            // 
            this.TxtBoxPass.BackColor = System.Drawing.Color.Yellow;
            this.TxtBoxPass.Font = new System.Drawing.Font("B Nazanin", 14F);
            this.TxtBoxPass.ForeColor = System.Drawing.Color.Black;
            this.TxtBoxPass.Location = new System.Drawing.Point(18, 54);
            this.TxtBoxPass.Name = "TxtBoxPass";
            this.TxtBoxPass.Size = new System.Drawing.Size(273, 35);
            this.TxtBoxPass.TabIndex = 1;
            this.TxtBoxPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtBoxPass.UseSystemPasswordChar = true;
            this.TxtBoxPass.TextChanged += new System.EventHandler(this.FrmLogin_TxtEmptyOrNot);
            // 
            // TxtBoxUser
            // 
            this.TxtBoxUser.BackColor = System.Drawing.Color.Yellow;
            this.TxtBoxUser.Font = new System.Drawing.Font("B Nazanin", 14F);
            this.TxtBoxUser.ForeColor = System.Drawing.Color.Black;
            this.TxtBoxUser.Location = new System.Drawing.Point(18, 9);
            this.TxtBoxUser.Name = "TxtBoxUser";
            this.TxtBoxUser.Size = new System.Drawing.Size(274, 35);
            this.TxtBoxUser.TabIndex = 0;
            this.TxtBoxUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtBoxUser.TextChanged += new System.EventHandler(this.FrmLogin_TxtEmptyOrNot);
            // 
            // BtnSignUp
            // 
            this.BtnSignUp.Location = new System.Drawing.Point(6, 216);
            this.BtnSignUp.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSignUp.Name = "BtnSignUp";
            this.BtnSignUp.Size = new System.Drawing.Size(396, 36);
            this.BtnSignUp.TabIndex = 5;
            this.BtnSignUp.Text = "Create Account";
            this.BtnSignUp.UseVisualStyleBackColor = true;
            this.BtnSignUp.Click += new System.EventHandler(this.BtnSignUp_Click);
            // 
            // ChkBoxRemember
            // 
            this.ChkBoxRemember.Font = new System.Drawing.Font("Cambria Math", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkBoxRemember.Location = new System.Drawing.Point(22, 102);
            this.ChkBoxRemember.Name = "ChkBoxRemember";
            this.ChkBoxRemember.Size = new System.Drawing.Size(15, 22);
            this.ChkBoxRemember.TabIndex = 2;
            this.ChkBoxRemember.Text = "Remember Me";
            this.ChkBoxRemember.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ChkBoxRemember.UseVisualStyleBackColor = true;
            // 
            // LabelRemember
            // 
            this.LabelRemember.AutoSize = true;
            this.LabelRemember.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRemember.Location = new System.Drawing.Point(39, 105);
            this.LabelRemember.Name = "LabelRemember";
            this.LabelRemember.Size = new System.Drawing.Size(97, 17);
            this.LabelRemember.TabIndex = 8;
            this.LabelRemember.Text = "Remember Me";
            // 
            // LblShowPass
            // 
            this.LblShowPass.AutoSize = true;
            this.LblShowPass.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblShowPass.Location = new System.Drawing.Point(39, 142);
            this.LblShowPass.Name = "LblShowPass";
            this.LblShowPass.Size = new System.Drawing.Size(102, 17);
            this.LblShowPass.TabIndex = 26;
            this.LblShowPass.Text = "Show Password";
            // 
            // ChkBoxShowPass
            // 
            this.ChkBoxShowPass.Font = new System.Drawing.Font("Cambria Math", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkBoxShowPass.Location = new System.Drawing.Point(22, 139);
            this.ChkBoxShowPass.Name = "ChkBoxShowPass";
            this.ChkBoxShowPass.Size = new System.Drawing.Size(15, 22);
            this.ChkBoxShowPass.TabIndex = 3;
            this.ChkBoxShowPass.Text = "Show Password";
            this.ChkBoxShowPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ChkBoxShowPass.UseVisualStyleBackColor = true;
            this.ChkBoxShowPass.CheckedChanged += new System.EventHandler(this.ChkBoxShowPass_CheckedChanged);
            // 
            // linkLabelForgotPass
            // 
            this.linkLabelForgotPass.AutoSize = true;
            this.linkLabelForgotPass.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelForgotPass.Location = new System.Drawing.Point(195, 139);
            this.linkLabelForgotPass.Name = "linkLabelForgotPass";
            this.linkLabelForgotPass.Size = new System.Drawing.Size(141, 15);
            this.linkLabelForgotPass.TabIndex = 27;
            this.linkLabelForgotPass.TabStop = true;
            this.linkLabelForgotPass.Text = "I forgot my password";
            this.linkLabelForgotPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelForgotPass_LinkClicked);
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.BtnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(409, 260);
            this.ControlBox = false;
            this.Controls.Add(this.linkLabelForgotPass);
            this.Controls.Add(this.LblShowPass);
            this.Controls.Add(this.ChkBoxShowPass);
            this.Controls.Add(this.LabelRemember);
            this.Controls.Add(this.ChkBoxRemember);
            this.Controls.Add(this.BtnSignUp);
            this.Controls.Add(this.TxtBoxUser);
            this.Controls.Add(this.TxtBoxPass);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.LabelPass);
            this.Controls.Add(this.LabelUser);
            this.Controls.Add(this.BtnLogin);
            this.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLogin;
        private DevExpress.XtraEditors.LabelControl LabelUser;
        private DevExpress.XtraEditors.LabelControl LabelPass;
        private System.Windows.Forms.Button BtnCancel;
        private CustomControls.NumericTxtBox.NumericTextBox TxtBoxPass;
        private CustomControls.StringTxtBox.StringTextBox TxtBoxUser;
        private System.Windows.Forms.Button BtnSignUp;
        private System.Windows.Forms.CheckBox ChkBoxRemember;
        private System.Windows.Forms.Label LabelRemember;
        private System.Windows.Forms.Label LblShowPass;
        private System.Windows.Forms.CheckBox ChkBoxShowPass;
        private System.Windows.Forms.LinkLabel linkLabelForgotPass;
    }
}

