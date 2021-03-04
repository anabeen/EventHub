using EventHub.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace EventHub.Controllers
{



    public class HomeController : Controller
    {

        private ApplicationDbContext _context;

        public HomeController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult Index()
        {
            var upcomingEvents = _context.Events
                                .Include(g => g.Planner)
                                .Include(g => g.EventTheme)
                                .Where(m => m.DateTime > DateTime.Now);
            return View(upcomingEvents);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}