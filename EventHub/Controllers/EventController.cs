using EventHub.EventFormViewModel;
using EventHub.Models;
using Microsoft.AspNet.Identity;
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

        [Authorize]
        public ActionResult Create()
        {
            var ViewModel = new EventViewModel
            {
                Themes = _context.Themes.ToList()
            };

            return View(ViewModel);
        }

        [Authorize]
        [HttpPost]
        public ActionResult Create(EventViewModel viewModel)
        {

            if (!ModelState.IsValid)
            {
                viewModel.Themes = _context.Themes.ToList();
                return View(viewModel);
            }

            var events = new Event
            {
                PlannerId = User.Identity.GetUserId(),
                DateTime = viewModel.dateTime(),
                ThemeId = viewModel.Theme,
                Place = viewModel.Place

            };

            _context.Events.Add(events);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}