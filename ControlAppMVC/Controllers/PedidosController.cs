using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ControlAppMVC.Models;

namespace ControlAppMVC.Controllers
{
    public class PedidosController : Controller
    {
        // GET: Pedido
        public ActionResult Index()
        {
            SingletonDB test  = SingletonDB.Instance();

            var a = new Cliente {Id = 8, Email = "abc@.com", Name = "MM", PhoneNumber = "025"};
            test.AddCustumer(a);
            List<Cliente> l2 = test.listReturn();

            return View(l2);
        }
    }
}