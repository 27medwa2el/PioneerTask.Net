using  DevExtremeAspNetCoreApp1.DTO;
using  DevExtremeAspNetCoreApp1.Models;
using DevExtremeAspNetCoreApp1 .Repository;

namespace  DevExtremeAspNetCoreApp1.Repository
{
    public class CountryRepository:ICountryRepository
    {
        private ApplicationDbContext db;

        public CountryRepository(ApplicationDbContext db) 
        {
          this.db = db;
        }
        public List<Country> GetAll()
        {
            return db.Countries.ToList();
        }
        public void AddCountry(CountryDTO country)
        {     
            Country country1 = new Country();
            country1.CountryName=country.Name;
            db.Countries.Add(country1);
        }
    }
}
