using AcunMedyaAkademiAgency.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaAkademiAgency.Controllers
{
    
    public class DashboardController : Controller
    {
        AgencyContext context = new AgencyContext();
        public ActionResult Index()
        {
            ViewBag.bildirimsayisi = context.Notifications.ToList().Count();
            ViewBag.projectsayisi = context.Projects.ToList().Count();
            int categorygrafik = context.Categories.Where(x => x.CategoryName == "Grafik Tasarım").Select(y => y.CategoryId).FirstOrDefault();
            ViewBag.grafikCount = context.Projects.Where(x => x.CategoryId == categorygrafik).Count();
            ViewBag.personelsayisi = context.Teams.ToList().Count();
            return View();
        }
    }
}