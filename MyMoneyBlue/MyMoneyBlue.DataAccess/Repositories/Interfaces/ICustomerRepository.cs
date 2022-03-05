using MyMoneyBlue.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMoneyBlue.DataAccess.Repositories.Interfaces
{
    public interface ICustomerRepository : IGenericRepository<Customer>
    {
        Task<List<Customer>>GetAllCustomerAsync();
        Task<Customer> GetCustomerByIdAsync(string Id);
       // Task <Customer>SaveCustomerAsync(string id);
        Task<Customer> Create(Customer customer);
    }
}
