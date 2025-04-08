using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Airlines.BaseModels;

namespace Airlines.Models
{
    public class Payroll : BaseModel
    {
        public int PassengerId { get; set; }
        public Passenger Passenger { get; set; } = null!;
        public int? TicketId { get; set; }
        public Ticket? Tickets { get; set; }
        public decimal Total { get; set; }

    }
}
