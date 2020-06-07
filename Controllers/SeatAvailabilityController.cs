using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SeatManagement.Models;

namespace SeatManagement.Controllers
{
    [Route("api/[controller]")]
    public class SeatAvailabilityController : Controller
    {
        [HttpPost]
        public JsonResult Post()
        {
            //var users = GetLocation();
            //List<SeatAvailability> seat = new List<SeatAvailability>();
            var seat = new List<SeatAvailability>
            {
                new SeatAvailability
                {
                    SeatId = 10011, 
                    Building = "ARIHANTH",
                    Floor = "3",
                    SeatNumber = "12",
                    General = "Y"
                },
                new SeatAvailability
                {
                    SeatId = 10012,
                    Building = "OLYMPIA",
                    Floor = "8",
                    SeatNumber = "182",
                    General = "N"
                }
            };

            return Json(seat);//, allowGet);
        }


    }
}
