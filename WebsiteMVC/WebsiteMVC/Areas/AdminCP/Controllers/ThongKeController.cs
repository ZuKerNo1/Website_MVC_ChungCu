using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebsiteMVC.Models;

namespace WebsiteMVC.Areas.AdminCP.Controllers
{
    public class ThongKeController : AdminController
    {
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetData(string sfromDate, string stoDate)
        {
            var fromDate = sfromDate.ToDate();
            var toDate = stoDate.ToDate();
            if (string.IsNullOrWhiteSpace(sfromDate))
            {
                fromDate = toDate.AddMonths(-3);
            }
            fromDate = new DateTime(fromDate.Year, fromDate.Month, 1);
            toDate = new DateTime(toDate.Year, toDate.Month, DateTime.DaysInMonth(toDate.Year, toDate.Month));

            var thanhToan = db.GiaDiens.Where(q => q.NgayTinh >= fromDate && q.NgayTinh <= toDate).ToList();

            var data = (from d in thanhToan
                        group d by new DateTime(d.NgayTinh.Value.Year, d.NgayTinh.Value.Month, 1) into g
                        orderby g.Key
                        select new BaoCaoThanhToan
                        {
                            NgayTinh = g.Key,
                            TongTienDien = (decimal)g.Sum(q => q.GiaTien)
                        }).ToList();

            ViewBag.fromDate = fromDate.ToString("yyyy-MM-dd");
            ViewBag.toDate = toDate.ToString("yyyy-MM-dd");

            return Json(new
            {
                data
            }, JsonRequestBehavior.AllowGet);
        }
    }
}