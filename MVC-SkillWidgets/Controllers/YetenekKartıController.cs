using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using MVC_SkillWidgets.Models.Siniflar;
namespace MVC_SkillWidgets.Controllers
{
    public class YetenekKartıController : Controller
    {
        // GET: YetenekKartı
        public ActionResult Index()
        {
            Context c = new Context();
            var degerler = c.Yeteneks.ToList();
            return View(degerler);
        }
    }
}