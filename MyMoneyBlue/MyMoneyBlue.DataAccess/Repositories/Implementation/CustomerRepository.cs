using Microsoft.EntityFrameworkCore;
using MyMoneyBlue.DataAccess.Repositories.Interfaces;
using MyMoneyBlue.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMoneyBlue.DataAccess.Repositories.Implementation
{
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        private readonly MyMoneyBlueDbContext _dbContext;
        public CustomerRepository(MyMoneyBlueDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;

        }
        public async Task<List<Customer>> GetAllCustomerAsync()
        {
            return await _dbContext.Customers.ToListAsync();
                                  
        }

        public async Task<Customer> GetCustomerByIdAsync(string Id)
        {
            return await _dbContext.Customers
                                      .FirstOrDefaultAsync(x => x.Id == Id);
        }

        public async Task<Customer> Create(Customer customer)
        {
           
                _dbContext.Customers.Add(customer);
                await _dbContext.SaveChangesAsync();

                return customer;
        }

    }
    
}
