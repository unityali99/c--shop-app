
namespace LoginForm
{
    partial class FrmEditSec
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
            this.TxtBoxPassRe = new CustomControls.NumericTxtBox.NumericTextBox();
            this.TxtBoxPass = new CustomControls.NumericTxtBox.NumericTextBox();
            this.LblPassRe = new System.Windows.Forms.Label();
            this.LblPassword = new System.Windows.Forms.Label();
            this.GrpBoxSec = new System.Windows.Forms.GroupBox();
            this.LblShowPass = new System.Windows.Forms.Label();
            this.ChkBoxShowPass = new System.Windows.Forms.CheckBox();
            this.LblCurrentPass = new System.Windows.Forms.Label();
            this.TxtBoxCurrentPass = new CustomControls.NumericTxtBox.NumericTextBox();
            this.BtnChangePass = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.GrpBoxSec.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtBoxPassRe
            // 
            this.TxtBoxPassRe.BackColor = System.Drawing.Color.PowderBlue;
            this.TxtBoxPassRe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtBoxPassRe.ForeColor = System.Drawing.Color.Black;
            this.TxtBoxPassRe.Location = new System.Drawing.Point(162, 124);
            this.TxtBoxPassRe.MaxLength = 25;
            this.TxtBoxPassRe.Name = "TxtBoxPassRe";
            this.TxtBoxPassRe.Size = new System.Drawing.Size(265, 29);
            this.TxtBoxPassRe.TabIndex = 2;
            this.TxtBoxPassRe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtBoxPassRe.UseSystemPasswordChar = true;
            // 
            // TxtBoxPass
            // 
            this.TxtBoxPass.BackColor = System.Drawing.Color.PowderBlue;
            this.TxtBoxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtBoxPass.ForeColor = System.Drawing.Color.Black;
            this.TxtBoxPass.Location = new System.Drawing.Point(144, 77);
            this.TxtBoxPass.MaxLength = 25;
            this.TxtBoxPass.Name = "TxtBoxPass";
            this.TxtBoxPass.Size = new System.Drawing.Size(283, 29);
            this.TxtBoxPass.TabIndex = 1;
            this.TxtBoxPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtBoxPass.UseSystemPasswordChar = true;
            // 
            // LblPassRe
            // 
            this.LblPassRe.AutoSize = true;
            this.LblPassRe.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPassRe.Location = new System.Drawing.Point(4, 122);
            this.LblPassRe.Name = "LblPassRe";
            this.LblPassRe.Size = new System.Drawing.Size(152, 36);
            this.LblPassRe.TabIndex = 18;
            this.LblPassRe.Text = "Repeat Password :";
            this.LblPassRe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPassword.Location = new System.Drawing.Point(3, 75);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(135, 36);
            this.LblPassword.TabIndex = 17;
            this.LblPassword.Text = "New Password :";
            this.LblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GrpBoxSec
            // 
            this.GrpBoxSec.Controls.Add(this.LblShowPass);
            this.GrpBoxSec.Controls.Add(this.ChkBoxShowPass);
            this.GrpBoxSec.Controls.Add(this.LblCurrentPass);
            this.GrpBoxSec.Controls.Add(this.TxtBoxCurrentPass);
            this.GrpBoxSec.Controls.Add(this.LblPassword);
            this.GrpBoxSec.Controls.Add(this.TxtBoxPassRe);
            this.GrpBoxSec.Controls.Add(this.TxtBoxPass);
            this.GrpBoxSec.Controls.Add(this.LblPassRe);
            this.GrpBoxSec.Location = new System.Drawing.Point(12, 10);
            this.GrpBoxSec.Name = "GrpBoxSec";
            this.GrpBoxSec.Size = new System.Drawing.Size(465, 213);
            this.GrpBoxSec.TabIndex = 19;
            this.GrpBoxSec.TabStop = false;
            this.GrpBoxSec.Text = "Security Informations";
            // 
            // LblShowPass
            // 
            this.LblShowPass.AutoSize = true;
            this.LblShowPass.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblShowPass.Location = new System.Drawing.Point(35, 178);
            this.LblShowPass.Name = "LblShowPass";
            this.LblShowPass.Size = new System.Drawing.Size(102, 17);
            this.LblShowPass.TabIndex = 2;
            this.LblShowPass.Text = "Show Password";
            // 
            // ChkBoxShowPass
            // 
            this.ChkBoxShowPass.Font = new System.Drawing.Font("Cambria Math", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkBoxShowPass.Location = new System.Drawing.Point(18, 175);
            this.ChkBoxShowPass.Name = "ChkBoxShowPass";
            this.ChkBoxShowPass.Size = new System.Drawing.Size(15, 22);
            this.ChkBoxShowPass.TabIndex = 7;
            this.ChkBoxShowPass.Text = "Show Password";
            this.ChkBoxShowPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ChkBoxShowPass.UseVisualStyleBackColor = true;
            this.ChkBoxShowPass.CheckedChanged += new System.EventHandler(this.ChkBoxShowPass_CheckedChanged);
            // 
            // LblCurrentPass
            // 
            this.LblCurrentPass.AutoSize = true;
            this.LblCurrentPass.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCurrentPass.Location = new System.Drawing.Point(3, 28);
            this.LblCurrentPass.Name = "LblCurrentPass";
            this.LblCurrentPass.Size = new System.Drawing.Size(161, 36);
            this.LblCurrentPass.TabIndex = 20;
            this.LblCurrentPass.Text = "Current Password :";
            this.LblCurrentPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtBoxCurrentPass
            // 
            this.TxtBoxCurrentPass.BackColor = System.Drawing.Color.PowderBlue;
            this.TxtBoxCurrentPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtBoxCurrentPass.ForeColor = System.Drawing.Color.Black;
            this.TxtBoxCurrentPass.Location = new System.Drawing.Point(170, 30);
            this.TxtBoxCurrentPass.MaxLength = 25;
            this.TxtBoxCurrentPass.Name = "TxtBoxCurrentPass";
            this.TxtBoxCurrentPass.Size = new System.Drawing.Size(257, 29);
            this.TxtBoxCurrentPass.TabIndex = 0;
            this.TxtBoxCurrentPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtBoxCurrentPass.UseSystemPasswordChar = true;
            // 
            // BtnChangePass
            // 
            this.BtnChangePass.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnChangePass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnChangePass.Location = new System.Drawing.Point(12, 234);
            this.BtnChangePass.Name = "BtnChangePass";
            this.BtnChangePass.Size = new System.Drawing.Size(466, 44);
            this.BtnChangePass.TabIndex = 0;
            this.BtnChangePass.Text = "Change Password";
            this.BtnChangePass.UseVisualStyleBackColor = false;
            this.BtnChangePass.Click += new System.EventHandler(this.BtnChangePass_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnClose.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.Location = new System.Drawing.Point(10, 285);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(468, 44);
            this.BtnClose.TabIndex = 2;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // FrmEditSec
            // 
            this.AcceptButton = this.BtnChangePass;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 341);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnChangePass);
            this.Controls.Add(this.GrpBoxSec);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FrmEditSec";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.FrmEditSec_Load);
            this.GrpBoxSec.ResumeLayout(false);
            this.GrpBoxSec.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private CustomControls.NumericTxtBox.NumericTextBox TxtBoxPassRe;
        private CustomControls.NumericTxtBox.NumericTextBox TxtBoxPass;
        private System.Windows.Forms.Label LblPassRe;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.GroupBox GrpBoxSec;
        private System.Windows.Forms.Label LblCurrentPass;
        private CustomControls.NumericTxtBox.NumericTextBox TxtBoxCurrentPass;
        private System.Windows.Forms.Button BtnChangePass;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label LblShowPass;
        private System.Windows.Forms.CheckBox ChkBoxShowPass;
    }
}