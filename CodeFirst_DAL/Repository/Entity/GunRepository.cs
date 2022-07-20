using CodeFirst_DAL.Repository.Base;
using CodeFirst_Models.Contract.Entity;
using CodeFirst_Models.Models;

namespace CodeFirst_DAL.Repository.Entity
{
    public class GunRepository : IdentityRepository<Gun>, IRepositoryGun
    {
        public GunRepository(MyContext ctx) : base(ctx)
        {

        }
    }
}
