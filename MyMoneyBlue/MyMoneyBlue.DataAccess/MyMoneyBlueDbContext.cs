using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyMoneyBlue.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMoneyBlue.DataAccess
{
    public class MyMoneyBlueDbContext : DbContext
    {
        public MyMoneyBlueDbContext(DbContextOptions<MyMoneyBlueDbContext> options)
            : base(options) { }

        public DbSet<Customer> Customers { get; set; }
    }
}
