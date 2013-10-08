using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SRS.Controllers.CMS
{
    public class DevicesController : Controller
    {
        //
        // GET: /Devices/

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult AddDevice()
        {
            JsonResult objResult = new JsonResult();
            return objResult;
        }

        public JsonResult RemoveDevice(int DeviceId)
        {
            JsonResult objResult = new JsonResult();
            return objResult;
        }

        public JsonResult UpdateDevice(int DeviceId)
        {
            JsonResult objResult = new JsonResult();
            return objResult;
        }

    }
}
