using backend.DatabaseRepository;
using backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace LocationController
{
    [ApiController]
    [Route("[controller]")]
    public class LocationController : ControllerBase
    {
        // Get All
        [HttpGet]
        [Route("GetAllLocations")]
        public IEnumerable<Location> GetAllLocations()
        {
            return LocationDB.GetAllLocations().ToArray();
        }

        // Get Single
        [HttpGet]
        [Route("GetLocationById")]
        public ActionResult<Location> GetLocationById(int LocationId)
        {
            return LocationDB.GetLocationById(LocationId);
        }
    }
}