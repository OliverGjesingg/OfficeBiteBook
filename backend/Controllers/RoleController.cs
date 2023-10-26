using backend.DatabaseRepository;
using backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace RoleController
{
    [ApiController]
    [Route("[controller]")]
    public class RoleController : ControllerBase
    {
        // Get All
        [HttpGet]
        [Route("GetAllRoles")]
        public IEnumerable<Role> GetAllRoles()
        {
            return RoleDB.GetAllRoles().ToArray();
        }

        // Get Single
        [HttpGet]
        [Route("GetRoleById")]
        public ActionResult<Role> GetRoleById(int RoleId)
        {
            return RoleDB.GetRoleById(RoleId);
        }

        // Add
        [HttpPost]
        [Route("AddRole")]
        public string AddRole()
        {
            return "";
        }

        // Delete
        [HttpDelete]
        [Route("DeleteRoleById")]
        public ActionResult<Role> DeleteRoleById(int RoleId)
        {
            return RoleDB.DeleteRoleById(RoleId);
        }

        // Edit
        [HttpPut]
        [Route("EditRoleById")]
        public ActionResult<Role> EditRoleById(int RoleId)
        {
            return RoleDB.EditRoleById(RoleId);
        }
    }
}