using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Airlines.BaseModels;

namespace Airlines.Models
{
    public class FlightStatus : BaseModel
    {
        public string Status { get; set; } = null!;
        public ICollection<FlightStatusChange> FlightStatusChanges { get; set; }

    }
}
