namespace WeatherStation.Models
{
    public class Weather
    {
        public int IdWeather { get; set; }
        public int IdLocation { get; set; }
        public int IdUser { get; set; }
        public string Humidity { get; set; }
        public string Temperature { get; set; }
        public string AmosphericPressure { get; set; }
        public DateTime CreateDate { get; set; }
        public bool State { get; set; }
    }
}