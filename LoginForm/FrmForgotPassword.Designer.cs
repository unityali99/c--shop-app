
namespace LoginForm
{
    partial class FrmForgotPassword
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
            this.TxtBoxSSN = new CustomControls.NumericTxtBox.NumericTextBox();
            this.TxtBoxEmail = new System.Windows.Forms.TextBox();
            this.LblSSN = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.BtnNext = new System.Windows.Forms.Button();
            this.BtnReturn = new System.Windows.Forms.Button();
            this.ChkBoxRobot = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // TxtBoxSSN
            // 
            this.TxtBoxSSN.BackColor = System.Drawing.Color.Beige;
            this.TxtBoxSSN.Font = new System.Drawing.Font("B Nazanin", 14F);
            this.TxtBoxSSN.ForeColor = System.Drawing.Color.Black;
            this.TxtBoxSSN.Location = new System.Drawing.Point(153, 9);
            this.TxtBoxSSN.MaxLength = 10;
            this.TxtBoxSSN.Name = "TxtBoxSSN";
            this.TxtBoxSSN.Size = new System.Drawing.Size(264, 35);
            this.TxtBoxSSN.TabIndex = 0;
            this.TxtBoxSSN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtBoxEmail
            // 
            this.TxtBoxEmail.BackColor = System.Drawing.Color.Beige;
            this.TxtBoxEmail.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtBoxEmail.Location = new System.Drawing.Point(173, 61);
            this.TxtBoxEmail.MaxLength = 40;
            this.TxtBoxEmail.Name = "TxtBoxEmail";
            this.TxtBoxEmail.Size = new System.Drawing.Size(244, 36);
            this.TxtBoxEmail.TabIndex = 1;
            this.TxtBoxEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblSSN
            // 
            this.LblSSN.AutoSize = true;
            this.LblSSN.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSSN.Location = new System.Drawing.Point(4, 9);
            this.LblSSN.Name = "LblSSN";
            this.LblSSN.Size = new System.Drawing.Size(143, 36);
            this.LblSSN.TabIndex = 22;
            this.LblSSN.Text = "Enter Your SSN :";
            this.LblSSN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail.Location = new System.Drawing.Point(4, 61);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(163, 36);
            this.LblEmail.TabIndex = 21;
            this.LblEmail.Text = "Enter Your E-Mail :";
            this.LblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnNext
            // 
            this.BtnNext.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnNext.Location = new System.Drawing.Point(10, 138);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(407, 60);
            this.BtnNext.TabIndex = 23;
            this.BtnNext.Text = "Next";
            this.BtnNext.UseVisualStyleBackColor = false;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // BtnReturn
            // 
            this.BtnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnReturn.Location = new System.Drawing.Point(10, 204);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(407, 36);
            this.BtnReturn.TabIndex = 24;
            this.BtnReturn.Text = "Return";
            this.BtnReturn.UseVisualStyleBackColor = false;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // ChkBoxRobot
            // 
            this.ChkBoxRobot.AutoSize = true;
            this.ChkBoxRobot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkBoxRobot.Location = new System.Drawing.Point(34, 109);
            this.ChkBoxRobot.Name = "ChkBoxRobot";
            this.ChkBoxRobot.Size = new System.Drawing.Size(113, 20);
            this.ChkBoxRobot.TabIndex = 25;
            this.ChkBoxRobot.Text = "I\'m not a robot.";
            this.ChkBoxRobot.UseVisualStyleBackColor = true;
            this.ChkBoxRobot.CheckedChanged += new System.EventHandler(this.ChkBoxRobot_CheckedChanged);
            // 
            // FrmForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 248);
            this.Controls.Add(this.ChkBoxRobot);
            this.Controls.Add(this.BtnReturn);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.LblSSN);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.TxtBoxEmail);
            this.Controls.Add(this.TxtBoxSSN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmForgotPassword";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Change Your Password";
            this.Load += new System.EventHandler(this.FrmForgotPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.NumericTxtBox.NumericTextBox TxtBoxSSN;
        private System.Windows.Forms.TextBox TxtBoxEmail;
        private System.Windows.Forms.Label LblSSN;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Button BtnReturn;
        private System.Windows.Forms.CheckBox ChkBoxRobot;
    }
}