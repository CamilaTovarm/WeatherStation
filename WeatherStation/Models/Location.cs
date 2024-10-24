namespace WeatherStation.Models
{
    public class Location
    {
        public int IdLocation { get; set; }
        public string Latitude {  get; set; }
        public string Longitude { get; set; }
        public DateTime CreateDate { get; set; }
        public bool State { get; set; }
    }
}
