using CodeFirst_Models.Abstract;
using CodeFirst_Models.Contract.Repository;
using System;

namespace CodeFirst_DAL.Repository.Base
{
    /// <summary>
    /// The base class for PersonID needed entities
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class PersonIdentityRepository<T> : Repository<T>, IPersonIdentityRepository<T> where T : BaseEntityPersonIdentity
    {
        public PersonIdentityRepository(MyContext ctx) : base(ctx)
        {

        }

        public void DeleteByPersonID(int personID)
        {
            var obj = GetByPersonID(personID);
            if (obj == null)
                throw new ArgumentNullException("");
            Delete(obj);
        }

        public T GetByPersonID(int personID)
        {
            return MainSet.Find(personID);
        }
    }
}
