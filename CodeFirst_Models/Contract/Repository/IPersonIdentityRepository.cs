using CodeFirst_Models.Abstract;

namespace CodeFirst_Models.Contract.Repository
{
    /// <summary>
    /// Methods for entities having PersonID
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IPersonIdentityRepository<T> : IRepository<T> where T : BaseEntityPersonIdentity
    {
        /// <summary>
        /// Delete By personID
        /// </summary>
        /// <param name="personID">ID</param>
        void DeleteByPersonID(int personID);

        /// <summary>
        /// Select By personID
        /// </summary>
        /// <param name="personID">ID</param>
        /// <returns></returns>
        T GetByPersonID(int personID);
    }
}
