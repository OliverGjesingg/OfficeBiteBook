using backend.DatabaseRepository;
using backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace UserRoleController
{
    [ApiController]
    [Route("[controller]")]
    public class UserRoleController : ControllerBase
    {
        // Get All
        [HttpGet]
        [Route("GetAllUserRoles")]
        public IEnumerable<UserRole> GetAllUserRoles()
        {
            return UserRoleDB.GetAllUserRoles().ToArray();
        }

        // Get Single
        [HttpGet]
        [Route("GetUserRoleById")]
        public ActionResult<UserRole> GetUserRoleById(int UserRoleId)
        {
            return UserRoleDB.GetUserRoleById(UserRoleId);
        }
    }
}