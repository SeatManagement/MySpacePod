using Microsoft.AspNetCore.Mvc;
using SeatManagement.Models;
using SeatManagement.Services;
using System.Threading.Tasks;
using System.Text.Encodings.Web;
using System;
using System.Collections.Generic;

namespace SeatManagement.Controllers
{
    [Route("api/[controller]")]
    public class VisitorsController : Controller
    {
        private readonly HtmlEncoder _htmlEncoder;
        private readonly ICloudantService _cloudantService;

        public VisitorsController(HtmlEncoder htmlEncoder, ICloudantService cloudantService = null)
        {
            _cloudantService = cloudantService;
            _htmlEncoder = htmlEncoder;
        }

        // GET: api/values
        [HttpGet]
        public async Task<dynamic> Get()
        {
            if (_cloudantService == null)
            {
                return new string[] { "No database connection" };
            }
            else
            {
                return await _cloudantService.GetAllAsync();
            }
        }
        // POST api/values
        [HttpPost]
        public JsonResult Post()
        {
            //var users = GetLocation();
            return Json("You already reside in City:Chennai, Building: OLYMPIA ,Floor:1, SeatNumber:125");//, allowGet);
        }

       

        private JsonResult Json(List<Location> users, object allowGet)
        {
            throw new NotImplementedException();
        }

        // POST api/values
        //[HttpPost]
        //public async Task<dynamic> Post([FromBody]Visitor visitor)
        //{
        //    if (_cloudantService != null)
        //    {
        //        var response = await _cloudantService.CreateAsync(visitor);
        //        Console.WriteLine("POST RESULT " + response);
        //    }

        //    return new string[] {visitor.Name};
        //}

        private List<Location> GetLocation()
        {
            var usersList = new List<Location>
            {
                new Location
                {
                    LocId = 1,
                    LocName = "Guindy"
                },
                new Location
                {
                    LocId = 2,
                    LocName = "Ambit"
                }
            };

            return usersList;
        }
    }
}
