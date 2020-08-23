using Microsoft.AspNetCore.Mvc;

namespace MonkeyMeal.Customer.API.Controllers.Customer
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly CustomerDbContext _context;
        public CustomerController(CustomerDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        [Route("/api/customers")]
        public ActionResult Customers()
        {
            var customers = _context.Customer;
            if (customers != null)
            {
                return Ok(customers);
            }
            else
            {
                return Ok("Customer not exist");
            }
        }

        [HttpGet]
        [Route("/api/customerById")]
        public IActionResult CustomerById(int customerId)
        {
            return Ok("This is receive customer from Database");
        }
        [HttpPost]
        [Route("/api/savecustomer")]
        public ActionResult Save(string customer)
        {
            return Ok("Customer has been saved sucessfully");
        }
    }
}