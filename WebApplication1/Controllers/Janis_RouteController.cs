using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class Janis_RouteController : Controller
    {
        // GET: Janis_Route
        public ActionResult Index()
        {
            //在不接受任何參數的狀況
            //return Content("在不接受任何參數的狀況");
            return View();
        }
        public ActionResult Index2(string id)
        {
            //在單變數的狀況
            return Content(
                String.Format("單變數的狀況下，id的值為:{0}",id)
                );
        }
        public ActionResult Index3(string id, string id2)
        {
            //在多變數的狀況
            return Content(
                String.Format("多變數的狀況下，id的值為:{0} id2的值為:{1}", id, id2)
                );
        }
    }
}