using CodeFirst_Models.Abstract;

namespace CodeFirst_Models.Contract.Repository
{
    /// <summary>
    /// Methods for entities having ID
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IIdentityRepository<T> : IRepository<T> where T : BaseEntityIdentity
    {
        /// <summary>
        /// Delete By ID
        /// </summary>
        /// <param name="id">ID</param>
        void DeleteByID(int id);

        /// <summary>
        /// Select By ID
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        T GetByID(int id);
    }
}
