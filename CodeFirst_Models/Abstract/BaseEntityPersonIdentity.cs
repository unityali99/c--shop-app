using CodeFirst_Models.Contract.Base;

namespace CodeFirst_Models.Abstract
{
    /// <summary>
    /// The base class for PersonID needed entities 
    /// </summary>
    public abstract class BaseEntityPersonIdentity : BaseEntity, IBaseEntityPersonIdentity
    {
        public int PersonID { get; set; }
    }
}
