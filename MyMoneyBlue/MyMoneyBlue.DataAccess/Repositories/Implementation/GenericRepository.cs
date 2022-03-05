using Microsoft.EntityFrameworkCore;
using MyMoneyBlue.DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMoneyBlue.DataAccess.Repositories.Implementation
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly MyMoneyBlueDbContext _dbContext;
        private readonly DbSet<T> _table;
        public GenericRepository(MyMoneyBlueDbContext dbContext)
        {
            _dbContext = dbContext;
            _table = _dbContext.Set<T>();
        }

        public async Task AddAsync(T data)
        {
            await _table.AddAsync(data);
        }

        public void Attach(T data)
        {
            _table.Attach(data);
            _dbContext.Entry(data).State = EntityState.Modified;
        }

        public void AddRange(ICollection<T> data)
        {
            _table.AddRange(data);
        }

        public void Delete(T data)
        {
            _table.Remove(data);
        }

        public void Update(T data)
        {
            _table.Update(data);
        }
    }
}
