using CodeFirst_Models.Abstract;
using CodeFirst_Models.Contract.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace CodeFirst_DAL.Repository.Base
{
    /// <summary>
    /// کلاس پایه برای متد های مستقل از کد و آیدی
    /// </summary>
    public abstract class Repository<T> : IRepository<T> where T : BaseEntity
    {
        /// <summary>
        /// کانتکس پروژه تعریف شده در کلاس ریپازیتوری اصلی
        /// </summary>
        protected MyContext MainContext { get; set; }


        protected DbSet<T> MainSet { get; set; }


        /// <summary>
        /// دریافت کانتکست از طریق سازنده کلاس
        /// تزریق وابستگی
        /// </summary>
        /// <param name="context"></param>
        public Repository(MyContext context)
        {
            if (context is null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            MainContext = context;
            MainSet = MainContext.Set<T>();
        }

        public virtual IQueryable<T> Get()
        {
            return MainSet.Where(x => !x.IsDeleted);
        }

        public virtual IQueryable<T> Get(Expression<Func<T, bool>> predicate)
        {
            return this.Get().Where(predicate);
        }

        public IEnumerable<T> Get(string query, params object[] parameters)
        {
            return MainSet.SqlQuery(query, parameters).Where(x => !x.IsDeleted).ToList();
        }

        public void Insert(T entity)
        {
            if (entity is null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            entity.InsertDateTime = DateTime.Now;
            entity.UpdateDateTime = DateTime.Now;

            MainSet.Add(entity);
        }

        public void Update(T entity)
        {
            if (entity is null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            entity.UpdateDateTime = DateTime.Now;
            MainContext.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(T entity)
        {
            if (entity is null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            entity.IsDeleted = true;
            entity.UpdateDateTime = DateTime.Now;
            MainContext.Entry(entity).State = EntityState.Modified;
        }
    }

}
