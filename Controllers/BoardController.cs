using MovieLecMvcWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieLecMvcWeb.Controllers
{
    public class BoardController : Controller
    {
        public ActionResult List()
        {
            DocumentActs da = new DocumentActs();
            return View(da.GetDocuments());
        }
    }
}