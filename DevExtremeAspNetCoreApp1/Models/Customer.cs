using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace  DevExtremeAspNetCoreApp1.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        
        public int CityId { get; set; }
        
        public int CountryId { get; set; }
        [ForeignKey("CityId")]
        public virtual City city { get; set; }
        [ForeignKey("CountryId")]
        public virtual Country country { get; set; }
    }
}
