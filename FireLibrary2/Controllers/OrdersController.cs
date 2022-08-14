using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FireLibrary2.Models;
using FireLibrary2.DTOs;

namespace FireLibrary2.Controllers
{
    [Route("api/Orders")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly DataContext _context;

        public OrderController(DataContext context)
        {
            _context = context;
        }



        [HttpPost] //takes an order DTO, creates an order.
        public async Task<ActionResult<string>> PostOrder(OrderDTO request)
        {
            //checks if the table is still there
            if (_context.Orders == null)
            {
                return Problem("Entity set 'DataContext.Orders'  is null.");
            }

            //New Order to insert into DB
            var order = new Order();
            var books = new List<Book>();
            //Finds customer that came in from the OrderDTO customerID, returns its Customer Model from the DB
            var customer = await _context.Customers.FirstAsync(cust => cust.CustomerId == request.CustomerId);

            //checking if order would put user over 10 borrowed books
            if ((customer.BookCount + request.Books.Count()) > 10)
            {
                return Problem($"You are borrowing {customer.BookCount}/10 alloted books. Please alter your cart and try again!");
            }

            //checking to see if there are duplicate books on the order
            if (request.Books.Count() != request.Books.Distinct().Count())
            {
                return Problem("Please remove duplicates from order.");
            }

            //Sets customerId of new order to the CustomerId that came in from the DTO
            order.CustomerId = request.CustomerId;

            //Puts book found in BookDTO list into a list of book models stored in the object model,
            //to then send to database. Additionally, it updates the books and decrements
            //the available copies by 1.
            foreach (BookDTO i in request.Books)
            {
                //finds book in DB
                var book = await _context.Books.FindAsync(i.Isbn);

                //Makes sure there are availble copies of the book
                if (book.AvalableCopies == 0)
                {
                    return Problem($"{book.Title} is currently unavailable, sorry about that!");
                }


                //Adds the book to the List<Book> that we will insert into the new order
                books.Add(book);
            }

            //Populating the Order model
            order.Books = books;
            order.DateLent = DateTime.Now;
            order.DateDue = order.DateLent.AddDays(14);

            //incrementing customer bookcount           
            customer.BookCount += order.Books.Count();

            //Adding the order model, updating the customer 
            _context.Orders.Add(order);
            _context.Customers.Update(customer);

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {

            }

            return Ok();
        }

        [HttpGet] //gets a specific order
        public async Task<ActionResult<OrderDTO>> GetOrder(int id)
        {
            //Checking if db is still there
            if (_context.Orders == null)
            {
                return NotFound();
            }

            Order order = await _context.Orders.Include(o => o.Books).FirstAsync(o => o.OrderId == id);


            OrderDTO result = new OrderDTO();

            result.orderId = order.OrderId;

            List<BookDTO> bookDTOs = new();

            bookDTOs = BookDTO.CreateBookDTOs(order);

            result.Books = bookDTOs;

            return Ok(result);

        }

        [HttpPost("return/{id}")]
        public async Task<ActionResult> ReturnBooks(OrderDTO request)
        {
            //checks if the table is still there
            if (_context.Orders == null)
            {
                return Problem("Entity set 'DataContext.Orders'  is null.");
            }

            //Count of returned books
            int count = 0;
            //Get the actual order from the DB
            Order order = await _context.Orders.FindAsync(request.orderId);
            //Get custtomer who's order it is
            Customer customer = await _context.Customers.FindAsync(order.CustomerId);
            //Cant remove entries in a foreach loop
            List<Book> booksToRemove = new();

            foreach (var i in order.Books)
            {
                //Adds an available copy to the book object in the DB
                i.AvalableCopies += 1;
                //Removes a book from the customer's BookCount 
                customer.BookCount -= 1;
                //Stages changes to the DB, updating the returned book in the DB to reflect the additional copy available
                _context.Books.Update(i);
                //increments the count
                count += 1;
                booksToRemove.Add(i);
            }

            //Removing books to remove from the order book list
            order.Books = order.Books.Except(booksToRemove).ToList();

            //Stages changes to order and customer to DB
            _context.Orders.Update(order);
            _context.Customers.Update(customer);

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {

            }

            //Returns 200OK along with returned book count. 
            return Ok($"You have returned {count} books!");
        }

    }
}