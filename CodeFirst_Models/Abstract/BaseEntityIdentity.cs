using CodeFirst_Models.Contract.Base;

namespace CodeFirst_Models.Abstract
{
    /// <summary>
    /// The base class for ID needed entities
    /// </summary>
    public abstract class BaseEntityIdentity : BaseEntity, IBaseEntityIdentity
    {
        public int ID { get; set; }
    }
}
