using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GucQ.Models;


namespace GucQ.Controllers
{
    public class HomeController : Controller
    {
        DB_A3E145_azmanazEntities1 db = new DB_A3E145_azmanazEntities1();
       

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Datagonder(FormCollection frm)
        {

            Sifari sfrs = new Sifari();
            sfrs.sifarisci_ad_soyad = frm["sifarisci_ad_soyad"];
            sfrs.sifarisci_telefon = frm["sifarisci_telefon"];
            sfrs.sifarisci_unvani = frm["mehsulun_adi"];
            sfrs.sifaris_novu_id = 9;
            sfrs.sifaris_tarixi = DateTime.Now;

            db.Sifaris.Add(sfrs);
            db.SaveChanges();
          
           
            return View("Index");
        }

    }
}