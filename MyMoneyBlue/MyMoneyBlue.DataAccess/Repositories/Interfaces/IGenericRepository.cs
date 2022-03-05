using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMoneyBlue.DataAccess.Repositories.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task AddAsync(T data);
        void AddRange(ICollection<T> data);
        void Attach(T data);
        void Delete(T data);
        void Update(T data);
    }
}
