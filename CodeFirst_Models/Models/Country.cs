using CodeFirst_Models.Abstract;
using System.Collections.Generic;

namespace CodeFirst_Models.Models
{
    public class Country : BaseEntityIdentity
    {
        public string CountryName { get; set; }

        public virtual ICollection<Gun> GunListObj { get; }

        public Country()
        {
            GunListObj = new List<Gun>();
        }

    }
}
