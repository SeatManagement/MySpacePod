using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SeatManagement.Controllers
{
    [Route("api/[controller]")]
    
    public class ViewController : Controller
    {
        [HttpPost]
        public JsonResult Post()
        {          
            return Json("https://cloud-object-storage-3m-cos-standard-347.s3.us-east.cloud-object-storage.appdomain.cloud");//, allowGet);
        }
    }
}
