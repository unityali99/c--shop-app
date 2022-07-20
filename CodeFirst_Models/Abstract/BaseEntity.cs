using CodeFirst_Models.Contract.Base;
using System;

namespace CodeFirst_Models.Abstract
{
    /// <summary>
    /// The father of all entities
    /// </summary>
    public abstract class BaseEntity : IModification
    {
        public DateTime InsertDateTime { get; set; }
        public DateTime UpdateDateTime { get; set; }
        public bool IsDeleted { get; set; }
    }
}
