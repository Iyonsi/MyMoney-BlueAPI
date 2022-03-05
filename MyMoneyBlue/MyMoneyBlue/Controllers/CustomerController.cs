using Microsoft.AspNetCore.Mvc;
using MyMoneyBlue.DataAccess.Repositories.Interfaces;
using MyMoneyBlue.Domain.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyMoneyBlue.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly ILogger<CustomerController> _logger;

        public CustomerController(ICustomerRepository customerRepository,
            ILogger<CustomerController> logger)
        {
            _customerRepository = customerRepository;
            _logger = logger;
        }
        // GET: api/<CustomerController>
        [HttpGet]
        public async Task<IEnumerable<Customer>> GetAllCustomerAsync()
        {
            var customer = await _customerRepository.GetAllCustomerAsync();
            return customer;
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Customer>> GetCustomerByIdAysnc(string Id)
        {
            var customer = await _customerRepository.GetCustomerByIdAsync(Id);
            if (customer is null)
                return NotFound();
            return Ok(customer);

        }

        // POST api/<CustomerController>
        [HttpPost]
        public async Task<ActionResult<Customer>> PostCustomer([FromBody] Customer customer)
        {
            var newcustomer = await _customerRepository.Create(customer);
            return CreatedAtAction(nameof(PostCustomer), new { id = newcustomer.Id }, newcustomer);
        }
      
        // PUT api/<CustomerController>/5



    }
}
