using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Airlines.BaseModels;
using Microsoft.EntityFrameworkCore;

namespace Airlines.Models
{
    public class Ticket : BaseModel
    {
        [Precision(9, 2)]
        public decimal TicketPrice { get; set; }
        [MaxLength(50)]
        public string Type { get; set; }
        public ushort SeatNumber { get; set; }
        public int FlightId { get; set; }
        public Flight Flight { get; set; } = null!;
        public int PassengerId { get; set; }
        public Passenger Passenger { get; set; } = null!;
    }
}
