using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SRS.Controllers.CMS
{
    public class BuildingsController : Controller
    {
        //
        // GET: /Buildings/

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult AddBuilding()
        {
            JsonResult objResult = new JsonResult();
            return objResult;
        }

        public JsonResult RemoveBuilding(int buildingId)
        {
            JsonResult objResult = new JsonResult();
            return objResult;
        }

        public JsonResult UpdateBuilding(int buildingId)
        {
            JsonResult objResult = new JsonResult();
            return objResult;
        }


    }
}
