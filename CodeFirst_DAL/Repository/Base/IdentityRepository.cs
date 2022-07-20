using CodeFirst_Models.Abstract;
using CodeFirst_Models.Contract.Repository;
using System;

namespace CodeFirst_DAL.Repository.Base
{
    /// <summary>
    /// The base class for ID needed entities
    /// </summary>
    public abstract class IdentityRepository<T> : Repository<T>, IIdentityRepository<T> where T : BaseEntityIdentity
    {
        public IdentityRepository(MyContext context) : base(context)
        {

        }

        public T GetByID(int id)
        {
            return MainSet.Find(id);
        }

        public void DeleteByID(int id)
        {
            var obj = GetByID(id);

            if (obj == null)
            {
                throw new ArgumentNullException("");
            }

            Delete(obj);

        }
    }

}
