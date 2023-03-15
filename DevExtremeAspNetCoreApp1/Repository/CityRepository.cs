using DevExtremeAspNetCoreApp1.Models;
    
namespace  DevExtremeAspNetCoreApp1.Repository
{
    public class CityRepository:ICityRepository
    {
        private ApplicationDbContext db;

        public CityRepository(ApplicationDbContext db)
        {
            this.db = db;
        }
        public List<City> GetCityByCountry(int countryID)
        {
            var response = db.Cities.Where(a => a.CountryId == countryID).ToList();
            return response;
        }
        public List<City> GetAll()
        {
            return db.Cities.ToList();
        }
    }
}
