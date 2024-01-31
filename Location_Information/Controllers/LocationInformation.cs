using Location_Information.DB;
using Location_Information.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace Location_Information.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationInformation : ControllerBase
    {

        [HttpGet(Name = "GetLocationInformation")]
        public IActionResult Index()
        {
            //Converting Key Name to Pascal case, by default it is Camel Case
            var options = new JsonSerializerOptions();
            options.PropertyNamingPolicy = null;

            var getLocationInform = DataAcess.GetLocation();
            List<Location> LocationInform = new List<Location>
            { new Location{ id = 1, location_name = "SuperMarket", opening_time = Convert.ToDateTime("10:00"), ending_time  = Convert.ToDateTime("10:00")} ,
             new Location{ id = 2, location_name = "ElectronicMarket", opening_time = Convert.ToDateTime("10:00"), ending_time  = Convert.ToDateTime("10:00")}};     
      
            return Ok(getLocationInform);
        }
        [HttpPost(Name = "addLocationInformation")]
        public IActionResult AddLocationInformation(Location location)
        {
            DataAcess.location.Add(new Location { id = 3, location_name = "SuperMarket", opening_time = Convert.ToDateTime("10:00"), ending_time = Convert.ToDateTime("10:00") });
            return Ok(location);

        }


    }
}
