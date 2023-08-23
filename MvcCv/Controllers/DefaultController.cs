using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Models.Entity;

namespace MvcCv.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        // GET: Default
        public PartialViewResult Deneyim()
        {
            var deneyimler = db.TblDeneyimlerim.ToList();
            return PartialView(deneyimler);
        }


        DbCvEntities1 db=new DbCvEntities1();
        public ActionResult Index()
        {
            var deger =db.TblHakkimda.ToList();
            return View(deger);
        }

  
        public PartialViewResult Egitimlerim()
        {
            var egitimimler = db.TblEgitimlerim.ToList();
            return PartialView(egitimimler);
        }

        public PartialViewResult Yeteneklerim()
        {
            var yetenekler = db.TblYeteneklerim.ToList();
            return PartialView(yetenekler);
        }

        public PartialViewResult SosyalMedya()
        {
            var sosyalmedya = db.TblSosyalMedya.Where(x=>x.Durum==true).ToList();
            return PartialView(sosyalmedya);
        }

        public PartialViewResult Hobilerim()
        {
            var hobiler = db.TblHobilerim.ToList();
            return PartialView(hobiler);
        }

        public PartialViewResult Sertifikalar()
        {
            var Sertifikalar = db.TblSertifikalarim.ToList();
            return PartialView(Sertifikalar);
        }
        [HttpGet]
        public PartialViewResult iletisim()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult iletisim(Tbliletisim t)
        {
            t.Tarih= DateTime.Parse(DateTime.Now.ToShortTimeString());
            db.Tbliletisim.Add(t);
            db.SaveChanges();
            return PartialView();
        }


    }
}