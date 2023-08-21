namespace CaravanMVC.Models
{
    public class Wagon
    {
        public string Name { get; set; }
        public int NumWheels { get; set; }
        public bool Covered { get; set; }
        public List<Passenger> Passengers { get; set; }
    }
}
