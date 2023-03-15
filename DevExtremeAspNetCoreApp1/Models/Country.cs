using System.ComponentModel.DataAnnotations;

namespace  DevExtremeAspNetCoreApp1.Models
{
    public class Country
    {
        public int CountryId { get; set; }
        [Required]
        public string CountryName { get; set; }
        public virtual List<Customer> Customers { get; set; } = new List<Customer>();
        public virtual List<City> Cities { get; set; } = new List<City>();
    }
}
