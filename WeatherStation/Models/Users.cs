namespace WeatherStation.Models
{
    public class Users
    {
        public int IdUser { get; set; }
        public int PersonId { get; set; }
        public int Username { get; set; }
        public DateTime CreateDate { get; set; }
        public bool State { get; set; }
    }
}
