using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        public ActionResult Random { get; set; }

        public ActionResult ByReleaseDate(int year, int month) => Content(year + "/" + month);
    }
}