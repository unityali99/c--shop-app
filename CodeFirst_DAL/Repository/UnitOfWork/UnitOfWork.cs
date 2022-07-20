using CodeFirst_DAL.Repository.Contract;
using CodeFirst_DAL.Repository.Entity;
using CodeFirst_Models.Contract.Entity;

namespace CodeFirst_DAL.Repository.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        // همینجوری
        // برای آینده
        //https://docs.microsoft.com/en-us/aspnet/mvc/overview/older-versions/getting-started-with-ef-5-using-mvc-4/implementing-the-repository-and-unit-of-work-patterns-in-an-asp-net-mvc-application


        private MyContext _ctx;

        public UnitOfWork()
        {

        }

        /// <summary>
        /// شروع کانتکست از یونیت آو ورک
        /// </summary>
        public MyContext Ctx
        {
            get
            {
                //مطمئن میشویم که فقط یک آبجکت از کلاس کانتکست وجود دارد
                // و هر بار که سراغ کانتکست میرویم یک آبجکت جدید به ما تحویل داده نمیشود
                if (_ctx == null)
                    _ctx = new MyContext();
                return _ctx;
            }
        }

        private IRepositoryPerson _repositoryPerson;
        private IRepositoryAccount _repositoryAccount;
        private IRepositoryGun _repositoryGun;
        private IRepositoryCategory _repositoryCategory;
        private IRepositoryFireMode _repositoryFireMode;
        private IRepositoryCountry _repositoryCountry;
        private IRepositoryOrder _repositoryOrder;
        private IRepositoryOrderDetails _repositoryOrderDetails;



        public IRepositoryPerson RepositoryPerson
        {
            get
            {
                if (_repositoryPerson == null)
                    _repositoryPerson = new PersonRepository(Ctx);
                return _repositoryPerson;
            }
        }

        public IRepositoryAccount RepositoryAccount
        {
            get
            {
                if (_repositoryAccount == null)
                    _repositoryAccount = new AccountRepository(Ctx);
                return _repositoryAccount;
            }
        }

        public IRepositoryGun RepositoryGun
        {
            get
            {
                if (_repositoryGun == null)
                    _repositoryGun = new GunRepository(Ctx);
                return _repositoryGun;
            }
        }

        public IRepositoryCategory RepositoryCategory
        {
            get
            {
                if (_repositoryCategory == null)
                    _repositoryCategory = new CategoryRepository(Ctx);
                return _repositoryCategory;
            }
        }

        public IRepositoryFireMode RepositoryFireMode
        {
            get
            {
                if (_repositoryFireMode == null)
                    _repositoryFireMode = new FireModeRepository(Ctx);
                return _repositoryFireMode;
            }
        }

        public IRepositoryCountry RepositoryCountry
        {
            get
            {
                if (_repositoryCountry == null)
                    _repositoryCountry = new CountryRepository(Ctx);
                return _repositoryCountry;
            }
        }

        public IRepositoryOrder RepositoryOrder
        {
            get
            {
                if (_repositoryOrder == null)
                    _repositoryOrder = new OrderRepository(Ctx);
                return _repositoryOrder;
            }
        }

        public IRepositoryOrderDetails RepositoryOrderDetails
        {
            get
            {
                if (_repositoryOrderDetails == null)
                    _repositoryOrderDetails = new OrderDetailsRepository(Ctx);
                return _repositoryOrderDetails;
            }
        }


        public void Dispose()
        {
            Ctx.Dispose();
        }

        public void Save()
        {
            Ctx.SaveChanges();
        }

    }
}
