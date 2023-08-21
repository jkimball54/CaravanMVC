using Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure;

namespace CaravanMVC.Models
{
    public class Wagon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumWheels { get; set; }
        public bool Covered { get; set; }
        public List<Passenger> Passengers { get; set; }


        public int PassengerCount()
        {
            return Passengers.Count();
        }
        public int AverageAge()
        {
            return Convert.ToInt32(Passengers.Average(a => a.Age));
        }

    }

}
