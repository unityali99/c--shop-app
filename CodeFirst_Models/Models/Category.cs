using CodeFirst_Models.Abstract;
using System.Collections.Generic;

namespace CodeFirst_Models.Models
{
    public class Category : BaseEntityIdentity
    {
        public string Type { get; set; }

        public virtual ICollection<Gun> GunListObj { get; }

        public Category()
        {
            GunListObj = new List<Gun>();
        }
    }
}
