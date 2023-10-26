using backend.DatabaseRepository;
using backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace MenuUserController
{
    [ApiController]
    [Route("[controller]")]
    public class MenuUserController : ControllerBase
    {
        // Get All
        [HttpGet]
        [Route("GetAllMenuUsers")]
        public IEnumerable<MenuUser> GetAllMenuUsers()
        {
            return MenuUserDB.GetAllMenuUsers().ToArray();
        }

        // Get Single
        [HttpGet]
        [Route("GetMenuUserById")]
        public ActionResult<MenuUser> GetMenuUserById(int MenuUserId)
        {
            return MenuUserDB.GetMenuUserById(MenuUserId);
        }
    }
}