using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SeatManagement.Models;

namespace SeatManagement.Controllers
{
    [Route("api/[controller]")]
    
    public class CancelController : Controller
    {
        [HttpPost]
        public JsonResult Post(int seatNo)
        {
            //var users = GetLocation();
            //List<SeatAvailability> seat = new List<SeatAvailability>();
            //var seat = new List<SeatAvailability>
            //{
            //    new SeatAvailability
            //    {
            //        SeatId = 10011,
            //        Building = "ARIHANTH",
            //        Floor = "3",
            //        SeatNumber = "12",
            //        General = "Y"
            //    },
            //    new SeatAvailability
            //    {
            //        SeatId = 10012,
            //        Building = "OLYMPIA",
            //        Floor = "8",
            //        SeatNumber = "182",
            //        General = "N"
            //    }
            //};
            //var res = seat.FirstOrDefault(a => a.SeatId == seatNo);
            Random r = new Random();
            int num = r.Next(1000,5000);
            return Json("Your Seat is released for others to use. This request requires your manager's approval.Ticket Number "+num.ToString());//, allowGet);
        }
    }
}
