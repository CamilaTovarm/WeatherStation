using System.ComponentModel.DataAnnotations.Schema;

namespace WeatherStation.Models
{
    public class Stations
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StationId { get; set; }
        public Users Users { get; set; }
        public int UserId { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Altitude { get; set; }
        public DateTime CreateDate { get; set; }
        public bool State { get; set; }
    }
}
