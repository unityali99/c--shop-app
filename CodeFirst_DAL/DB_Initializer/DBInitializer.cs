using Ali_Tools;
using CodeFirst_DAL.Repository.UnitOfWork;
using CodeFirst_Models.Models;
using System.Collections.Generic;
using System.Data.Entity;

namespace CodeFirst_DAL.DB_Initializer
{
    public class DBInitializer : CreateDatabaseIfNotExists<MyContext>
    {
        protected override void Seed(MyContext ctx)
        {

            UnitOfWork uow = new UnitOfWork();

            uow.RepositoryPerson.Insert(new Person()
            {
                Name = "Hosein",
                LastName = "Ahmadi",
                SSN = "025026",
                Email = "Hosein151275@gmail.com",
                AccountObj = new Account()
                {
                    UserName = HashedData.HashUserPass("Hosein", "025026", out string password),
                    Password = password
                }
            }
           );

            uow.RepositoryPerson.Insert(new Person()
            {
                Name = "Ali",
                LastName = "Ahmadi",
                SSN = "025021",
                Email = "ali1383@gmail.com",
                AccountObj = new Account()
                {
                    UserName = HashedData.HashUserPass("Ali", "025021", out string password2),
                    Password = password2
                }
            }
           );

            var cat = new Category() { Type = "Rifle" };

            var cat2 = new Category() { Type = "Pistol" };

            var cat3 = new Category() { Type = "All Items" };

            var fireMode = new FireMode() { Mode = "Auto" };

            var fireMode2 = new FireMode() { Mode = "Burst" };

            var fireMode3 = new FireMode() { Mode = "Single" };

            var country = new Country() { CountryName = "Iran" };

            var country2 = new Country() { CountryName = "Russia" };

            var country3 = new Country() { CountryName = "China" };

            var country4 = new Country() { CountryName = "NorthKorea" };

            var country5 = new Country() { CountryName = "U.S.A" };

            var country6 = new Country() { CountryName = "U.K" };

            var country7 = new Country() { CountryName = "Belgium" };

            var country8 = new Country() { CountryName = "Germany" };


            uow.RepositoryCategory.Insert(cat);
            uow.RepositoryCategory.Insert(cat2);
            uow.RepositoryCategory.Insert(cat3);
            uow.RepositoryFireMode.Insert(fireMode);
            uow.RepositoryFireMode.Insert(fireMode2);
            uow.RepositoryFireMode.Insert(fireMode3);
            uow.RepositoryCountry.Insert(country);
            uow.RepositoryCountry.Insert(country2);
            uow.RepositoryCountry.Insert(country3);
            uow.RepositoryCountry.Insert(country4);
            uow.RepositoryCountry.Insert(country5);
            uow.RepositoryCountry.Insert(country6);
            uow.RepositoryCountry.Insert(country7);
            uow.RepositoryGun.Insert(new Gun()
            {
                Name = "AK-74",
                HasLicense = true,
                Price = 750,
                IsTested = true,
                CategoryObj = cat,
                Quantity = 82,
                FullInfoURL = "https://military.wikia.org/wiki/Kalashnikov_AK-74",
                FireModeObj = fireMode,
                CountryObj = new List<Country>() { country, country2, country3, country4 }
            });

            uow.RepositoryGun.Insert(new Gun()
            {
                Name = "AK-47",
                HasLicense = true,
                Price = 700,
                IsTested = true,
                CategoryObj = cat,
                Quantity = 150,
                FullInfoURL = "https://military.wikia.org/wiki/Kalashnikov_AK-47",
                FireModeObj = fireMode,
                CountryObj = new List<Country>() { country, country2, country3, country4 }
            });

            uow.RepositoryGun.Insert(new Gun()
            {
                Name = "M4A1",
                HasLicense = true,
                Price = 830,
                IsTested = true,
                CategoryObj = cat,
                Quantity = 32,
                FullInfoURL = "https://www.military.com/equipment/m4-carbine",
                FireModeObj = fireMode,
                CountryObj = new List<Country>() { country5, country6 }
            }); ;

            uow.RepositoryGun.Insert(new Gun()
            {
                Name = "M16",
                HasLicense = true,
                Price = 750,
                IsTested = true,
                CategoryObj = cat,
                Quantity = 66,
                FullInfoURL = "https://www.military.com/equipment/m16a2-556-rifle",
                FireModeObj = fireMode,
                CountryObj = new List<Country>() { country5, country6 }
            });

            uow.RepositoryGun.Insert(new Gun()
            {
                Name = "Glock",
                HasLicense = true,
                Price = 590,
                IsTested = true,
                CategoryObj = cat2,
                Quantity = 94,
                FullInfoURL = "https://us.glock.com/en/Pistols",
                FireModeObj = fireMode,
                CountryObj = new List<Country>() { country5, country6, country }
            });

            uow.RepositoryGun.Insert(new Gun()
            {
                Name = "1911",
                HasLicense = true,
                Price = 886,
                IsTested = true,
                CategoryObj = cat2,
                Quantity = 56,
                FullInfoURL = "https://www.kimberamerica.com/pistols/1911",
                FireModeObj = fireMode3,
                CountryObj = new List<Country>() { country5 }
            });

            uow.RepositoryGun.Insert(new Gun()
            {
                Name = "FN-SCAR",
                HasLicense = true,
                Price = 964,
                IsTested = true,
                CategoryObj = cat,
                Quantity = 47,
                FullInfoURL = "https://en.wikipedia.org/wiki/FN_SCAR",
                FireModeObj = fireMode,
                CountryObj = new List<Country>() { country5, country7 }
            });

            uow.RepositoryGun.Insert(new Gun()
            {
                Name = "AR-15",
                HasLicense = true,
                Price = 450,
                IsTested = true,
                CategoryObj = cat,
                Quantity = 95,
                FullInfoURL = "https://en.wikipedia.org/wiki/AR-15_style_rifle",
                FireModeObj = fireMode,
                CountryObj = new List<Country>() { country5 }
            });

            uow.RepositoryGun.Insert(new Gun()
            {
                Name = "G36",
                HasLicense = true,
                Price = 795,
                IsTested = true,
                CategoryObj = cat,
                Quantity = 36,
                FullInfoURL = "https://en.wikipedia.org/wiki/Heckler_%26_Koch_G36",
                FireModeObj = fireMode,
                CountryObj = new List<Country>() { country8 }
            });

            uow.Save();

            base.Seed(ctx);
        }
    }
}
