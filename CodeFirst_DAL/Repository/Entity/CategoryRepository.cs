using CodeFirst_DAL.Repository.Base;
using CodeFirst_Models.Contract.Entity;
using CodeFirst_Models.Models;

namespace CodeFirst_DAL.Repository.Entity
{
    public class CategoryRepository : IdentityRepository<Category>, IRepositoryCategory
    {
        public CategoryRepository(MyContext ctx) : base(ctx)
        {

        }
    }
}
