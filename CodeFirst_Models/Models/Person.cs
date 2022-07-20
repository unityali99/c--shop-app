using CodeFirst_Models.Abstract;
using System.Collections.Generic;

namespace CodeFirst_Models.Models
{
    public class Person : BaseEntityPersonIdentity
    {
        public string Name { get; set; }

        public string LastName { get; set; }

        public string SSN { get; set; }

        public string Email { get; set; }

        public string FullName { get; }

        // public DateTime BirthDate { get; set; }

        public ICollection<Order> OrderObj { get; set; }

        public virtual Account AccountObj { get; set; }

        public Person()
        {
            FullName = Name + " " + LastName;
            OrderObj = new List<Order>();
        }
    }
}
