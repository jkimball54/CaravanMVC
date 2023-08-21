using CaravanMVC.DataAccess;
using CaravanMVC.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace CaravanMVC.Controllers
{
    public class OverviewsController : Controller
    {
        private readonly CaravanMvcContext _context;
        public OverviewsController(CaravanMvcContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewData["DistinctDestinations"] = HelperMethods.DistinctLocations(_context);
            ViewData["AverageAge"] = HelperMethods.AveragePassengerAge(_context);
            return View();
        }
    }
}
