using System.ComponentModel.DataAnnotations.Schema;

namespace WeatherStation.Models
{
    public class SensorTypes
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SensorTypeId { get; set; }
        public string SensorTypeName { get; set; }
        public DateTime CreateDate { get; set; }
        public bool State { get; set; }
    }
}
