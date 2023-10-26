using backend.DatabaseRepository;
using backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace LocationRoomController
{
    [ApiController]
    [Route("[controller]")]
    public class LocationRoomController : ControllerBase
    {
        // Get All
        [HttpGet]
        [Route("GetAllLocationRooms")]
        public IEnumerable<LocationRoom> GetAllLocationRooms()
        {
            return LocationRoomDB.GetAllLocationRooms().ToArray();
        }

        // Get Single
        [HttpGet]
        [Route("GetLocationRoomById")]
        public ActionResult<LocationRoom> GetLocationRoomById(int LocationRoomId)
        {
            return LocationRoomDB.GetLocationRoomById(LocationRoomId);
        }
    }
}