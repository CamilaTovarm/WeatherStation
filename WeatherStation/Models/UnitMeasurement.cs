using System.ComponentModel.DataAnnotations.Schema;

namespace WeatherStation.Models
{
    public class UnitMeasurement
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UnitMeasurementId { get; set; }
        public string UnitMeasurementName { get; set; }
        public DateTime CreateDate { get; set; }
        public bool State { get; set; }
    }
}
