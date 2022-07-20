using Ali_Tools;
using CodeFirst_DAL.Repository.UnitOfWork;
using CodeFirst_Models.Models;
using CustomMBoxes.InfoMBox;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class FrmCreateAcc : Form
    {
        UnitOfWork uow = null;
        public FrmCreateAcc(UnitOfWork uowLocal)
        {
            uow = uowLocal;
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void BtnSubmit_Click(object sender, System.EventArgs e)
        {
            foreach (Control item in GrpBoxPerson.Controls)
            {
                if (item is TextBox)
                    if (item.Text.Trim() == string.Empty || item.Text.Trim().Length < 2 || TxtBoxSSN.Text.Trim().Length != 10 || !(TxtBoxEmail.Text.Contains("@")))
                    {
                        WarningMBox.ShowMBox("Please fill out all of the boxes correctly.");
                        return;
                    }
                if (!TxtBoxPass.Text.Equals(TxtBoxPassRe.Text))
                {
                    WarningMBox.ShowMBox("Please Re-type your password correctly.");
                    return;
                }
                if (TxtBoxPass.Text.Length < 8)
                {
                    WarningMBox.ShowMBox("Your password's length cannot be less than 8 characters");
                    return;
                }
            }
            var person = new Person()
            {
                Name = TxtBoxFname.Text,
                LastName = TxtBoxLname.Text,
                Email = TxtBoxEmail.Text.Trim(),
                SSN = TxtBoxSSN.Text.Trim(),
                IsDeleted = false,
                AccountObj = new Account()
                {
                    UserName = HashedData.HashUserPass(TxtBoxUser.Text.Trim(), TxtBoxPass.Text.Trim(), out string password),
                    Password = password
                }
            };
            uow.RepositoryPerson.Insert(person);
            uow.Save();
            InfoMBox.ShowMBox("You have been registered successfully.");
            this.Close();
        }

        private void ChkBoxShowPass_CheckedChanged(object sender, System.EventArgs e)
        {
            TxtBoxPass.UseSystemPasswordChar = !ChkBoxShowPass.Checked;
            TxtBoxPassRe.UseSystemPasswordChar = !ChkBoxShowPass.Checked;
        }
    }
}
