using CodeFirst_DAL.Repository.UnitOfWork;
using CodeFirst_Models.Models;
using CustomMBoxes.InfoMBox;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class FrmEditInfo : Form
    {
        Person person = null;
        UnitOfWork uow = null;
        public FrmEditInfo(Person getPerson, UnitOfWork localUow)
        {
            person = getPerson;
            uow = localUow;
            InitializeComponent();
        }

        private void FrmEditInfo_Load(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.None;
            TxtBoxFname.Text = person.Name.Trim();
            TxtBoxLname.Text = person.LastName.Trim();
            TxtBoxSSN.Text = person.SSN.Trim();
            TxtBoxEmail.Text = person.Email.Trim();
        }

        private void BtnClose_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void BtnEdit_Click(object sender, System.EventArgs e)
        {
            foreach (Control item in GrpBoxPerson.Controls)
            {
                if (item is TextBox)
                    if (item.Text.Trim() == string.Empty || item.Text.Trim().Length < 2 || TxtBoxSSN.Text.Trim().Length != 10 || !(TxtBoxEmail.Text.Contains("@")))
                    {
                        WarningMBox.ShowMBox("Please fill out all of the boxes correctly.");
                        return;
                    }
            }
            person.Name = TxtBoxFname.Text.Trim();
            person.LastName = TxtBoxLname.Text.Trim();
            person.Email = TxtBoxEmail.Text.Trim();
            person.SSN = TxtBoxSSN.Text.Trim();

            uow.RepositoryPerson.Update(person);
            uow.Save();
            this.DialogResult = DialogResult.OK;
            InfoMBox.ShowMBox("Your information has been edited successfully");
            this.Close();
        }
    }
}
