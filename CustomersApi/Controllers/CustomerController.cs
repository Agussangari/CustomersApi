using Microsoft.AspNetCore.Mvc;
using CustomersApi.dtos;

namespace CustomersApi.Controllers
{
    [ApiController]

    [Route("api/[controller]")]
    
    public class CustomerController : Controller
    {
        //api//customer
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(CustomerDto))]

        //public async Task<List<CustomerDto>> GetCustomers()
        public async Task<ActionResult> GetCustomers()
        {
            throw new NotImplementedException();
        }

        //api//customer/{id}
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type=typeof(CustomerDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        ///public async Task<CustomerDto> GetCustomer(long id)
        public async Task<IActionResult> GetCustomer(long id)
        {
            var vacio = new CustomerDto();

            return new OkObjectResult(vacio);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(bool))]
        public async Task<bool> DeleteCustomer(long id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(CustomerDto))]

        public async Task<IActionResult> CreateCustomer(CreateCustomerDto customer)
        {
            var vacio = new CustomerDto();

            return new CreatedResult($"http://localhost:7263/api/customer/{vacio.Id}", null);
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(CustomerDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]


        public async Task<ActionResult> UpdateCustomer(CustomerDto customer)
        {
            throw new NotImplementedException();
        }

    }
}
