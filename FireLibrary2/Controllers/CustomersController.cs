using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FireLibrary2.DTOs;
using FireLibrary2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace FireLibrary2.Controllers
{
    [Route("api/Customer")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly DataContext _context;

        public CustomersController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Customers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CustomerDTO>>> GetCustomers()
        {
            if (_context.Customers == null)
            {
                return NotFound();
            }

            List<CustomerDTO> result = new();
            var customers = await _context.Customers.ToListAsync();

            foreach (Customer customer in customers)
            {
                result.Add(CustomerDTO.CreateCustomerDTO(customer));
            }

            return Ok(result);
        }

        // GET: api/Customers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CustomerDTO>> GetCustomer(int id)
        {
            if (_context.Customers == null)
            {
                return NotFound();
            }
            Customer customer = await _context.Customers.FindAsync(id);

            if (customer == null)
            {
                return NotFound();
            }

            CustomerDTO result = CustomerDTO.CreateCustomerDTO(customer);

            return Ok(result);
        }

        //Get all orders for customer
        [HttpGet("Orders")]
        public async Task<ActionResult<IEnumerable<OrderDTO>>> GetCustomerOrders(int customerId)
        {
            //List of orders models from DB used to create the OrderDTO list for frontend
            List<Order> orders = new List<Order>();
            //List of OrderDTO's to send to front end
            List<OrderDTO> results = new List<OrderDTO>();

            //Gets list of orders from DB, serializes them right into orders list
            orders = await _context.Orders.Where(o => o.CustomerId == customerId).ToListAsync();

            //_logger.LogInformation(orders.Count().ToString());

            if (!orders.Any())
            {
                return Ok("You have no orders yet!");
            }

            foreach (Order i in orders)
            {
                //Creates a temp orderDTO to then populate and be added to results list of orderDTOs to send off
                OrderDTO tempOrder = new OrderDTO();
                //Populates the temp orderDTO object
                tempOrder.orderId = i.OrderId;
                tempOrder.CustomerId = i.CustomerId;
                tempOrder.DateLent = i.DateLent;
                tempOrder.DateDue = i.DateDue;

                //Books must be converted from Book (model) to BookDTO
                List<BookDTO> bookDTOs = new();

                bookDTOs = BookDTO.CreateBookDTOs(i);

                tempOrder.Books = bookDTOs;

                //Adds tempOrder OrderDTO to list of OrderDTOs to send back
                results.Add(tempOrder);
            }

            return Ok(results);
        }

        // PUT: api/Customers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPatch("{id}")]
        public async Task<IActionResult> UpdateCustomer(CustomerDTO request)
        {
            if (!CustomerExists(request.CustomerId))
            {
                return BadRequest();
            }

            var customer = await _context.Customers.FirstAsync(cust => cust.Username == request.Username);

            customer.Fines = request.Fines;
            customer.CanBorrow = request.Canborrow;
            customer.BookCount = request.BookCount;

            _context.Entry(customer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CustomerExists(request.CustomerId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }




        private bool CustomerExists(int id)
        {
            return (_context.Customers?.Any(e => e.CustomerId == id)).GetValueOrDefault();
        }
    }
}

