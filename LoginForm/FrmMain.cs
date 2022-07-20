using CodeFirst_DAL;
using CodeFirst_DAL.Repository.UnitOfWork;
using CodeFirst_Models.Models;
using CustomMBoxes.InfoMBox;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class FrmMain : Form
    {
        Person GetPerson = new Person();
        UnitOfWork uow;
        string nameMain = string.Empty;
        List<Gun> gunList = new List<Gun>();
        MyContext ctx = new MyContext(); 

        public FrmMain(Person localPerson, UnitOfWork localUow)
        {
            uow = localUow;
            GetPerson = localPerson;
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            var myGun = ctx.Guns.Find(1);

            try
            {
                #region FillCmbCategory
                CmbBoxCat.DataSource = FillCmbCategories();
                CmbBoxCat.DisplayMember = "Type";
                CmbBoxCat.ValueMember = "ID";
                CmbBoxCat.SelectedIndex = 2;
                #endregion

                #region [DBForTest]
                FrmSplash frmSplash = new FrmSplash();
                #endregion

                #region [Disable TxtBox]
                foreach (Control item in groupBoxSummary.Controls)
                    if (item is TextBox)
                        item.Enabled = false;
                #endregion

                #region [Form Handling]
                frmSplash.Show();
                frmSplash.Refresh();
                frmSplash.UseWaitCursor = true;
                frmSplash.Cursor = Cursors.WaitCursor;
                System.Threading.Thread.Sleep(4000);
                frmSplash.Close();
                #endregion

                LabelPerson.Text = $"Welcome {GetPerson.Name} !";

                ListBoxGunList.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                WarningMBox.ShowMBox($"A technical error occured, please contact admin . \nError Details : {ex.Message}");
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ListBoxGunList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LabelPreview.Text = ListBoxGunList.SelectedItem.ToString();
                #region Btn Enable Or not
                BtnShowAll.Enabled = true;
                btnAdd.Enabled = true;
                BtnInfo.Enabled = true;
                #endregion

                #region [Info Of Selected Product]
                string[] name;
                name = LabelPreview.Text.Split(' ');
                nameMain = name[0].Trim();

                var fireMode = (from gun in uow.RepositoryGun.Get()
                                join fire in uow.RepositoryFireMode.Get()
                                on gun.FireModeID equals fire.ID
                                where gun.Name.Equals(nameMain)
                                select fire.Mode).ToArray();

                var country = (from gun in uow.RepositoryGun.Get()
                               where gun.Name.Equals(nameMain)
                               select gun.CountryObj).ToArray();

                var countryMain = (from cntry in country.FirstOrDefault()
                                   select cntry.CountryName);

                string countryFinal = string.Join(",", countryMain);

                var cat = (from gun in uow.RepositoryGun.Get()
                           join category in uow.RepositoryCategory.Get()
                           on gun.CategoryID equals category.ID
                           where gun.Name.Equals(nameMain)
                           select category.Type).ToArray();
                #endregion

                #region [Fill TxtBox]
                TxtBoxName.Text = nameMain;
                TxtBoxCat.Text = cat.FirstOrDefault();
                TxtBoxFireMode.Text = fireMode.FirstOrDefault();
                TxtBoxCountry.Text = countryFinal;
                #endregion
            }
            catch (Exception e2)
            {
                WarningMBox.ShowMBox($"A technical error occured, please contact admin . \nError Details : {e2.Message}");
            }

        }

        private void contactUs_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.web.whatsapp.com");
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.microsoft.com/");
        }

        private void BtnInfo_Click(object sender, EventArgs e)
        {
            #region [Full Info With Where]
            var link = uow.RepositoryGun.Get(p => p.Name.Equals(nameMain)).Select(p => p.FullInfoURL).ToArray();
            #endregion

            System.Diagnostics.Process.Start(link.FirstOrDefault());
        }

        private void goToCartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOrder frmCart = new FrmOrder(gunList, GetPerson, uow);
            frmCart.ShowDialog();
            frmCart.Refresh();
        }

        private void BtnShowAll_Click(object sender, EventArgs e)
        {
            InfoMBox.ShowMBox(TxtBoxCountry.Text, "Manufacturers");
        }

        private void BtnShowAll_MouseEnter(object sender, EventArgs e)
        {
            TxtBoxCountry.BackColor = Color.Orange;
            BtnShowAll.BackColor = Color.Gold;
            LabelCountry.ForeColor = Color.DarkRed;
        }

        private void BtnShowAll_MouseLeave(object sender, EventArgs e)
        {
            TxtBoxCountry.BackColor = Color.Gold;
            BtnShowAll.BackColor = Color.Snow;
            LabelCountry.ForeColor = Color.White;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            #region AddToCart
            if (gunList.Count() == 20)
            {
                WarningMBox.ShowMBox("Sorry, You can't order more than 20 products in every order");
                btnAdd.Enabled = false;
                return;
            }

            Gun gunObj = uow.RepositoryGun.Get(p => p.Name.Equals(nameMain)).FirstOrDefault();

            if (gunList.Contains(gunObj))
            {
                WarningMBox.ShowMBox("You have already added this item into your cart .");
                return;
            }

            gunList.Add(gunObj);

            LabelCartCount.Text = $"Cart : {gunList.Count}";
            #endregion
            BtnCartResetEnable();
        }

        private void BtnCart_Click(object sender, EventArgs e)
        {
            FrmOrder frmOrder = new FrmOrder(gunList, GetPerson, uow);

            if (frmOrder.ShowDialog() == DialogResult.OK)
            {
                ResetBtn_Click(null, null);
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            gunList.Clear();
            LabelCartCount.Text = "Cart : 0";
            BtnCartResetEnable();
        }

        private void CmbBoxCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region FillListBox
            ListBoxGunList.Items.Clear();

            Category category = CmbBoxCat.SelectedItem as Category;

            if (category.ID == 3)
            {
                ListBoxGunList.Items.AddRange(FillListBox().ToArray());
                ListBoxGunList.SelectedIndex = 0;
                return;
            }

            ListBoxGunList.Items.AddRange(FillListBoxWhereCat(category.ID).ToArray());
            #endregion

            ListBoxGunList.SelectedIndex = 0;


            BtnCartResetEnable();
        }


        private void BtnCartResetEnable()
        {
            BtnCart.Enabled = gunList.Count > 0 ? true : false;

            goToCartToolStripMenuItem.Enabled = gunList.Count > 0 ? true : false;

            ResetBtn.Enabled = gunList.Count > 0 ? true : false;
        }

        //Fill Methods
        private List<string> FillListBox()
        {
            List<string> gunListName = new List<string>();
            foreach (var row in uow.RepositoryGun.Get().ToList())
                gunListName.Add(row.Name + " => " + row.Price + "$");

            return gunListName;
        }

        private List<string> FillListBoxWhereCat(int catID)
        {
            List<string> gunListName = new List<string>();
            foreach (var row in uow.RepositoryGun.Get().ToList())
                if (row.CategoryID.Equals(catID))
                    gunListName.Add(row.Name + " => " + row.Price + "$");

            return gunListName;
        }

        private List<Category> FillCmbCategories()
        {
            return uow.RepositoryCategory.Get().ToList();
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BtnEditPerson_Click(object sender, EventArgs e)
        {
            FrmEditInfo frmEditInfo = new FrmEditInfo(GetPerson, uow);
            frmEditInfo.ShowDialog();
            if (frmEditInfo.DialogResult == DialogResult.OK)
                LabelPerson.Text = $"Welcome {GetPerson.Name.Trim()}!";
        }

        private void BtnEditSec_Click(object sender, EventArgs e)
        {
            FrmEditSec frmEditSec = new FrmEditSec(GetPerson, uow);

            frmEditSec.ShowDialog();
        }

        private void editSecurityInformationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BtnEditSec_Click(null, null);
        }

        private void BtnTrackOrder_Click(object sender, EventArgs e)
        {
            FrmTrackOrder frmTrackOrder = new FrmTrackOrder(GetPerson, uow);

            frmTrackOrder.ShowDialog();
        }

        private void trackYourOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BtnTrackOrder_Click(null, null);
        }
    }
}

