using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PettyCashApp.Models;
using System.Web.Mvc;

namespace PettyCashApp.Controllers
{
    public class CashController : Controller
    {
        // GET: Cash
        public ActionResult Index()
        {
            PettyRequest Registration = new PettyRequest();
            return View(Registration);
        }
    }
}