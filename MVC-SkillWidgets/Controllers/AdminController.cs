using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using MVC_SkillWidgets.Models.Siniflar;

namespace MVC_SkillWidgets.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.Yeteneks.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YetenekEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YetenekEkle(Yetenek y)
        {
            c.Yeteneks.Add(y);
            c.SaveChanges();
            return View();
        }
        public ActionResult YetenekSil(int id)
        {
            var satir = c.Yeteneks.Find(id);
            c.Yeteneks.Remove(satir);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult YetenekGetir(int id)
        {
            var deger = c.Yeteneks.Find(id);
            return View("YetenekGetir", deger);
        }
        [HttpPost]
        public ActionResult YetenekGetir(Yetenek y)//y yetenek getir sayfasından gelen değer
        {
            var guncellenecek = c.Yeteneks.Find(y.ID);
            guncellenecek.YetenekAd = y.YetenekAd;
            guncellenecek.Deger = y.Deger;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}