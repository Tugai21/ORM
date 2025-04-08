using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Airlines.BaseModels;

namespace Airlines.Models
{
    public class Passenger : BaseModel
    {
        public string Name { get; set; } = null!;
        public Ticket? Ticket { get; set; }
    }
}
