using Ali_Tools;
using CodeFirst_DAL.Repository.UnitOfWork;
using CodeFirst_Models.Models;
using CustomMBoxes.InfoMBox;
using System;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class FrmEditSec : Form
    {
        Person person = null;
        UnitOfWork uow = null;
        public FrmEditSec(Person getPerson, UnitOfWork localUow)
        {
            person = getPerson;
            uow = localUow;
            InitializeComponent();
        }

        private void ChkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            TxtBoxCurrentPass.UseSystemPasswordChar = !ChkBoxShowPass.Checked;
            TxtBoxPass.UseSystemPasswordChar = !ChkBoxShowPass.Checked;
            TxtBoxPassRe.UseSystemPasswordChar = !ChkBoxShowPass.Checked;
        }

        private void FrmEditSec_Load(object sender, EventArgs e)
        {
            TxtBoxCurrentPass.Focus();
        }

        private void BtnChangePass_Click(object sender, EventArgs e)
        {
            foreach (Control item in GrpBoxSec.Controls)
            {
                if (item is TextBox)
                    if (item.Text == string.Empty)
                    {
                        WarningMBox.ShowMBox("Please fill out the boxes correctly.");
                        return;
                    }
            }
            string newPass = HashedData.HashUserPass(TxtBoxPass.Text.Trim(), TxtBoxCurrentPass.Text.Trim(), out string confirmedPass);
            var account = uow.RepositoryAccount.GetByPersonID(person.PersonID);
            if (!(confirmedPass == account.Password))
            {
                WarningMBox.ShowMBox("The password you typed doesen't match your current password.");
                return;
            }
            if (TxtBoxPass.Text.Length < 8)
            {
                WarningMBox.ShowMBox("Your password's length cannot be less than 8 characters.");
                return;
            }
            if (!TxtBoxPass.Text.Equals(TxtBoxPassRe.Text))
            {
                WarningMBox.ShowMBox("Please Repeat your new password correctly.");
                return;
            }
            if (TxtBoxPass.Text.Equals(TxtBoxCurrentPass.Text))
            {
                WarningMBox.ShowMBox("Your new password cannot be the same as your current password.");
                return;
            }
            account.Password = newPass;
            uow.RepositoryAccount.Update(account);
            uow.Save();
            InfoMBox.ShowMBox("Your password has been changed successfully");
            this.Close();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
