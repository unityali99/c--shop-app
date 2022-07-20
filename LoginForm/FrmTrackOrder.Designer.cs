
namespace LoginForm
{
    partial class FrmTrackOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTrackOrder));
            this.ListBoxOrder = new System.Windows.Forms.ListBox();
            this.LblStatus = new System.Windows.Forms.Label();
            this.GrpBoxOrder = new System.Windows.Forms.GroupBox();
            this.GrpBoxOrderDetail = new System.Windows.Forms.GroupBox();
            this.ListBoxOrderDetail = new System.Windows.Forms.ListBox();
            this.BtnDeleteOrder = new System.Windows.Forms.Button();
            this.BtnGotoPay = new CustomControls.Buttons.BtnCart();
            this.GrpBoxOrder.SuspendLayout();
            this.GrpBoxOrderDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListBoxOrder
            // 
            this.ListBoxOrder.BackColor = System.Drawing.Color.Bisque;
            this.ListBoxOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBoxOrder.ForeColor = System.Drawing.SystemColors.InfoText;
            this.ListBoxOrder.FormattingEnabled = true;
            this.ListBoxOrder.ItemHeight = 15;
            this.ListBoxOrder.Location = new System.Drawing.Point(6, 17);
            this.ListBoxOrder.Name = "ListBoxOrder";
            this.ListBoxOrder.Size = new System.Drawing.Size(287, 394);
            this.ListBoxOrder.TabIndex = 0;
            this.ListBoxOrder.SelectedIndexChanged += new System.EventHandler(this.ListBoxOrder_SelectedIndexChanged);
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.Font = new System.Drawing.Font("MRT_Moala", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStatus.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LblStatus.Location = new System.Drawing.Point(429, 94);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(178, 35);
            this.LblStatus.TabIndex = 1;
            this.LblStatus.Text = "Order\'s Status :";
            // 
            // GrpBoxOrder
            // 
            this.GrpBoxOrder.Controls.Add(this.ListBoxOrder);
            this.GrpBoxOrder.Location = new System.Drawing.Point(12, 12);
            this.GrpBoxOrder.Name = "GrpBoxOrder";
            this.GrpBoxOrder.Size = new System.Drawing.Size(299, 426);
            this.GrpBoxOrder.TabIndex = 2;
            this.GrpBoxOrder.TabStop = false;
            this.GrpBoxOrder.Text = "Orders";
            // 
            // GrpBoxOrderDetail
            // 
            this.GrpBoxOrderDetail.Controls.Add(this.ListBoxOrderDetail);
            this.GrpBoxOrderDetail.Location = new System.Drawing.Point(710, 12);
            this.GrpBoxOrderDetail.Name = "GrpBoxOrderDetail";
            this.GrpBoxOrderDetail.Size = new System.Drawing.Size(298, 426);
            this.GrpBoxOrderDetail.TabIndex = 3;
            this.GrpBoxOrderDetail.TabStop = false;
            this.GrpBoxOrderDetail.Text = "Order Details";
            // 
            // ListBoxOrderDetail
            // 
            this.ListBoxOrderDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ListBoxOrderDetail.Enabled = false;
            this.ListBoxOrderDetail.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBoxOrderDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ListBoxOrderDetail.FormattingEnabled = true;
            this.ListBoxOrderDetail.ItemHeight = 19;
            this.ListBoxOrderDetail.Location = new System.Drawing.Point(15, 18);
            this.ListBoxOrderDetail.Name = "ListBoxOrderDetail";
            this.ListBoxOrderDetail.Size = new System.Drawing.Size(277, 384);
            this.ListBoxOrderDetail.TabIndex = 4;
            // 
            // BtnDeleteOrder
            // 
            this.BtnDeleteOrder.BackColor = System.Drawing.Color.Maroon;
            this.BtnDeleteOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteOrder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnDeleteOrder.Location = new System.Drawing.Point(357, 308);
            this.BtnDeleteOrder.Name = "BtnDeleteOrder";
            this.BtnDeleteOrder.Size = new System.Drawing.Size(311, 52);
            this.BtnDeleteOrder.TabIndex = 5;
            this.BtnDeleteOrder.Text = "Delete Order";
            this.BtnDeleteOrder.UseVisualStyleBackColor = false;
            this.BtnDeleteOrder.Click += new System.EventHandler(this.BtnDeleteOrder_Click);
            // 
            // BtnGotoPay
            // 
            this.BtnGotoPay.Font = new System.Drawing.Font("Tahoma", 12F);
            this.BtnGotoPay.Image = ((System.Drawing.Image)(resources.GetObject("BtnGotoPay.Image")));
            this.BtnGotoPay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGotoPay.Location = new System.Drawing.Point(410, 170);
            this.BtnGotoPay.Name = "BtnGotoPay";
            this.BtnGotoPay.Size = new System.Drawing.Size(213, 114);
            this.BtnGotoPay.TabIndex = 4;
            this.BtnGotoPay.Text = "Proceed To Payment";
            this.BtnGotoPay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGotoPay.UseVisualStyleBackColor = true;
            this.BtnGotoPay.Click += new System.EventHandler(this.BtnGotoPay_Click);
            // 
            // FrmTrackOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 450);
            this.Controls.Add(this.BtnDeleteOrder);
            this.Controls.Add(this.BtnGotoPay);
            this.Controls.Add(this.GrpBoxOrderDetail);
            this.Controls.Add(this.GrpBoxOrder);
            this.Controls.Add(this.LblStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.Name = "FrmTrackOrder";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Track Orders";
            this.Load += new System.EventHandler(this.FrmTrackOrder_Load);
            this.GrpBoxOrder.ResumeLayout(false);
            this.GrpBoxOrderDetail.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxOrder;
        private System.Windows.Forms.Label LblStatus;
        private System.Windows.Forms.GroupBox GrpBoxOrder;
        private System.Windows.Forms.GroupBox GrpBoxOrderDetail;
        private System.Windows.Forms.ListBox ListBoxOrderDetail;
        private CustomControls.Buttons.BtnCart BtnGotoPay;
        private System.Windows.Forms.Button BtnDeleteOrder;
    }
}