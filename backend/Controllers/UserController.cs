using backend.DatabaseRepository;
using backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace UserController
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        // Get All
        [HttpGet]
        [Route("GetAllUsers")]
        public IEnumerable<User> GetAllUsers()
        {
            return UserDB.GetAllUsers().ToArray();
        }

        // Get Single
        [HttpGet]
        [Route("GetUserById")]
        public ActionResult<User> GetUserById(int UserId)
        {
            return UserDB.GetUserById(UserId);
        }

        // Add
        [HttpPost]
        [Route("AddUser")]
        public string AddUser()
        {
            return "";
        }

        // Delete
        [HttpDelete]
        [Route("DeleteUserById")]
        public ActionResult<User> DeleteUserById(int UserId)
        {
            return UserDB.DeleteUserById(UserId);
        }

        // Edit
        [HttpPut]
        [Route("EditUserById")]
        public ActionResult<User> EditUserById(int UserId)
        {
            return UserDB.EditUserById(UserId);
        }
    }
}