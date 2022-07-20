
namespace LoginForm
{
    partial class FrmCart
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
            this.LabelWarning = new System.Windows.Forms.Label();
            this.TextBoxOrderID = new System.Windows.Forms.TextBox();
            this.BtnClose = new CustomControls.Buttons.BtnLabelClose();
            this.TextBoxTotalPrice = new System.Windows.Forms.TextBox();
            this.BtnPay = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelWarning
            // 
            this.LabelWarning.AutoSize = true;
            this.LabelWarning.BackColor = System.Drawing.Color.Orange;
            this.LabelWarning.Font = new System.Drawing.Font("Footlight MT Light", 12.25F);
            this.LabelWarning.Location = new System.Drawing.Point(14, 11);
            this.LabelWarning.Name = "LabelWarning";
            this.LabelWarning.Size = new System.Drawing.Size(635, 19);
            this.LabelWarning.TabIndex = 3;
            this.LabelWarning.Text = "Please be aware that your username and password Order ID is essential to track yo" +
    "ur order\r\n";
            // 
            // TextBoxOrderID
            // 
            this.TextBoxOrderID.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TextBoxOrderID.Enabled = false;
            this.TextBoxOrderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxOrderID.Location = new System.Drawing.Point(458, 231);
            this.TextBoxOrderID.Name = "TextBoxOrderID";
            this.TextBoxOrderID.Size = new System.Drawing.Size(218, 31);
            this.TextBoxOrderID.TabIndex = 4;
            this.TextBoxOrderID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.Maroon;
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.Font = new System.Drawing.Font("Microsoft JhengHei", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.Black;
            this.BtnClose.Location = new System.Drawing.Point(656, 0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(60, 44);
            this.BtnClose.TabIndex = 0;
            this.BtnClose.Text = "X";
            this.BtnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnClose.Click += new System.EventHandler(this.btnLabelClose1_Click);
            // 
            // TextBoxTotalPrice
            // 
            this.TextBoxTotalPrice.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TextBoxTotalPrice.Enabled = false;
            this.TextBoxTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxTotalPrice.Location = new System.Drawing.Point(29, 231);
            this.TextBoxTotalPrice.Name = "TextBoxTotalPrice";
            this.TextBoxTotalPrice.Size = new System.Drawing.Size(218, 31);
            this.TextBoxTotalPrice.TabIndex = 5;
            this.TextBoxTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnPay
            // 
            this.BtnPay.BackColor = System.Drawing.Color.YellowGreen;
            this.BtnPay.Location = new System.Drawing.Point(499, 519);
            this.BtnPay.Name = "BtnPay";
            this.BtnPay.Size = new System.Drawing.Size(201, 49);
            this.BtnPay.TabIndex = 6;
            this.BtnPay.Text = "Proceed to payment";
            this.BtnPay.UseVisualStyleBackColor = false;
            this.BtnPay.Click += new System.EventHandler(this.BtnPay_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.IndianRed;
            this.BtnCancel.Location = new System.Drawing.Point(12, 519);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(201, 49);
            this.BtnCancel.TabIndex = 7;
            this.BtnCancel.Text = "Return";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // FrmCart
            // 
            this.AcceptButton = this.BtnPay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.BackgroundImage = global::LoginForm.Properties.Resources.Ali_s_Shop;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(712, 584);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnPay);
            this.Controls.Add(this.TextBoxTotalPrice);
            this.Controls.Add(this.TextBoxOrderID);
            this.Controls.Add(this.LabelWarning);
            this.Controls.Add(this.BtnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCart";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmCart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.Buttons.BtnLabelClose BtnClose;
        private System.Windows.Forms.Label LabelWarning;
        private System.Windows.Forms.TextBox TextBoxOrderID;
        private System.Windows.Forms.TextBox TextBoxTotalPrice;
        private System.Windows.Forms.Button BtnPay;
        private System.Windows.Forms.Button BtnCancel;
    }
}