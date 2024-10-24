using System.ComponentModel.DataAnnotations.Schema;

namespace WeatherStation.Models
{
    public class Weather
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int WeatherId { get; set; }
        public Stations Stations { get; set; }
        public int StationId { get; set; }
        public Sensors Sensors { get; set; }
        public int SensorId { get; set; }
        public string Value { get; set; }
        public DateTime CreateDate { get; set; }
        public bool State { get; set; }
    }
}