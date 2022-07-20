using CodeFirst_Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace CodeFirst_Models.Contract.Repository
{
    /// <summary>
    /// Very general methods for all entities
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<T> where T : BaseEntity
    {
        /// <summary>
        /// Insert Method
        /// </summary>
        void Insert(T entity);

        /// <summary>
        /// Update Method
        /// </summary>
        void Update(T entity);

        /// <summary>
        /// Delete Method
        /// </summary>
        void Delete(T entity);

        /// <summary>
        /// Selecting NOT deleted informations
        /// </summary>
        /// <returns></returns>
        IQueryable<T> Get();

        /// <summary>
        /// واکشی اطلاعات با گزاره
        /// </summary>
        /// <param name="predicate">گزاره</param>
        IQueryable<T> Get(Expression<Func<T, bool>> predicate);

        /// <summary>
        /// Select Informations by SQL Query
        /// </summary>
        /// <param name="query"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        IEnumerable<T> Get(string query, params object[] parameters);
    }
}
