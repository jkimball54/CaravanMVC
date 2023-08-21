using CaravanMVC.DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CaravanMVC.Models;

namespace CaravanMVC.Controllers
{
    public class PassengersController : Controller
    {
        private readonly CaravanMvcContext _context;
        public PassengersController(CaravanMvcContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Route("/Wagons/{wagonId:int}/Passengers/New")]
        public IActionResult New(int wagonId)
        {
            var wagon = _context.Wagons
                .Where(w => w.Id == wagonId)
                .Include(w => w.Passengers)
                .First();
            return View(wagon);
        }

        [Route("/Wagons/{wagonId}/Passengers")]
        public IActionResult Create(int wagonId, Passenger passenger)
        {
            var wagon = _context.Wagons
                .Where(w => w.Id == wagonId)
                .Include(w => w.Passengers)
                .First();
            wagon.Passengers.Add(passenger);
            _context.SaveChanges();
            return Redirect($"/Wagons/{wagonId}");
        }
    }
}
