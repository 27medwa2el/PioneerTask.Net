using DevExtremeAspNetCoreApp1.Models;

namespace DevExtremeAspNetCoreApp1.Repository
{
    public interface ICityRepository
    {
        public List<City> GetCityByCountry(int countryID);
        public List<City> GetAll();
    }
}
