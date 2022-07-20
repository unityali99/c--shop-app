using System;

namespace CodeFirst_Models.Contract.Base
{
    interface IModification
    {
        /// <summary>
        /// The time when the record is inserted
        /// </summary>
        DateTime InsertDateTime { get; set; }
        /// <summary>
        /// The time when the record is updated
        /// </summary>
        DateTime UpdateDateTime { get; set; }
        /// <summary>
        /// Indicates whether the record is logically deleted
        /// </summary>
        bool IsDeleted { get; set; }
    }
}
