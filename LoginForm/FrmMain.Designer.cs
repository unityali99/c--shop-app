
using LoginForm.Properties;
using System.Windows.Forms;

namespace LoginForm
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.ToolTip = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButtonSupport = new System.Windows.Forms.ToolStripDropDownButton();
            this.contactSupportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactManagerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contactSellerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactWebSUpportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tellAFriendToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.goToForumToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ourWebsiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButtonTools = new System.Windows.Forms.ToolStripDropDownButton();
            this.goToCartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editPersonalInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editSecurityInformationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trackYourOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ourBranchesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnToolStripSupport = new System.Windows.Forms.ToolStripSplitButton();
            this.contactUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactCoderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToForumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tellAFriendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnToolStripInfo = new System.Windows.Forms.ToolStripSplitButton();
            this.yourOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yourInformationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.submitATicketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListBoxGunList = new System.Windows.Forms.ListBox();
            this.LabelPreview = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelCountry = new System.Windows.Forms.Label();
            this.LabelFireMode = new System.Windows.Forms.Label();
            this.LabelCategory = new System.Windows.Forms.Label();
            this.groupBoxSummary = new System.Windows.Forms.GroupBox();
            this.BtnTrackOrder = new DevExpress.XtraEditors.SimpleButton();
            this.BtnEditSec = new DevExpress.XtraEditors.SimpleButton();
            this.BtnShowAll = new System.Windows.Forms.Button();
            this.BtnEditPerson = new DevExpress.XtraEditors.SimpleButton();
            this.TxtBoxCat = new System.Windows.Forms.TextBox();
            this.TxtBoxFireMode = new System.Windows.Forms.TextBox();
            this.TxtBoxCountry = new System.Windows.Forms.TextBox();
            this.TxtBoxName = new System.Windows.Forms.TextBox();
            this.LabelPerson = new System.Windows.Forms.Label();
            this.LabelCartCount = new System.Windows.Forms.Label();
            this.BtnCart = new CustomControls.Buttons.BtnCart();
            this.btnAdd = new CustomControls.Buttons.BtnAdd();
            this.BtnInfo = new CustomControls.Buttons.BtnInfo();
            this.CmbBoxCat = new System.Windows.Forms.ComboBox();
            this.ResetBtn = new DevExpress.XtraEditors.SimpleButton();
            this.LabelFilter = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ToolTip.SuspendLayout();
            this.groupBoxSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolTip
            // 
            this.ToolTip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButtonSupport,
            this.toolStripDropDownButtonTools});
            this.ToolTip.Location = new System.Drawing.Point(0, 0);
            this.ToolTip.Name = "ToolTip";
            this.ToolTip.Size = new System.Drawing.Size(1145, 25);
            this.ToolTip.TabIndex = 0;
            this.ToolTip.Text = "toolStrip1";
            // 
            // toolStripDropDownButtonSupport
            // 
            this.toolStripDropDownButtonSupport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButtonSupport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contactSupportToolStripMenuItem,
            this.tellAFriendToolStripMenuItem1,
            this.goToForumToolStripMenuItem1,
            this.ourWebsiteToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripDropDownButtonSupport.Image = global::LoginForm.Properties.Resources.Support1;
            this.toolStripDropDownButtonSupport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonSupport.Name = "toolStripDropDownButtonSupport";
            this.toolStripDropDownButtonSupport.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButtonSupport.Text = "toolStripDropDownButton1";
            this.toolStripDropDownButtonSupport.ToolTipText = "Support";
            // 
            // contactSupportToolStripMenuItem
            // 
            this.contactSupportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contactManagerToolStripMenuItem1,
            this.contactSellerToolStripMenuItem,
            this.contactWebSUpportToolStripMenuItem});
            this.contactSupportToolStripMenuItem.Name = "contactSupportToolStripMenuItem";
            this.contactSupportToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.contactSupportToolStripMenuItem.Text = "Contact-Support";
            // 
            // contactManagerToolStripMenuItem1
            // 
            this.contactManagerToolStripMenuItem1.Name = "contactManagerToolStripMenuItem1";
            this.contactManagerToolStripMenuItem1.Size = new System.Drawing.Size(187, 22);
            this.contactManagerToolStripMenuItem1.Text = "Contact-Manager";
            this.contactManagerToolStripMenuItem1.Click += new System.EventHandler(this.contactUs_Click);
            // 
            // contactSellerToolStripMenuItem
            // 
            this.contactSellerToolStripMenuItem.Name = "contactSellerToolStripMenuItem";
            this.contactSellerToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.contactSellerToolStripMenuItem.Text = "Contact-Seller";
            this.contactSellerToolStripMenuItem.Click += new System.EventHandler(this.contactUs_Click);
            // 
            // contactWebSUpportToolStripMenuItem
            // 
            this.contactWebSUpportToolStripMenuItem.Name = "contactWebSUpportToolStripMenuItem";
            this.contactWebSUpportToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.contactWebSUpportToolStripMenuItem.Text = "Contact-WebSupport";
            this.contactWebSUpportToolStripMenuItem.Click += new System.EventHandler(this.contactUs_Click);
            // 
            // tellAFriendToolStripMenuItem1
            // 
            this.tellAFriendToolStripMenuItem1.Name = "tellAFriendToolStripMenuItem1";
            this.tellAFriendToolStripMenuItem1.Size = new System.Drawing.Size(163, 22);
            this.tellAFriendToolStripMenuItem1.Text = "Tell A Friend";
            // 
            // goToForumToolStripMenuItem1
            // 
            this.goToForumToolStripMenuItem1.Name = "goToForumToolStripMenuItem1";
            this.goToForumToolStripMenuItem1.Size = new System.Drawing.Size(163, 22);
            this.goToForumToolStripMenuItem1.Text = "Go To Forum";
            // 
            // ourWebsiteToolStripMenuItem
            // 
            this.ourWebsiteToolStripMenuItem.Name = "ourWebsiteToolStripMenuItem";
            this.ourWebsiteToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.ourWebsiteToolStripMenuItem.Text = "Our Website";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.exitToolStripMenuItem.Text = "Exit ";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripDropDownButtonTools
            // 
            this.toolStripDropDownButtonTools.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButtonTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goToCartToolStripMenuItem,
            this.editPersonalInformationToolStripMenuItem,
            this.editSecurityInformationsToolStripMenuItem,
            this.trackYourOrdersToolStripMenuItem,
            this.ourBranchesToolStripMenuItem});
            this.toolStripDropDownButtonTools.Image = global::LoginForm.Properties.Resources.tools;
            this.toolStripDropDownButtonTools.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonTools.Name = "toolStripDropDownButtonTools";
            this.toolStripDropDownButtonTools.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButtonTools.Text = "toolStripDropDownButton2";
            this.toolStripDropDownButtonTools.ToolTipText = "Tools";
            // 
            // goToCartToolStripMenuItem
            // 
            this.goToCartToolStripMenuItem.Enabled = false;
            this.goToCartToolStripMenuItem.Name = "goToCartToolStripMenuItem";
            this.goToCartToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.goToCartToolStripMenuItem.Text = "Go to Cart";
            this.goToCartToolStripMenuItem.Click += new System.EventHandler(this.goToCartToolStripMenuItem_Click);
            // 
            // editPersonalInformationToolStripMenuItem
            // 
            this.editPersonalInformationToolStripMenuItem.Name = "editPersonalInformationToolStripMenuItem";
            this.editPersonalInformationToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.editPersonalInformationToolStripMenuItem.Text = "Edit Personal Informations";
            this.editPersonalInformationToolStripMenuItem.Click += new System.EventHandler(this.BtnEditPerson_Click);
            // 
            // editSecurityInformationsToolStripMenuItem
            // 
            this.editSecurityInformationsToolStripMenuItem.Name = "editSecurityInformationsToolStripMenuItem";
            this.editSecurityInformationsToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.editSecurityInformationsToolStripMenuItem.Text = "Edit Security Informations";
            this.editSecurityInformationsToolStripMenuItem.Click += new System.EventHandler(this.editSecurityInformationsToolStripMenuItem_Click);
            // 
            // trackYourOrdersToolStripMenuItem
            // 
            this.trackYourOrdersToolStripMenuItem.Name = "trackYourOrdersToolStripMenuItem";
            this.trackYourOrdersToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.trackYourOrdersToolStripMenuItem.Text = "Track Your Orders";
            this.trackYourOrdersToolStripMenuItem.Click += new System.EventHandler(this.trackYourOrdersToolStripMenuItem_Click);
            // 
            // ourBranchesToolStripMenuItem
            // 
            this.ourBranchesToolStripMenuItem.Name = "ourBranchesToolStripMenuItem";
            this.ourBranchesToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.ourBranchesToolStripMenuItem.Text = "Our Branches";
            // 
            // BtnToolStripSupport
            // 
            this.BtnToolStripSupport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnToolStripSupport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contactUsToolStripMenuItem,
            this.goToForumToolStripMenuItem,
            this.tellAFriendToolStripMenuItem});
            this.BtnToolStripSupport.Image = global::LoginForm.Properties.Resources.Support1;
            this.BtnToolStripSupport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnToolStripSupport.Name = "BtnToolStripSupport";
            this.BtnToolStripSupport.Size = new System.Drawing.Size(32, 22);
            this.BtnToolStripSupport.Text = "BtnToolStripSupport";
            // 
            // contactUsToolStripMenuItem
            // 
            this.contactUsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contactManagerToolStripMenuItem,
            this.contactCoderToolStripMenuItem});
            this.contactUsToolStripMenuItem.Name = "contactUsToolStripMenuItem";
            this.contactUsToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.contactUsToolStripMenuItem.Text = "Contact-Us";
            // 
            // contactManagerToolStripMenuItem
            // 
            this.contactManagerToolStripMenuItem.Name = "contactManagerToolStripMenuItem";
            this.contactManagerToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.contactManagerToolStripMenuItem.Text = "Contact Manager";
            // 
            // contactCoderToolStripMenuItem
            // 
            this.contactCoderToolStripMenuItem.Name = "contactCoderToolStripMenuItem";
            this.contactCoderToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.contactCoderToolStripMenuItem.Text = "Contact Coder";
            // 
            // goToForumToolStripMenuItem
            // 
            this.goToForumToolStripMenuItem.Name = "goToForumToolStripMenuItem";
            this.goToForumToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.goToForumToolStripMenuItem.Text = "Go To Forum";
            // 
            // tellAFriendToolStripMenuItem
            // 
            this.tellAFriendToolStripMenuItem.Name = "tellAFriendToolStripMenuItem";
            this.tellAFriendToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.tellAFriendToolStripMenuItem.Text = "Tell A Friend";
            // 
            // BtnToolStripInfo
            // 
            this.BtnToolStripInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnToolStripInfo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yourOrdersToolStripMenuItem,
            this.yourInformationsToolStripMenuItem,
            this.submitATicketToolStripMenuItem});
            this.BtnToolStripInfo.Image = global::LoginForm.Properties.Resources.tools;
            this.BtnToolStripInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnToolStripInfo.Name = "BtnToolStripInfo";
            this.BtnToolStripInfo.Size = new System.Drawing.Size(32, 22);
            // 
            // yourOrdersToolStripMenuItem
            // 
            this.yourOrdersToolStripMenuItem.Name = "yourOrdersToolStripMenuItem";
            this.yourOrdersToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.yourOrdersToolStripMenuItem.Text = "Your Orders";
            // 
            // yourInformationsToolStripMenuItem
            // 
            this.yourInformationsToolStripMenuItem.Name = "yourInformationsToolStripMenuItem";
            this.yourInformationsToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.yourInformationsToolStripMenuItem.Text = "Your Informations";
            // 
            // submitATicketToolStripMenuItem
            // 
            this.submitATicketToolStripMenuItem.Name = "submitATicketToolStripMenuItem";
            this.submitATicketToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.submitATicketToolStripMenuItem.Text = "Submit A Ticket";
            // 
            // ListBoxGunList
            // 
            this.ListBoxGunList.BackColor = System.Drawing.Color.Linen;
            this.ListBoxGunList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBoxGunList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ListBoxGunList.FormattingEnabled = true;
            this.ListBoxGunList.ItemHeight = 20;
            this.ListBoxGunList.Location = new System.Drawing.Point(7, 47);
            this.ListBoxGunList.Name = "ListBoxGunList";
            this.ListBoxGunList.ScrollAlwaysVisible = true;
            this.ListBoxGunList.Size = new System.Drawing.Size(206, 404);
            this.ListBoxGunList.TabIndex = 0;
            this.ListBoxGunList.SelectedIndexChanged += new System.EventHandler(this.ListBoxGunList_SelectedIndexChanged);
            // 
            // LabelPreview
            // 
            this.LabelPreview.AutoSize = true;
            this.LabelPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.LabelPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelPreview.Font = new System.Drawing.Font("Lucida Calligraphy", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPreview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabelPreview.Location = new System.Drawing.Point(582, 41);
            this.LabelPreview.Name = "LabelPreview";
            this.LabelPreview.Size = new System.Drawing.Size(231, 38);
            this.LabelPreview.TabIndex = 5;
            this.LabelPreview.Text = "Ali\'s Weapons";
            this.LabelPreview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.BackColor = System.Drawing.Color.Transparent;
            this.LabelName.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelName.ForeColor = System.Drawing.Color.White;
            this.LabelName.Location = new System.Drawing.Point(40, 55);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(88, 28);
            this.LabelName.TabIndex = 6;
            this.LabelName.Text = "Model :";
            this.LabelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelCountry
            // 
            this.LabelCountry.AutoSize = true;
            this.LabelCountry.BackColor = System.Drawing.Color.Transparent;
            this.LabelCountry.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCountry.ForeColor = System.Drawing.Color.White;
            this.LabelCountry.Location = new System.Drawing.Point(40, 131);
            this.LabelCountry.Name = "LabelCountry";
            this.LabelCountry.Size = new System.Drawing.Size(180, 28);
            this.LabelCountry.TabIndex = 7;
            this.LabelCountry.Text = "Manufacturer/s :";
            this.LabelCountry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelFireMode
            // 
            this.LabelFireMode.AutoSize = true;
            this.LabelFireMode.BackColor = System.Drawing.Color.Transparent;
            this.LabelFireMode.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFireMode.ForeColor = System.Drawing.Color.White;
            this.LabelFireMode.Location = new System.Drawing.Point(40, 209);
            this.LabelFireMode.Name = "LabelFireMode";
            this.LabelFireMode.Size = new System.Drawing.Size(145, 28);
            this.LabelFireMode.TabIndex = 8;
            this.LabelFireMode.Text = "Firing Mode :";
            this.LabelFireMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelCategory
            // 
            this.LabelCategory.AutoSize = true;
            this.LabelCategory.BackColor = System.Drawing.Color.Transparent;
            this.LabelCategory.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCategory.ForeColor = System.Drawing.Color.White;
            this.LabelCategory.Location = new System.Drawing.Point(40, 288);
            this.LabelCategory.Name = "LabelCategory";
            this.LabelCategory.Size = new System.Drawing.Size(114, 28);
            this.LabelCategory.TabIndex = 9;
            this.LabelCategory.Text = "Category :";
            this.LabelCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxSummary
            // 
            this.groupBoxSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.groupBoxSummary.Controls.Add(this.BtnTrackOrder);
            this.groupBoxSummary.Controls.Add(this.BtnEditSec);
            this.groupBoxSummary.Controls.Add(this.BtnShowAll);
            this.groupBoxSummary.Controls.Add(this.BtnEditPerson);
            this.groupBoxSummary.Controls.Add(this.TxtBoxCat);
            this.groupBoxSummary.Controls.Add(this.TxtBoxFireMode);
            this.groupBoxSummary.Controls.Add(this.TxtBoxCountry);
            this.groupBoxSummary.Controls.Add(this.TxtBoxName);
            this.groupBoxSummary.Controls.Add(this.LabelName);
            this.groupBoxSummary.Controls.Add(this.LabelCategory);
            this.groupBoxSummary.Controls.Add(this.LabelCountry);
            this.groupBoxSummary.Controls.Add(this.LabelFireMode);
            this.groupBoxSummary.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSummary.Location = new System.Drawing.Point(424, 96);
            this.groupBoxSummary.Name = "groupBoxSummary";
            this.groupBoxSummary.Size = new System.Drawing.Size(711, 356);
            this.groupBoxSummary.TabIndex = 10;
            this.groupBoxSummary.TabStop = false;
            this.groupBoxSummary.Text = "Information";
            // 
            // BtnTrackOrder
            // 
            this.BtnTrackOrder.Location = new System.Drawing.Point(531, 252);
            this.BtnTrackOrder.Name = "BtnTrackOrder";
            this.BtnTrackOrder.Size = new System.Drawing.Size(159, 32);
            this.BtnTrackOrder.TabIndex = 21;
            this.BtnTrackOrder.Text = "Track Your Orders";
            this.BtnTrackOrder.Click += new System.EventHandler(this.BtnTrackOrder_Click);
            // 
            // BtnEditSec
            // 
            this.BtnEditSec.Location = new System.Drawing.Point(531, 175);
            this.BtnEditSec.Name = "BtnEditSec";
            this.BtnEditSec.Size = new System.Drawing.Size(159, 32);
            this.BtnEditSec.TabIndex = 20;
            this.BtnEditSec.Text = "Edit Security Informations";
            this.BtnEditSec.Click += new System.EventHandler(this.BtnEditSec_Click);
            // 
            // BtnShowAll
            // 
            this.BtnShowAll.BackColor = System.Drawing.Color.Snow;
            this.BtnShowAll.Enabled = false;
            this.BtnShowAll.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnShowAll.Location = new System.Drawing.Point(439, 131);
            this.BtnShowAll.Name = "BtnShowAll";
            this.BtnShowAll.Size = new System.Drawing.Size(68, 36);
            this.BtnShowAll.TabIndex = 0;
            this.BtnShowAll.Text = "See All";
            this.BtnShowAll.UseVisualStyleBackColor = false;
            this.BtnShowAll.Click += new System.EventHandler(this.BtnShowAll_Click);
            this.BtnShowAll.MouseEnter += new System.EventHandler(this.BtnShowAll_MouseEnter);
            this.BtnShowAll.MouseLeave += new System.EventHandler(this.BtnShowAll_MouseLeave);
            // 
            // BtnEditPerson
            // 
            this.BtnEditPerson.Location = new System.Drawing.Point(531, 97);
            this.BtnEditPerson.Name = "BtnEditPerson";
            this.BtnEditPerson.Size = new System.Drawing.Size(159, 32);
            this.BtnEditPerson.TabIndex = 18;
            this.BtnEditPerson.Text = "Edit Personal Informations";
            this.BtnEditPerson.Click += new System.EventHandler(this.BtnEditPerson_Click);
            // 
            // TxtBoxCat
            // 
            this.TxtBoxCat.BackColor = System.Drawing.Color.Gold;
            this.TxtBoxCat.Enabled = false;
            this.TxtBoxCat.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxCat.Location = new System.Drawing.Point(160, 288);
            this.TxtBoxCat.Name = "TxtBoxCat";
            this.TxtBoxCat.ShortcutsEnabled = false;
            this.TxtBoxCat.Size = new System.Drawing.Size(347, 36);
            this.TxtBoxCat.TabIndex = 13;
            this.TxtBoxCat.TabStop = false;
            this.TxtBoxCat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtBoxFireMode
            // 
            this.TxtBoxFireMode.BackColor = System.Drawing.Color.Gold;
            this.TxtBoxFireMode.Enabled = false;
            this.TxtBoxFireMode.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxFireMode.Location = new System.Drawing.Point(191, 211);
            this.TxtBoxFireMode.Name = "TxtBoxFireMode";
            this.TxtBoxFireMode.ShortcutsEnabled = false;
            this.TxtBoxFireMode.Size = new System.Drawing.Size(316, 36);
            this.TxtBoxFireMode.TabIndex = 12;
            this.TxtBoxFireMode.TabStop = false;
            this.TxtBoxFireMode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtBoxCountry
            // 
            this.TxtBoxCountry.BackColor = System.Drawing.Color.Gold;
            this.TxtBoxCountry.Enabled = false;
            this.TxtBoxCountry.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxCountry.Location = new System.Drawing.Point(226, 131);
            this.TxtBoxCountry.Name = "TxtBoxCountry";
            this.TxtBoxCountry.ShortcutsEnabled = false;
            this.TxtBoxCountry.Size = new System.Drawing.Size(207, 36);
            this.TxtBoxCountry.TabIndex = 11;
            this.TxtBoxCountry.TabStop = false;
            this.TxtBoxCountry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtBoxName
            // 
            this.TxtBoxName.BackColor = System.Drawing.Color.Gold;
            this.TxtBoxName.Enabled = false;
            this.TxtBoxName.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxName.Location = new System.Drawing.Point(134, 55);
            this.TxtBoxName.Name = "TxtBoxName";
            this.TxtBoxName.ShortcutsEnabled = false;
            this.TxtBoxName.Size = new System.Drawing.Size(373, 36);
            this.TxtBoxName.TabIndex = 10;
            this.TxtBoxName.TabStop = false;
            this.TxtBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LabelPerson
            // 
            this.LabelPerson.AutoSize = true;
            this.LabelPerson.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPerson.Location = new System.Drawing.Point(907, 6);
            this.LabelPerson.Name = "LabelPerson";
            this.LabelPerson.Size = new System.Drawing.Size(74, 15);
            this.LabelPerson.TabIndex = 11;
            this.LabelPerson.Text = "Welcome !";
            // 
            // LabelCartCount
            // 
            this.LabelCartCount.AutoSize = true;
            this.LabelCartCount.BackColor = System.Drawing.Color.Cyan;
            this.LabelCartCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabelCartCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCartCount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelCartCount.Location = new System.Drawing.Point(72, 5);
            this.LabelCartCount.Name = "LabelCartCount";
            this.LabelCartCount.Size = new System.Drawing.Size(58, 18);
            this.LabelCartCount.TabIndex = 12;
            this.LabelCartCount.Text = "Cart : 0";
            // 
            // BtnCart
            // 
            this.BtnCart.Enabled = false;
            this.BtnCart.Font = new System.Drawing.Font("Tahoma", 12F);
            this.BtnCart.Image = ((System.Drawing.Image)(resources.GetObject("BtnCart.Image")));
            this.BtnCart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCart.Location = new System.Drawing.Point(218, 291);
            this.BtnCart.Name = "BtnCart";
            this.BtnCart.Size = new System.Drawing.Size(199, 67);
            this.BtnCart.TabIndex = 3;
            this.BtnCart.Text = " Proceed To Cart  ";
            this.BtnCart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCart.UseVisualStyleBackColor = true;
            this.BtnCart.Click += new System.EventHandler(this.BtnCart_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(218, 109);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(199, 67);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "   Add To Cart";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // BtnInfo
            // 
            this.BtnInfo.Enabled = false;
            this.BtnInfo.Font = new System.Drawing.Font("Tahoma", 12F);
            this.BtnInfo.Image = ((System.Drawing.Image)(resources.GetObject("BtnInfo.Image")));
            this.BtnInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInfo.Location = new System.Drawing.Point(218, 200);
            this.BtnInfo.Name = "BtnInfo";
            this.BtnInfo.Size = new System.Drawing.Size(199, 67);
            this.BtnInfo.TabIndex = 2;
            this.BtnInfo.Text = "More Information";
            this.BtnInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnInfo.UseVisualStyleBackColor = true;
            this.BtnInfo.Click += new System.EventHandler(this.BtnInfo_Click);
            // 
            // CmbBoxCat
            // 
            this.CmbBoxCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBoxCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBoxCat.FormattingEnabled = true;
            this.CmbBoxCat.Location = new System.Drawing.Point(355, 50);
            this.CmbBoxCat.Name = "CmbBoxCat";
            this.CmbBoxCat.Size = new System.Drawing.Size(140, 23);
            this.CmbBoxCat.TabIndex = 0;
            this.CmbBoxCat.SelectedIndexChanged += new System.EventHandler(this.CmbBoxCat_SelectedIndexChanged);
            // 
            // ResetBtn
            // 
            this.ResetBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetBtn.Appearance.Options.UseFont = true;
            this.ResetBtn.Enabled = false;
            this.ResetBtn.Location = new System.Drawing.Point(218, 382);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(199, 67);
            this.ResetBtn.TabIndex = 4;
            this.ResetBtn.Text = "Reset Cart";
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // LabelFilter
            // 
            this.LabelFilter.AutoSize = true;
            this.LabelFilter.Location = new System.Drawing.Point(250, 54);
            this.LabelFilter.Name = "LabelFilter";
            this.LabelFilter.Size = new System.Drawing.Size(101, 13);
            this.LabelFilter.TabIndex = 17;
            this.LabelFilter.Text = "Filter by categories :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(414, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "New items will be available soon !";
            // 
            // FrmMain
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 459);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelFilter);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.CmbBoxCat);
            this.Controls.Add(this.BtnCart);
            this.Controls.Add(this.LabelCartCount);
            this.Controls.Add(this.LabelPerson);
            this.Controls.Add(this.groupBoxSummary);
            this.Controls.Add(this.LabelPreview);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.BtnInfo);
            this.Controls.Add(this.ListBoxGunList);
            this.Controls.Add(this.ToolTip);
            this.Icon = global::LoginForm.Properties.Resources.GunShop;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weapon Shop";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ToolTip.ResumeLayout(false);
            this.ToolTip.PerformLayout();
            this.groupBoxSummary.ResumeLayout(false);
            this.groupBoxSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip ToolTip;
        private System.Windows.Forms.ToolStripSplitButton BtnToolStripSupport;
        private System.Windows.Forms.ToolStripMenuItem contactUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactCoderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goToForumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tellAFriendToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton BtnToolStripInfo;
        private System.Windows.Forms.ToolStripMenuItem yourOrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yourInformationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem submitATicketToolStripMenuItem;
        private System.Windows.Forms.ListBox ListBoxGunList;
        private CustomControls.Buttons.BtnInfo BtnInfo;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonSupport;
        private System.Windows.Forms.ToolStripMenuItem contactSupportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactManagerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem contactSellerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactWebSUpportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tellAFriendToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem goToForumToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ourWebsiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonTools;
        private System.Windows.Forms.ToolStripMenuItem goToCartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editPersonalInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ourBranchesToolStripMenuItem;
        private CustomControls.Buttons.BtnAdd btnAdd;
        private System.Windows.Forms.Label LabelPreview;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelCountry;
        private System.Windows.Forms.Label LabelFireMode;
        private System.Windows.Forms.Label LabelCategory;
        private System.Windows.Forms.GroupBox groupBoxSummary;
        private TextBox TxtBoxCat;
        private TextBox TxtBoxFireMode;
        private TextBox TxtBoxCountry;
        private TextBox TxtBoxName;
        private Button BtnShowAll;
        private Label LabelPerson;
        private Label LabelCartCount;
        private CustomControls.Buttons.BtnCart BtnCart;
        private ComboBox CmbBoxCat;
        private DevExpress.XtraEditors.SimpleButton ResetBtn;
        private Label LabelFilter;
        private DevExpress.XtraEditors.SimpleButton BtnEditSec;
        private DevExpress.XtraEditors.SimpleButton BtnEditPerson;
        private ToolStripMenuItem editSecurityInformationsToolStripMenuItem;
        private ToolStripMenuItem trackYourOrdersToolStripMenuItem;
        private DevExpress.XtraEditors.SimpleButton BtnTrackOrder;
        private Label label1;
    }
}