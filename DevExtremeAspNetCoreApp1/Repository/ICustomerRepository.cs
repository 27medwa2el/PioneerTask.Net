using Microsoft.AspNetCore.Mvc;
using  DevExtremeAspNetCoreApp1.DTO;
using  DevExtremeAspNetCoreApp1.Models;

namespace  DevExtremeAspNetCoreApp1.Repository
{
    public interface ICustomerRepository
    {
        public void AddCustomer(CustomerDTO customer);
        public List<Customer> GetAll();
       
    }
}
