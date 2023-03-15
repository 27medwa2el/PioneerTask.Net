using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using DevExtremeAspNetCoreApp1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace DevExtreme.AspNet.Mvc.Controllers.ApiControllers
{
    public class DataGridCitiesByCountryController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DataGridCitiesByCountryController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [HttpGet]
        public async Task<IActionResult> Get(DataSourceLoadOptions loadOptions, int? countryId)
        {


            var query = _context.Cities.AsQueryable();

            if (loadOptions.Filter != null && loadOptions.Filter.Count > 2 && (string)loadOptions.Filter[0] == "CountryId")
            {
                if (int.TryParse(loadOptions.Filter[2].ToString(), out int id))
                {
                    query = query.Where(a => a.CountryId == id);
                    return Json(await DataSourceLoader.LoadAsync(query, loadOptions));

                }
                else
                {
                    return Json(await DataSourceLoader.LoadAsync(query, loadOptions));
                    // handle invalid filter value
                }
            }
            return Json(await DataSourceLoader.LoadAsync(query, loadOptions)); 






        }
    }
}
