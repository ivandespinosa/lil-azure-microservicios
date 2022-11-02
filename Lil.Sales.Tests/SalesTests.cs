using Lil.Sales.Controllers;
using Lil.Sales.DAL;
using Microsoft.AspNetCore.Mvc;

namespace Lil.Sales.Tests
{
    [TestClass]
    public class SalesTests
    {
        [TestMethod]
        public void GetAsyncReturnsOk()
        {
            SalesController salesController = new (new SalesProvider());
            var result = salesController.GetAsync("1").Result;

            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(OkObjectResult));
        }

        [TestMethod]
        public void GetAsyncReturnsNotFound()
        {
            SalesController salesController = new(new SalesProvider());
            var result = salesController.GetAsync("1000").Result;

            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(NotFoundResult));
        }
    }
}