using CodeFirst_Models.Abstract;
using System.Collections.Generic;

namespace CodeFirst_Models.Models
{
    public class Gun : BaseEntityIdentity
    {
        public string Name { get; set; }

        public int Price { get; set; }

        public bool HasLicense { get; set; }

        public bool IsTested { get; set; }

        public int Quantity { get; set; }

        public int CategoryID { get; set; }

        public int FireModeID { get; set; }

        public string FullInfoURL { get; set; }

        public virtual Category CategoryObj { get; set; }

        public virtual FireMode FireModeObj { get; set; }

        public virtual ICollection<Country> CountryObj { get; set; }
        public virtual ICollection<OrderDetails> OrderDetailsObj { get; set; }
    }
}
