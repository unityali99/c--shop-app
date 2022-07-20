using CodeFirst_DAL.Repository.UnitOfWork;
using CustomMBoxes.InfoMBox;
using System;
using System.Linq;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class FrmForgotPassword : Form
    {
        UnitOfWork uow = null;
        public FrmForgotPassword(UnitOfWork localUow)
        {
            uow = localUow;
            InitializeComponent();
        }

        private void ChkBoxRobot_CheckedChanged(object sender, EventArgs e)
        {
            BtnNext.Enabled = ChkBoxRobot.Checked;
        }

        private void FrmForgotPassword_Load(object sender, EventArgs e)
        {
            BtnNext.Enabled = false;
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (TxtBoxEmail.Text.Trim() == string.Empty || TxtBoxSSN.Text.Trim() == string.Empty)
            {
                WarningMBox.ShowMBox("Please fill out the forms correctly.");
                return;
            }

            if (TxtBoxSSN.Text.Trim().Length > 10)
            {
                WarningMBox.ShowMBox("Your SSN is not valid.");
                return;
            }

            if (!TxtBoxEmail.Text.Contains("@"))
            {
                WarningMBox.ShowMBox("Your E-Mail isn't valid.");
                return;
            }
            var person = uow.RepositoryPerson.Get(p => p.SSN.Equals(TxtBoxSSN.Text.Trim()) && p.Email.Equals(TxtBoxEmail.Text.Trim())).FirstOrDefault();

            if (person == null)
            {
                WarningMBox.ShowMBox("Invalid SSN / Email.");
                return;
            }
            FrmEditSec frmEditSec = new FrmEditSec(person, uow);
            frmEditSec.ShowDialog();
            this.Close();
        }
    }
}
