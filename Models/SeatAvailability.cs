using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeatManagement.Models
{
    public class SeatAvailability
    {
        public int SeatId { get; set; }
        public string Building { get; set; }
        public string Floor { get; set; }
        public string SeatNumber { get; set; }
        public string General { get; set; }

    }
}
