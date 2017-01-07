using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using System.Data.Entity;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ViewResult Index()
        {
            var Customers = _context.Customers.Include(c => c.MembershipType).Include(co => co.MembershipType).ToList();
            return View(Customers);
        }

 

        public ActionResult Details(int id)
        {
            // var Customer = GetCustomers().SingleOrDefault(c => c.Id == id);
            var Customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (Customer == null)
                return HttpNotFound();

            return View(Customer);

        }

        //public IEnumerable<Customer> GetCustomers()
        //{
        //    return new List<Customer>
        //    {
        //         new Customer {Id = 1, Name = "Vamsi" },
        //        new Customer {Id = 2, Name = "Priyanka" }
        //    };

        //}
    }
}