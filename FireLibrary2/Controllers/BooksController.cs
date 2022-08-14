using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FireLibrary2.DTOs;
using FireLibrary2.Models;

namespace FireLibrary2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly DataContext _context;

        public BooksController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Books
        [HttpGet]
        public async Task<ActionResult<List<BookDTO>>> GetBooks()
        {
            if (_context.Books == null)
            {
                return NotFound();
            }

            List<Book> books = await _context.Books.ToListAsync();
            List<BookDTO> result = new();

            result = BookDTO.CreateBookDTOs(books);

            if (books == null)
            {
                return NotFound();
            }

            return result;
        }

        // GET: api/Books/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BookDTO>> GetBook(string id)
        {
            if (_context.Books == null)
            {
                return NotFound();
            }
            var book = await _context.Books.FindAsync(id);
            BookDTO result = new();

            result = BookDTO.CreateBookDTO(book);

            if (book == null)
            {
                return NotFound();
            }

            return result;
        }

        [HttpGet("search/genre")]
        public async Task<ActionResult<List<BookDTO>>> SearchBooksGenre([FromQuery] string filter)
        {
            if (_context.Books == null)
            {
                return NotFound();
            }


            List<BookDTO> result = new List<BookDTO>();
            List<Book> books = new List<Book>();

            books = await _context.Books.Where(b => b.Genre.ToLower() == filter).ToListAsync();

            result = BookDTO.CreateBookDTOs(books);

            if (result == null)
            {
                return NotFound();
            }

            return result;
        }

        [HttpGet("search/author")]
        public async Task<ActionResult<List<BookDTO>>> SearchBooksAuthor([FromQuery] string filter)
        {
            if (_context.Books == null)
            {
                return NotFound();
            }


            List<BookDTO> result = new List<BookDTO>();
            List<Book> books = new List<Book>();

            books = await _context.Books.Where(b => b.AuthorName.ToLower() == filter).ToListAsync();

            result = BookDTO.CreateBookDTOs(books);

            if (result == null)
            {
                return NotFound();
            }

            return result;
        }

        [HttpGet("search/title")]
        public async Task<ActionResult<List<BookDTO>>> SearchBooks([FromQuery] string filter)
        {
            if (_context.Books == null)
            {
                return NotFound();
            }

            filter.ToLower();

            List<BookDTO> result = new List<BookDTO>();
            List<Book> books = new List<Book>();

            books = await _context.Books.Where(b => b.Title.ToLower() == filter).ToListAsync();

            result = BookDTO.CreateBookDTOs(books);

            if (result == null)
            {
                return NotFound();
            }

            return result;
        }

        private bool BookExists(string id)
        {
            return (_context.Books?.Any(e => e.Isbn == id)).GetValueOrDefault();
        }
    }
}
