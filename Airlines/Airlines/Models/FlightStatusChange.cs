using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Airlines.BaseModels;

namespace Airlines.Models
{
    public class FlightStatusChange : BaseModel
    {
        public int FlightId { get; set; }
        public Flight Flight { get; set; }
        public int FlightStatusId { get; set; }
        public FlightStatus FlightStatus { get; set; }
        public DateTime ChangedAt { get; set; } = DateTime.UtcNow;

    }
}
