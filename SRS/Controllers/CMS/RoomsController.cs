using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SRS.Controllers.CMS
{
    public class RoomsController : Controller
    {
        //
        // GET: /Rooms/

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult AddRoom()
        {
            JsonResult objResult = new JsonResult();
            return objResult;
        }

        public JsonResult RemoveRoom(int RoomId)
        {
            JsonResult objResult = new JsonResult();
            return objResult;
        }

        public JsonResult UpdateDevice(int RoomId)
        {
            JsonResult objResult = new JsonResult();
            return objResult;
        }

    }
}
