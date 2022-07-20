using CodeFirst_DAL.Repository.Base;
using CodeFirst_Models.Contract.Entity;
using CodeFirst_Models.Models;

namespace CodeFirst_DAL.Repository.Entity
{
    public class AccountRepository : PersonIdentityRepository<Account>, IRepositoryAccount
    {
        public AccountRepository(MyContext ctx) : base(ctx)
        {

        }
    }
}
