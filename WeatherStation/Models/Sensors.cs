using System.ComponentModel.DataAnnotations.Schema;

namespace WeatherStation.Models
{
    public class Sensors
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SensorId { get; set; }
        public string SensorName { get; set; }
        public SensorTypes SensorTypes { get; set; }
        public int SensorTypeId { get; set; }
        public UnitMeasurement UnitMeasurement { get; set; }
        public int UnitMeasurementId { get; set; }
        public DateTime CreateDate { get; set; }
        public bool State { get; set; }

    }
}
