using Ali_Tools;
using CodeFirst_DAL.Repository.UnitOfWork;
using CodeFirst_Models.Models;
using CustomMBoxes.InfoMBox;
using System;
using System.Linq;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class FrmLogin : Form
    {
        UnitOfWork uow = new UnitOfWork();
        Person person = new Person();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            #region CheckBoxRemember
            if (ChkBoxRemember.Checked)
            {
                Properties.Settings.Default.UserName = TxtBoxUser.Text.Trim();
                Properties.Settings.Default.Password = TxtBoxPass.Text.Trim();
            }
            else
            {
                Properties.Settings.Default.UserName = string.Empty;
                Properties.Settings.Default.Password = string.Empty;
            }
            Properties.Settings.Default.Save();
            #endregion

            #region CheckUserPass
            string hashedUser = HashedData.HashUserPass(TxtBoxUser.Text.Trim(), TxtBoxPass.Text.Trim(), out string hashedPass);

            var userNameDB = uow.RepositoryAccount.Get(u => u.UserName.Equals(hashedUser) && u.Password.Equals(hashedPass)).ToList();

            if (userNameDB.Count == 0)
            {
                WarningMBox.ShowMBox("Username or Password is invalid.Sign Up if you'r new.", "Login");
                return;
            }

            person = uow.RepositoryPerson.GetByPersonID(userNameDB.FirstOrDefault().PersonID);

            FrmMain frmMain = new FrmMain(person, uow);

            if (person != null)
            {
                this.Hide();
                frmMain.ShowDialog();
            }
            #endregion
        }


        private void FrmLogin_TxtEmptyOrNot(object sender, EventArgs e)
        {
            BtnLogin.Enabled = !(TxtBoxUser.Text.Trim().Equals(string.Empty) || TxtBoxPass.Text.Trim().Equals(string.Empty));
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            TxtBoxUser.Text = Properties.Settings.Default.UserName;
            TxtBoxPass.Text = Properties.Settings.Default.Password;
            FrmLogin_TxtEmptyOrNot(null, null);
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            FrmCreateAcc frmCreateAcc = new FrmCreateAcc(uow);
            frmCreateAcc.ShowDialog();
        }

        private void ChkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            TxtBoxPass.UseSystemPasswordChar = !ChkBoxShowPass.Checked;
        }

        private void linkLabelForgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmForgotPassword frmForgotPassword = new FrmForgotPassword(uow);

            frmForgotPassword.ShowDialog();
        }
    }
}
