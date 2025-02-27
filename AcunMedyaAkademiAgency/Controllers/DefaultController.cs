using AcunMedyaAkademiAgency.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaAkademiAgency.Controllers
{
    public class DefaultController : Controller
    {
        AgencyContext context=new AgencyContext();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult ProjectPartial()
        {
            var values = context.Projects.OrderByDescending(x => x.ProjectId).Take(6).ToList();
            return PartialView(values);
        }
        public PartialViewResult ModalPartial()
        {
            var values = context.ProjectDetails.ToList();
            return PartialView(values);
        }
        public PartialViewResult TeamPartial()
        {
            var values = context.Teams.ToList();
            return PartialView(values);
        }
        public PartialViewResult SocialMediaPartial()
        {
            var values = context.SocialMedias.ToList();
            return PartialView(values);
        }

    }
}