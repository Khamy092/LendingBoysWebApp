using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMatrix.Data;

namespace myNotes.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Title = "About";
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Title = "Contact";
            ViewBag.Message = "Your contact page.";

            return View();
        }
        
        public ActionResult Clients()
        {
            ViewBag.Title = "Clients";
            ViewBag.Message = "This is the clients' page.";

            return View();
        }

        public ActionResult AddClient()
        {
            
            ViewBag.Title = "Add Client";
            ViewBag.Message = "This is where we can create new clients.";
            return View();
        }

        public ActionResult Details()
        {
            ViewBag.Title = "Details";
            ViewBag.Message = "This is where we can show more details about a client.";

            return View();
        }

        public ActionResult Edit()
        {
            ViewBag.Title = "Edit";
            ViewBag.Message = "This is where we can edit the details of client.";

            return View();
        }
    }
    
}