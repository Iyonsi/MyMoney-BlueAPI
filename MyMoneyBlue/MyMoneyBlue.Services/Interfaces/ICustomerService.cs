using MyMoneyBlue.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMoneyBlue.Services.Interfaces
{
    public interface ICustomerService
    {
        Task<CustomerResponseDto> GetExpenseFormByIdAsync(string formId, string cacNumber);
        Task<IEnumerable<CustomerResponseDto>> GetAllCustomerAsync();
        Task<IEnumerable<CustomerResponseDto>> CreateCustomerAsync(CustomerResponseDto customerResponseDto);
  
    }
}
