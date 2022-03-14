using Microsoft.AspNetCore.Mvc;
using MyMoneyBlue.DataAccess.Repositories.Interfaces;
using MyMoneyBlue.Domain.Models;
using MyMoneyBlue.Services.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyMoneyBlue.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly ICustomerService _customerService;
        private readonly ILogger<CustomerController> _logger;

        public CustomerController(ICustomerRepository customerRepository,
            ICustomerService customerService, ILogger<CustomerController> logger)
        {
            _customerRepository = customerRepository;
            _customerService = customerService;
            _logger = logger;
        }
        // GET: api/<CustomerController>
        [HttpGet]
        public async Task<IEnumerable<Customer>> GetAllCustomerAsync()
        {
            var customer = await _customerRepository.GetAllCustomerAsync();
            return customer;
        }

        // GET api/<CustomerController>
        [HttpGet("{id}")]
        public async Task<ActionResult<Customer>> GetCustomerByIdAysnc(string Id)
        {
            var customer = await _customerService.GetCustomerByIdAsync(Id);
            if (customer is null)
                return NotFound();
            return Ok(customer);

        }

        // POST api/<CustomerController>
        [HttpPost]
        public async Task<ActionResult<Customer>> AddCustomer([FromBody] Customer customer)
        {
            var newCustomer = await _customerService.AddCustomer(customer);
            return CreatedAtAction(nameof(AddCustomer), new { id = newCustomer.Id }, newCustomer);
        }
      
        // PUT api/<CustomerController>/5



    }
}
