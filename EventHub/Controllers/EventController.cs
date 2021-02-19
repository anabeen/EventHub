using EventHub.EventFormViewModel;
using EventHub.Models;
using System.Linq;
using System.Web.Mvc;

namespace EventHub.Controllers
{
    public class EventController : Controller
    {
        private ApplicationDbContext _context;

        public EventController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Event
        public ActionResult Create()
        {
            var ViewModel = new EventViewModel
            {
                Themes = _context.Themes.ToList()
            };

            return View(ViewModel);
        }
    }
}