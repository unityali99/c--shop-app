using CodeFirst_Models.Abstract;
using System.Collections.Generic;

namespace CodeFirst_Models.Models
{
    public class FireMode : BaseEntityIdentity
    {
        public string Mode { get; set; }

        public virtual ICollection<Gun> GunListObj { get; }

        public FireMode()
        {
            GunListObj = new List<Gun>();
        }
    }
}
