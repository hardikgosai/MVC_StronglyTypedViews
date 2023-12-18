using Getri_StronglyTypedViews.Models;
using Microsoft.AspNetCore.Mvc;

namespace Getri_StronglyTypedViews.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            List<Customer> customers = new List<Customer>()
            {
                new Customer()
                {
                    CustId = 1,
                    CustName = "John",
                    CustAddress = "London",
                    CustPhoneNo = "1234567890"
                },
                new Customer()
                {
                    CustId = 2,
                    CustName = "Smith",
                    CustAddress = "New York",
                    CustPhoneNo = "9876543210"
                },
                new Customer()
                {
                    CustId = 3,
                    CustName = "Mark",
                    CustAddress = "Sydney",
                    CustPhoneNo = "1234509876"
                },
                new Customer()
                {
                    CustId = 4,
                    CustName = "Chris",
                    CustAddress = "Paris",
                    CustPhoneNo = "6789054321"
                }
            };

            return View(customers);
        }
    }
}
