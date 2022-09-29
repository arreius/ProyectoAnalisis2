using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoAnalisis2.Controllers
{
    public class RecordsController : Controller
    {
        // GET: Records

        public ActionResult Inventory()
        {
            return View();
        }
        public ActionResult Nomenclature()
        {
            return View();
        }
        public ActionResult CostCenter()
        {
            return View();
        }
    }
}