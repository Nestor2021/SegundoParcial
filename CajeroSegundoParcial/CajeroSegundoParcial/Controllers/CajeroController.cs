using CajeroSegundoParcial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CajeroSegundoParcial.Controllers
{
    public class CajeroController : Controller
    {
        // GET: Cajero
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult indexVista()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Correcto()
        {
            return View();
        }
        [HttpGet]
        public ActionResult ErrorMonto()
        {
            return View();
        }


        [HttpPost]
        public ActionResult indexVista(Cajero c)
        {

            if (c.Retiro % 5 == 0)
            {
                return Redirect("Correcto");
            }
            else
            {
                return Redirect("ErrorMonto");
            }
            return View();

        }
      
}
}