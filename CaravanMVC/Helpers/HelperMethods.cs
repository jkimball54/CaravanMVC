using CaravanMVC.DataAccess;
using CaravanMVC.Models;

namespace CaravanMVC.Helpers
{
    public static class HelperMethods
    {


        public static List<string> DistinctLocations(CaravanMvcContext context)
        {
            return context.Passengers.Select(p => p.Destination).Distinct().ToList();
        }

        public static int AveragePassengerAge(CaravanMvcContext context)
        {
            return Convert.ToInt32(context.Passengers.Average(a => a.Age));
        }
    }

}