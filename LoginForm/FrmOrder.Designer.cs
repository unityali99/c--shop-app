using LoginForm.Properties;

namespace LoginForm
{
    partial class FrmOrder
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
            this.BtnSetQyt = new System.Windows.Forms.Button();
            this.NumericTxtBox = new System.Windows.Forms.NumericUpDown();
            this.ListBoxGunOrder = new DevExpress.XtraEditors.ListBoxControl();
            this.BtnSubmitOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumericTxtBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListBoxGunOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSetQyt
            // 
            this.BtnSetQyt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnSetQyt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSetQyt.Location = new System.Drawing.Point(192, 54);
            this.BtnSetQyt.Name = "BtnSetQyt";
            this.BtnSetQyt.Size = new System.Drawing.Size(228, 107);
            this.BtnSetQyt.TabIndex = 2;
            this.BtnSetQyt.Text = "Set Quantity";
            this.BtnSetQyt.UseVisualStyleBackColor = false;
            this.BtnSetQyt.Click += new System.EventHandler(this.BtnSetQyt_Click);
            // 
            // NumericTxtBox
            // 
            this.NumericTxtBox.BackColor = System.Drawing.SystemColors.Info;
            this.NumericTxtBox.Enabled = false;
            this.NumericTxtBox.Location = new System.Drawing.Point(263, 22);
            this.NumericTxtBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NumericTxtBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericTxtBox.Name = "NumericTxtBox";
            this.NumericTxtBox.Size = new System.Drawing.Size(86, 20);
            this.NumericTxtBox.TabIndex = 1;
            this.NumericTxtBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericTxtBox.ValueChanged += new System.EventHandler(this.NumericTxtBox_ValueChanged);
            // 
            // ListBoxGunOrder
            // 
            this.ListBoxGunOrder.Appearance.BackColor = System.Drawing.Color.Aquamarine;
            this.ListBoxGunOrder.Appearance.Options.UseBackColor = true;
            this.ListBoxGunOrder.Location = new System.Drawing.Point(-2, 0);
            this.ListBoxGunOrder.Name = "ListBoxGunOrder";
            this.ListBoxGunOrder.Size = new System.Drawing.Size(189, 290);
            this.ListBoxGunOrder.TabIndex = 0;
            this.ListBoxGunOrder.SelectedIndexChanged += new System.EventHandler(this.ListBoxGunOrder_SelectedIndexChanged);
            // 
            // BtnSubmitOrder
            // 
            this.BtnSubmitOrder.BackColor = System.Drawing.Color.DarkGreen;
            this.BtnSubmitOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubmitOrder.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnSubmitOrder.Location = new System.Drawing.Point(192, 172);
            this.BtnSubmitOrder.Name = "BtnSubmitOrder";
            this.BtnSubmitOrder.Size = new System.Drawing.Size(228, 107);
            this.BtnSubmitOrder.TabIndex = 3;
            this.BtnSubmitOrder.Text = "Submit Order";
            this.BtnSubmitOrder.UseVisualStyleBackColor = false;
            this.BtnSubmitOrder.Click += new System.EventHandler(this.BtnSubmitOrder_Click);
            // 
            // FrmOrder
            // 
            this.AcceptButton = this.BtnSetQyt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 290);
            this.Controls.Add(this.BtnSubmitOrder);
            this.Controls.Add(this.ListBoxGunOrder);
            this.Controls.Add(this.NumericTxtBox);
            this.Controls.Add(this.BtnSetQyt);
            this.Icon = global::LoginForm.Properties.Resources.Cart;
            this.Name = "FrmOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Order";
            this.Load += new System.EventHandler(this.FrmOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumericTxtBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListBoxGunOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnSetQyt;
        private System.Windows.Forms.NumericUpDown NumericTxtBox;
        private DevExpress.XtraEditors.ListBoxControl ListBoxGunOrder;
        private System.Windows.Forms.Button BtnSubmitOrder;
    }
}