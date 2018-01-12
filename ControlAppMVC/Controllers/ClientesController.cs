using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.WebPages;
using ControlAppMVC.Models;

namespace ControlAppMVC.Controllers
{
    public class ClientesController : Controller
    {
        // GET: Clientes
        public ActionResult Index()
        {
            SingletonDB test = SingletonDB.Instance();

            


            var c1 = new Cliente() {Id = 1, Name = "Mario", Email = "test@test.com", PhoneNumber = "2449041"};
            var c2 = new Cliente() {Id = 2, Name = "Mario", Email = "test@test.com", PhoneNumber = "2449041"};
            var c3 = new Cliente() {Id = 3, Name = "Mario", Email = "test@test.com", PhoneNumber = "2449041"};
            var c4 = new Cliente() {Id = 4, Name = "Mario", Email = "test@test.com", PhoneNumber = "2449041"};
            var c5 = new Cliente() {Id = 5, Name = "Mario", Email = "test@test.com", PhoneNumber = "2449041"};


            test.AddCustumer(c1);
            test.AddCustumer(c2);
            test.AddCustumer(c3);
            test.AddCustumer(c4);
            test.AddCustumer(c5);
            List<Cliente> l = test.listReturn();

            return View(l);
        }
    }
}