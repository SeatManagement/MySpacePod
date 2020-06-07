using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SeatManagement.Models
{
    public class Location
    {
        [Key]
        public int LocId { get; set; }
        public string LocName { get; set; }
    }
}
