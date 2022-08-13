using Xunit;
using Xunit.Sdk;
using Moq;
using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using FireLibrary2.Models;
using FireLibrary2.Controllers;
using FireLibrary2.Data;
using Microsoft.AspNetCore.Mvc;

namespace FireLibrary.Test;

public class CustomerControllerTest
{
    [Fact]
    public async Task GetCustomer_Input_Result()
    {
        Customer customer = new Customer();
        customer.BookCount = 150;
        customer.CanBorrow = true;
        customer.CustomerId = 12345;
        customer.Username = "username";
        customer.Fines = 20;

        var ser = JsonSerializer.Serialize(customer);

        System.Console.WriteLine(ser);

        //string jsonShouldbe = @"{""CustomerId"":12345,""Username"":""username"",""CanBorrow"":true,""Fines"":20,""BookCount"":150,""Orders"":null}";
        //Console.WriteLine(jsonShouldbe);

        var mockRepo = new Mock<DbSet<Customer>>();
        
        mockRepo.Setup(repo => repo.FindAsync(12345)).ReturnsAsync(customer);
  

        Mock<DataContext> mockContext = new();
        mockContext.Setup(a => a.Customers).Returns(mockRepo.Object);
        var cus = new CustomersController(mockContext.Object);

        var result = await cus.GetCustomer(12345);

        var resultContent = (ActionResult)result.Result;
       
        if(resultContent == null)
        {
            Console.WriteLine("Result Content is NULL");
        }
        var item = result.Value;
        Customer customer1 = item as Customer;

        Assert.Equal(customer, customer1);
    }
    //*********************************************************************************************************************
    //[Fact]
    //public async Task PostCustomer_Input_Result()
    //{
    //    Customer customer = new Customer();
    //    customer.BookCount = 150;
    //    customer.CanBorrow = true;
    //    customer.CustomerId = 12345;
    //    customer.Username = "username";
    //    customer.Fines = 20;

    //    var ser = JsonSerializer.Serialize(customer);

    //    System.Console.WriteLine(ser);

    //    //string jsonShouldbe = @"{""CustomerId"":12345,""Username"":""username"",""CanBorrow"":true,""Fines"":20,""BookCount"":150,""Orders"":null}";
    //    //Console.WriteLine(jsonShouldbe);

    //    var mockRepo = new Mock<DbSet<Customer>>();

    //    mockRepo.Setup(repo => repo.Add(customer));


    //    Mock<DataContext> mockContext = new();
    //    mockContext.Setup(a => a.Customers).Returns(mockRepo.Object);
    //    var cus = new CustomersController(mockContext.Object);

    //    var result = await cus.PostCustomer(customer);

    //    var resultContent = (ActionResult)result.Result;

    //    if (resultContent == null)
    //    {
    //        Console.WriteLine("Result Content is NULL");
    //    }
    //    var item = result.Value;
    //    Customer customer1 = item as Customer;

    //    Assert.Equal(customer, customer1);
    //}
    //*********************************************************************************************************************
    //[Fact]
    //public async Task PutCustomer_Input_Result()
    //{
    //    Customer customer = new Customer();
    //    customer.BookCount = 150;
    //    customer.CanBorrow = true;
    //    customer.CustomerId = 12345;
    //    customer.Username = "username";
    //    customer.Fines = 20;

    //    var ser = JsonSerializer.Serialize(customer);

    //    System.Console.WriteLine(ser);

    //    //string jsonShouldbe = @"{""CustomerId"":12345,""Username"":""username"",""CanBorrow"":true,""Fines"":20,""BookCount"":150,""Orders"":null}";
    //    //Console.WriteLine(jsonShouldbe);

    //    var mockRepo = new Mock<DbSet<Customer>>();
    //    mockRepo.Setup(b => b.SetModified(It.IsAny()));

    //    mockRepo.Setup(repo => repo.Add(customer));


    //    Mock<DataContext> mockContext = new();
    //    mockContext.Setup(a => a.Customers).Returns(mockRepo.Object);
    //    var cus = new CustomersController(mockContext.Object);

    //    var result = await cus.PutCustomer(12345, customer);

    //    //var resultContent = (ActionResult)result.Result;

    //    //if (resultContent == null)
    //    //{
    //    //    Console.WriteLine("Result Content is NULL");
    //    //}
    //    //var item = result.Value;
    //    //Customer customer1 = item as Customer;

    //    Assert.IsType<NoContentResult>(result);
    //}
}
