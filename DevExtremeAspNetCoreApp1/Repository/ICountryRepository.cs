using DevExtremeAspNetCoreApp1.Models;
using DevExtremeAspNetCoreApp1.DTO;
namespace DevExtremeAspNetCoreApp1.Repository
{
    public interface ICountryRepository
    {
        public List<Country> GetAll();
        public void AddCountry(CountryDTO country);
        

    }
}
