
namespace LoginForm
{
    partial class FrmCreateAcc
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
            this.LblFname = new System.Windows.Forms.Label();
            this.LblSSN = new System.Windows.Forms.Label();
            this.LblLname = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.TxtBoxEmail = new System.Windows.Forms.TextBox();
            this.GrpBoxPerson = new System.Windows.Forms.GroupBox();
            this.TxtBoxUser = new CustomControls.StringTxtBox.StringTextBox();
            this.TxtBoxPassRe = new CustomControls.NumericTxtBox.NumericTextBox();
            this.TxtBoxPass = new CustomControls.NumericTxtBox.NumericTextBox();
            this.TxtBoxSSN = new CustomControls.NumericTxtBox.NumericTextBox();
            this.TxtBoxLname = new CustomControls.StringTxtBox.StringTextBox();
            this.TxtBoxFname = new CustomControls.StringTxtBox.StringTextBox();
            this.LblPassRe = new System.Windows.Forms.Label();
            this.LblUser = new System.Windows.Forms.Label();
            this.LblPassword = new System.Windows.Forms.Label();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.LblShowPass = new System.Windows.Forms.Label();
            this.ChkBoxShowPass = new System.Windows.Forms.CheckBox();
            this.GrpBoxPerson.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblFname
            // 
            this.LblFname.AutoSize = true;
            this.LblFname.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFname.Location = new System.Drawing.Point(18, 26);
            this.LblFname.Name = "LblFname";
            this.LblFname.Size = new System.Drawing.Size(108, 36);
            this.LblFname.TabIndex = 0;
            this.LblFname.Text = "First Name :";
            // 
            // LblSSN
            // 
            this.LblSSN.AutoSize = true;
            this.LblSSN.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSSN.Location = new System.Drawing.Point(18, 126);
            this.LblSSN.Name = "LblSSN";
            this.LblSSN.Size = new System.Drawing.Size(56, 36);
            this.LblSSN.TabIndex = 2;
            this.LblSSN.Text = "SSN :";
            // 
            // LblLname
            // 
            this.LblLname.AutoSize = true;
            this.LblLname.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLname.Location = new System.Drawing.Point(18, 77);
            this.LblLname.Name = "LblLname";
            this.LblLname.Size = new System.Drawing.Size(104, 36);
            this.LblLname.TabIndex = 4;
            this.LblLname.Text = "Last Name :";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail.Location = new System.Drawing.Point(18, 176);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(76, 36);
            this.LblEmail.TabIndex = 6;
            this.LblEmail.Text = "E-Mail :";
            // 
            // TxtBoxEmail
            // 
            this.TxtBoxEmail.BackColor = System.Drawing.SystemColors.Info;
            this.TxtBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxEmail.Location = new System.Drawing.Point(97, 177);
            this.TxtBoxEmail.MaxLength = 50;
            this.TxtBoxEmail.Name = "TxtBoxEmail";
            this.TxtBoxEmail.Size = new System.Drawing.Size(349, 29);
            this.TxtBoxEmail.TabIndex = 3;
            this.TxtBoxEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GrpBoxPerson
            // 
            this.GrpBoxPerson.Controls.Add(this.LblShowPass);
            this.GrpBoxPerson.Controls.Add(this.ChkBoxShowPass);
            this.GrpBoxPerson.Controls.Add(this.TxtBoxUser);
            this.GrpBoxPerson.Controls.Add(this.TxtBoxPassRe);
            this.GrpBoxPerson.Controls.Add(this.TxtBoxPass);
            this.GrpBoxPerson.Controls.Add(this.TxtBoxSSN);
            this.GrpBoxPerson.Controls.Add(this.TxtBoxLname);
            this.GrpBoxPerson.Controls.Add(this.TxtBoxFname);
            this.GrpBoxPerson.Controls.Add(this.LblPassRe);
            this.GrpBoxPerson.Controls.Add(this.LblFname);
            this.GrpBoxPerson.Controls.Add(this.TxtBoxEmail);
            this.GrpBoxPerson.Controls.Add(this.LblEmail);
            this.GrpBoxPerson.Controls.Add(this.LblSSN);
            this.GrpBoxPerson.Controls.Add(this.LblUser);
            this.GrpBoxPerson.Controls.Add(this.LblPassword);
            this.GrpBoxPerson.Controls.Add(this.LblLname);
            this.GrpBoxPerson.Location = new System.Drawing.Point(11, 12);
            this.GrpBoxPerson.Name = "GrpBoxPerson";
            this.GrpBoxPerson.Size = new System.Drawing.Size(473, 413);
            this.GrpBoxPerson.TabIndex = 8;
            this.GrpBoxPerson.TabStop = false;
            this.GrpBoxPerson.Text = "Personal Informations";
            // 
            // TxtBoxUser
            // 
            this.TxtBoxUser.BackColor = System.Drawing.Color.PowderBlue;
            this.TxtBoxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtBoxUser.ForeColor = System.Drawing.Color.Black;
            this.TxtBoxUser.Location = new System.Drawing.Point(133, 226);
            this.TxtBoxUser.MaxLength = 35;
            this.TxtBoxUser.Name = "TxtBoxUser";
            this.TxtBoxUser.Size = new System.Drawing.Size(313, 29);
            this.TxtBoxUser.TabIndex = 4;
            this.TxtBoxUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtBoxPassRe
            // 
            this.TxtBoxPassRe.BackColor = System.Drawing.Color.PowderBlue;
            this.TxtBoxPassRe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtBoxPassRe.ForeColor = System.Drawing.Color.Black;
            this.TxtBoxPassRe.Location = new System.Drawing.Point(181, 329);
            this.TxtBoxPassRe.MaxLength = 25;
            this.TxtBoxPassRe.Name = "TxtBoxPassRe";
            this.TxtBoxPassRe.Size = new System.Drawing.Size(265, 29);
            this.TxtBoxPassRe.TabIndex = 6;
            this.TxtBoxPassRe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtBoxPassRe.UseSystemPasswordChar = true;
            // 
            // TxtBoxPass
            // 
            this.TxtBoxPass.BackColor = System.Drawing.Color.PowderBlue;
            this.TxtBoxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtBoxPass.ForeColor = System.Drawing.Color.Black;
            this.TxtBoxPass.Location = new System.Drawing.Point(124, 277);
            this.TxtBoxPass.MaxLength = 25;
            this.TxtBoxPass.Name = "TxtBoxPass";
            this.TxtBoxPass.Size = new System.Drawing.Size(322, 29);
            this.TxtBoxPass.TabIndex = 5;
            this.TxtBoxPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtBoxPass.UseSystemPasswordChar = true;
            // 
            // TxtBoxSSN
            // 
            this.TxtBoxSSN.BackColor = System.Drawing.SystemColors.Info;
            this.TxtBoxSSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtBoxSSN.ForeColor = System.Drawing.Color.Black;
            this.TxtBoxSSN.Location = new System.Drawing.Point(80, 126);
            this.TxtBoxSSN.MaxLength = 10;
            this.TxtBoxSSN.Name = "TxtBoxSSN";
            this.TxtBoxSSN.Size = new System.Drawing.Size(366, 29);
            this.TxtBoxSSN.TabIndex = 2;
            this.TxtBoxSSN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtBoxLname
            // 
            this.TxtBoxLname.BackColor = System.Drawing.SystemColors.Info;
            this.TxtBoxLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtBoxLname.ForeColor = System.Drawing.Color.Black;
            this.TxtBoxLname.Location = new System.Drawing.Point(132, 77);
            this.TxtBoxLname.MaxLength = 35;
            this.TxtBoxLname.Name = "TxtBoxLname";
            this.TxtBoxLname.Size = new System.Drawing.Size(314, 29);
            this.TxtBoxLname.TabIndex = 1;
            this.TxtBoxLname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtBoxFname
            // 
            this.TxtBoxFname.BackColor = System.Drawing.SystemColors.Info;
            this.TxtBoxFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtBoxFname.ForeColor = System.Drawing.Color.Black;
            this.TxtBoxFname.Location = new System.Drawing.Point(132, 27);
            this.TxtBoxFname.MaxLength = 35;
            this.TxtBoxFname.Name = "TxtBoxFname";
            this.TxtBoxFname.Size = new System.Drawing.Size(314, 29);
            this.TxtBoxFname.TabIndex = 0;
            this.TxtBoxFname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblPassRe
            // 
            this.LblPassRe.AutoSize = true;
            this.LblPassRe.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPassRe.Location = new System.Drawing.Point(23, 329);
            this.LblPassRe.Name = "LblPassRe";
            this.LblPassRe.Size = new System.Drawing.Size(152, 36);
            this.LblPassRe.TabIndex = 12;
            this.LblPassRe.Text = "Repeat Password :";
            this.LblPassRe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblUser
            // 
            this.LblUser.AutoSize = true;
            this.LblUser.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUser.Location = new System.Drawing.Point(18, 226);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(109, 36);
            this.LblUser.TabIndex = 8;
            this.LblUser.Text = "User Name :";
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPassword.Location = new System.Drawing.Point(22, 277);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(96, 36);
            this.LblPassword.TabIndex = 10;
            this.LblPassword.Text = "Password :";
            this.LblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnSubmit.Location = new System.Drawing.Point(9, 431);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(475, 49);
            this.BtnSubmit.TabIndex = 0;
            this.BtnSubmit.Text = "Submit";
            this.BtnSubmit.UseVisualStyleBackColor = false;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.Peru;
            this.BtnCancel.Location = new System.Drawing.Point(9, 487);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(475, 44);
            this.BtnCancel.TabIndex = 1;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // LblShowPass
            // 
            this.LblShowPass.AutoSize = true;
            this.LblShowPass.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblShowPass.Location = new System.Drawing.Point(48, 377);
            this.LblShowPass.Name = "LblShowPass";
            this.LblShowPass.Size = new System.Drawing.Size(102, 17);
            this.LblShowPass.TabIndex = 26;
            this.LblShowPass.Text = "Show Password";
            // 
            // ChkBoxShowPass
            // 
            this.ChkBoxShowPass.Font = new System.Drawing.Font("Cambria Math", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkBoxShowPass.Location = new System.Drawing.Point(31, 374);
            this.ChkBoxShowPass.Name = "ChkBoxShowPass";
            this.ChkBoxShowPass.Size = new System.Drawing.Size(15, 22);
            this.ChkBoxShowPass.TabIndex = 25;
            this.ChkBoxShowPass.Text = "Show Password";
            this.ChkBoxShowPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ChkBoxShowPass.UseVisualStyleBackColor = true;
            this.ChkBoxShowPass.CheckedChanged += new System.EventHandler(this.ChkBoxShowPass_CheckedChanged);
            // 
            // FrmCreateAcc
            // 
            this.AcceptButton = this.BtnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 535);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.GrpBoxPerson);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCreateAcc";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create An Account";
            this.GrpBoxPerson.ResumeLayout(false);
            this.GrpBoxPerson.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblFname;
        private System.Windows.Forms.Label LblSSN;
        private System.Windows.Forms.Label LblLname;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.TextBox TxtBoxEmail;
        private System.Windows.Forms.GroupBox GrpBoxPerson;
        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label LblPassRe;
        private System.Windows.Forms.Label LblUser;
        private System.Windows.Forms.Label LblPassword;
        private CustomControls.NumericTxtBox.NumericTextBox TxtBoxSSN;
        private CustomControls.StringTxtBox.StringTextBox TxtBoxLname;
        private CustomControls.StringTxtBox.StringTextBox TxtBoxFname;
        private CustomControls.NumericTxtBox.NumericTextBox TxtBoxPassRe;
        private CustomControls.NumericTxtBox.NumericTextBox TxtBoxPass;
        private CustomControls.StringTxtBox.StringTextBox TxtBoxUser;
        private System.Windows.Forms.Label LblShowPass;
        private System.Windows.Forms.CheckBox ChkBoxShowPass;
    }
}