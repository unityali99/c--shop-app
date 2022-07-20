
namespace LoginForm
{
    partial class FrmEditInfo
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
            this.GrpBoxPerson = new System.Windows.Forms.GroupBox();
            this.TxtBoxSSN = new CustomControls.NumericTxtBox.NumericTextBox();
            this.TxtBoxLname = new CustomControls.StringTxtBox.StringTextBox();
            this.TxtBoxFname = new CustomControls.StringTxtBox.StringTextBox();
            this.LblFname = new System.Windows.Forms.Label();
            this.TxtBoxEmail = new System.Windows.Forms.TextBox();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblSSN = new System.Windows.Forms.Label();
            this.LblLname = new System.Windows.Forms.Label();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.GrpBoxPerson.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpBoxPerson
            // 
            this.GrpBoxPerson.Controls.Add(this.TxtBoxSSN);
            this.GrpBoxPerson.Controls.Add(this.TxtBoxLname);
            this.GrpBoxPerson.Controls.Add(this.TxtBoxFname);
            this.GrpBoxPerson.Controls.Add(this.LblFname);
            this.GrpBoxPerson.Controls.Add(this.TxtBoxEmail);
            this.GrpBoxPerson.Controls.Add(this.LblEmail);
            this.GrpBoxPerson.Controls.Add(this.LblSSN);
            this.GrpBoxPerson.Controls.Add(this.LblLname);
            this.GrpBoxPerson.Location = new System.Drawing.Point(9, 9);
            this.GrpBoxPerson.Name = "GrpBoxPerson";
            this.GrpBoxPerson.Size = new System.Drawing.Size(466, 225);
            this.GrpBoxPerson.TabIndex = 0;
            this.GrpBoxPerson.TabStop = false;
            this.GrpBoxPerson.Text = "Personal Informations";
            // 
            // TxtBoxSSN
            // 
            this.TxtBoxSSN.BackColor = System.Drawing.SystemColors.Info;
            this.TxtBoxSSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtBoxSSN.ForeColor = System.Drawing.Color.Black;
            this.TxtBoxSSN.Location = new System.Drawing.Point(82, 129);
            this.TxtBoxSSN.MaxLength = 10;
            this.TxtBoxSSN.Name = "TxtBoxSSN";
            this.TxtBoxSSN.Size = new System.Drawing.Size(366, 29);
            this.TxtBoxSSN.TabIndex = 10;
            this.TxtBoxSSN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtBoxLname
            // 
            this.TxtBoxLname.BackColor = System.Drawing.SystemColors.Info;
            this.TxtBoxLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtBoxLname.ForeColor = System.Drawing.Color.Black;
            this.TxtBoxLname.Location = new System.Drawing.Point(134, 80);
            this.TxtBoxLname.MaxLength = 35;
            this.TxtBoxLname.Name = "TxtBoxLname";
            this.TxtBoxLname.Size = new System.Drawing.Size(314, 29);
            this.TxtBoxLname.TabIndex = 9;
            this.TxtBoxLname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtBoxFname
            // 
            this.TxtBoxFname.BackColor = System.Drawing.SystemColors.Info;
            this.TxtBoxFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtBoxFname.ForeColor = System.Drawing.Color.Black;
            this.TxtBoxFname.Location = new System.Drawing.Point(134, 30);
            this.TxtBoxFname.MaxLength = 35;
            this.TxtBoxFname.Name = "TxtBoxFname";
            this.TxtBoxFname.Size = new System.Drawing.Size(314, 29);
            this.TxtBoxFname.TabIndex = 7;
            this.TxtBoxFname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblFname
            // 
            this.LblFname.AutoSize = true;
            this.LblFname.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFname.Location = new System.Drawing.Point(20, 29);
            this.LblFname.Name = "LblFname";
            this.LblFname.Size = new System.Drawing.Size(108, 36);
            this.LblFname.TabIndex = 8;
            this.LblFname.Text = "First Name :";
            // 
            // TxtBoxEmail
            // 
            this.TxtBoxEmail.BackColor = System.Drawing.SystemColors.Info;
            this.TxtBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxEmail.Location = new System.Drawing.Point(99, 180);
            this.TxtBoxEmail.MaxLength = 50;
            this.TxtBoxEmail.Name = "TxtBoxEmail";
            this.TxtBoxEmail.Size = new System.Drawing.Size(349, 29);
            this.TxtBoxEmail.TabIndex = 12;
            this.TxtBoxEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail.Location = new System.Drawing.Point(20, 179);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(76, 36);
            this.LblEmail.TabIndex = 14;
            this.LblEmail.Text = "E-Mail :";
            // 
            // LblSSN
            // 
            this.LblSSN.AutoSize = true;
            this.LblSSN.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSSN.Location = new System.Drawing.Point(20, 129);
            this.LblSSN.Name = "LblSSN";
            this.LblSSN.Size = new System.Drawing.Size(56, 36);
            this.LblSSN.TabIndex = 11;
            this.LblSSN.Text = "SSN :";
            // 
            // LblLname
            // 
            this.LblLname.AutoSize = true;
            this.LblLname.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLname.Location = new System.Drawing.Point(20, 80);
            this.LblLname.Name = "LblLname";
            this.LblLname.Size = new System.Drawing.Size(104, 36);
            this.LblLname.TabIndex = 13;
            this.LblLname.Text = "Last Name :";
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnEdit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEdit.Location = new System.Drawing.Point(10, 240);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(465, 44);
            this.BtnEdit.TabIndex = 1;
            this.BtnEdit.Text = "Edit Inforamtions";
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.Crimson;
            this.BtnClose.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.Location = new System.Drawing.Point(10, 290);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(465, 44);
            this.BtnClose.TabIndex = 2;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // FrmEditInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 345);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.GrpBoxPerson);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FrmEditInfo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Personal Inforamtions";
            this.Load += new System.EventHandler(this.FrmEditInfo_Load);
            this.GrpBoxPerson.ResumeLayout(false);
            this.GrpBoxPerson.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpBoxPerson;
        private CustomControls.NumericTxtBox.NumericTextBox TxtBoxSSN;
        private CustomControls.StringTxtBox.StringTextBox TxtBoxLname;
        private CustomControls.StringTxtBox.StringTextBox TxtBoxFname;
        private System.Windows.Forms.Label LblFname;
        private System.Windows.Forms.TextBox TxtBoxEmail;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblSSN;
        private System.Windows.Forms.Label LblLname;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnClose;
    }
}