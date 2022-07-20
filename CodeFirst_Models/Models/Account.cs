using CodeFirst_Models.Abstract;

namespace CodeFirst_Models.Models
{
    public class Account : BaseEntityPersonIdentity
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        public virtual Person PersonObject { get; set; }

        public Account()
        {

        }
    }
}
