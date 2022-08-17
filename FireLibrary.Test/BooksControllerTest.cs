using Xunit;
using Xunit.Sdk;
using Moq;
using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using FireLibrary2.Models;
using FireLibrary2.Controllers;
using FireLibrary2.Data;
using Microsoft.AspNetCore.Mvc;
using FireLibrary2.DTOs;
using Microsoft.Extensions.Logging;

namespace FireLibrary.Test
{
    public class BooksControllerTest
    {
        [Fact]
        public async Task GetBook_Input_Result()
        {
            BookDTO book = new BookDTO();
            book.Isbn = "12345";
            book.Pages = 200;
            book.TotalCopies = 5;
            book.AvalableCopies = 5;
            book.Genre = "Genre";

            Console.WriteLine("The Book test started");

            var ser = JsonSerializer.Serialize(book);

            Console.WriteLine(ser);



            Mock<ILogger<BooksController>> mockLogger = new();
            Mock<IRepository> mockRepo = new();

            mockRepo.Setup(repo => repo.GetBookAsync("12345")).ReturnsAsync(book);

            var cus = new BooksController(mockRepo.Object, mockLogger.Object);


            //var actionResult = await cus.GetCustomer(12345) as OkObjectResult;
            var result = await cus.GetBook("12345");

            var resultContent = result.Result as ContentResult;
            if (resultContent == null)
            {
                Console.WriteLine("Book Result Content is NULL");
            }

            var item = result.Value;

            var contentResult = result as ActionResult<BookDTO>;

            //var test = result.ToString() as CustomerDTO;
            //CustomerDTO cus1 = result.Value as CustomerDTO;

            Assert.Equal(book.Isbn, result.Value.Isbn);
            //Assert.IsType<OkObjectResult>(result.Result);
        }

        [Fact]
        public async Task GetBook_BadInput_Notfound()
        {
            BookDTO book = new BookDTO();
            book.Isbn = "12345";
            book.Pages = 200;
            book.TotalCopies = 5;
            book.AvalableCopies = 5;
            book.Genre = "Genre";

            //Console.WriteLine("The Book test started");

            var ser = JsonSerializer.Serialize(book);

            Console.WriteLine(ser);



            Mock<ILogger<BooksController>> mockLogger = new();
            Mock<IRepository> mockRepo = new();

            mockRepo.Setup(repo => repo.GetBookAsync("1234555")).ReturnsAsync(book);

            var cus = new BooksController(mockRepo.Object, mockLogger.Object);


            //var actionResult = await cus.GetCustomer(12345) as OkObjectResult;
            var result = await cus.GetBook("12345");

            var resultContent = result.Result as ContentResult;
            if (resultContent == null)
            {
                Console.WriteLine("Book Result Content is NULL");
            }

            var item = result.Value;

            var contentResult = result as ActionResult<BookDTO>;

            //var test = result.ToString() as CustomerDTO;
            //CustomerDTO cus1 = result.Value as CustomerDTO;

            Assert.IsType<NotFoundResult>(result.Result);
            //Assert.IsType<OkObjectResult>(result.Result);
        }


        [Fact]
        public async Task SearchBooksGenre_Input_Result()
        {
            List<BookDTO> book = new List<BookDTO>();
            book.Add(new BookDTO { Isbn = "12345", Genre = "genre" });
           
            //Console.WriteLine("The Book test started");

            var ser = JsonSerializer.Serialize(book);

            Console.WriteLine(ser);

            Mock<ILogger<BooksController>> mockLogger = new();
            Mock<IRepository> mockRepo = new();

            mockRepo.Setup(repo => repo.SearchBooksGenreAsync("genre")).ReturnsAsync(book);

            var cus = new BooksController(mockRepo.Object, mockLogger.Object);

            //var actionResult = await cus.GetCustomer(12345) as OkObjectResult;
            var result = await cus.SearchBooksGenre("genre");

            var resultContent = result.Result as ContentResult;
            if (resultContent == null)
            {
                Console.WriteLine("Book Result Content is NULL");
            }
            var item = result.Value;

            var contentResult = result as ActionResult<List<BookDTO>>;

            //var test = result.ToString() as CustomerDTO;
            //CustomerDTO cus1 = result.Value as CustomerDTO;

            Assert.IsType<OkObjectResult>(result.Result);
            //Assert.IsType<OkObjectResult>(result.Result);
          
        }
    }
}
