using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SeatManagement.Models
{
    public class Block
    {
        [Key]
        public int BlockId { get; set; }
        public string LocName { get; set; }
        public string BlockName { get; set; }
    }
}
