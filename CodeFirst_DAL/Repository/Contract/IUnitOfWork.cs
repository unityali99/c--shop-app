using CodeFirst_Models.Contract.Entity;
using System;

namespace CodeFirst_DAL.Repository.Contract
{
    public interface IUnitOfWork : IDisposable
    {
        IRepositoryGun RepositoryGun { get; }

        IRepositoryAccount RepositoryAccount { get; }

        IRepositoryFireMode RepositoryFireMode { get; }

        IRepositoryCountry RepositoryCountry { get; }

        IRepositoryCategory RepositoryCategory { get; }

        IRepositoryOrder RepositoryOrder { get; }

        IRepositoryOrderDetails RepositoryOrderDetails { get; }

        IRepositoryPerson RepositoryPerson { get; }

        void Save();
    }
}
