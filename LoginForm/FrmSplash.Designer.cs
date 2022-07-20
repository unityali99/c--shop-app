
namespace LoginForm
{
    partial class FrmSplash
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
            this.PicBoxSplash = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxSplash)).BeginInit();
            this.SuspendLayout();
            // 
            // PicBoxSplash
            // 
            this.PicBoxSplash.BackColor = System.Drawing.SystemColors.Control;
            this.PicBoxSplash.BackgroundImage = global::LoginForm.Properties.Resources.SplashImg;
            this.PicBoxSplash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PicBoxSplash.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.PicBoxSplash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PicBoxSplash.Location = new System.Drawing.Point(0, 0);
            this.PicBoxSplash.Name = "PicBoxSplash";
            this.PicBoxSplash.Size = new System.Drawing.Size(562, 693);
            this.PicBoxSplash.TabIndex = 0;
            this.PicBoxSplash.TabStop = false;
            this.PicBoxSplash.UseWaitCursor = true;
            // 
            // FrmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(562, 693);
            this.ControlBox = false;
            this.Controls.Add(this.PicBoxSplash);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSplash";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashFrm";
            this.UseWaitCursor = true;
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxSplash)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PicBoxSplash;
    }
}