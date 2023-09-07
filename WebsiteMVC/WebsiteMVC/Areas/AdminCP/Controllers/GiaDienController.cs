using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebsiteMVC.Models;

namespace WebsiteMVC.Areas.AdminCP.Controllers
{
    public class GiaDienController : AdminController
    {
        public ActionResult Index()
        {
            return View(db.GiaDiens.ToList());
        }

        //public ActionResult Edit(int? id)
        //{
        //    GiaDien obj = new GiaDien();
        //    if (id > 0)
        //    {
        //        obj = db.GiaDiens.Find(id);
        //        if (obj == null)
        //        {
        //            return HttpNotFound();
        //        }
        //    }
        //    return View(obj);
        //}
        //public ActionResult Edit(GiaDien obj)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        if (obj.IDGiaDien == 0)
        //        {
        //            db.GiaDiens.Add(obj);
        //        }
        //        else
        //        {
        //            db.Entry(obj).State = EntityState.Modified;
        //        }

        //        db.SaveChanges();

        //        return RedirectToAction("Index");
        //    }

        //    return View(obj);
        //}



    }
}
