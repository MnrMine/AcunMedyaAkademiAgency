using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiAgency.Context;
using AcunMedyaAkademiAgency.Entities;

namespace AcunMedyaAkademiAgency.Controllers
{
    public class ServiceController : Controller
    {
       AgencyContext context=new AgencyContext();
        public ActionResult ServiceList()
        {
            var values = context.Services.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateService()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateService(Service service)
        {
            context.Services.Add(service);
            context.SaveChanges();

            return RedirectToAction("ServiceList");
        }
    }
}