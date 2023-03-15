using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using  DevExtremeAspNetCoreApp1.DTO;
using  DevExtremeAspNetCoreApp1.Models;

namespace  DevExtremeAspNetCoreApp1.Repository
{
    public class CustomerRepository:ICustomerRepository
    {
        private ApplicationDbContext _context;
        public CustomerRepository(ApplicationDbContext context)
        {
            this._context = context;
        }

        [HttpPost]
        public void AddCustomer(CustomerDTO customer)
        {
            Customer customerObg = new Customer { Name = customer.Name, Address = customer.Address, CityId = customer.CityID, CountryId = customer.CountryID, PhoneNumber = customer.PhoneNumber };
            _context.Customers.Add(customerObg);
            _context.SaveChanges();
        }
        public List<Customer> GetAll()
        {
            var response = _context.Customers.ToList();
            return response;
        }
       
    }
}
