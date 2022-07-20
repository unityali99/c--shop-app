
namespace MainForm
{
    partial class Form1
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.contactSupportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactCoderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToForumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tellAFriendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contactSupportToolStripMenuItem,
            this.goToForumToolStripMenuItem,
            this.tellAFriendToolStripMenuItem});
            this.toolStripSplitButton1.Image = global::MainForm.Properties.Resources.Support_1;
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 22);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // contactSupportToolStripMenuItem
            // 
            this.contactSupportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contactCoderToolStripMenuItem,
            this.contactManagerToolStripMenuItem});
            this.contactSupportToolStripMenuItem.Name = "contactSupportToolStripMenuItem";
            this.contactSupportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.contactSupportToolStripMenuItem.Text = "Contact-Support";
            // 
            // contactCoderToolStripMenuItem
            // 
            this.contactCoderToolStripMenuItem.Name = "contactCoderToolStripMenuItem";
            this.contactCoderToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.contactCoderToolStripMenuItem.Text = "Contact Manager";
            // 
            // contactManagerToolStripMenuItem
            // 
            this.contactManagerToolStripMenuItem.Name = "contactManagerToolStripMenuItem";
            this.contactManagerToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.contactManagerToolStripMenuItem.Text = "Contact CoderTeam";
            // 
            // goToForumToolStripMenuItem
            // 
            this.goToForumToolStripMenuItem.Name = "goToForumToolStripMenuItem";
            this.goToForumToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.goToForumToolStripMenuItem.Text = "Go To Forum";
            // 
            // tellAFriendToolStripMenuItem
            // 
            this.tellAFriendToolStripMenuItem.Name = "tellAFriendToolStripMenuItem";
            this.tellAFriendToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tellAFriendToolStripMenuItem.Text = "Tell a friend";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem contactSupportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactCoderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goToForumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tellAFriendToolStripMenuItem;
    }
}

