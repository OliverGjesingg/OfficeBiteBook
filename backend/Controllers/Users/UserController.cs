using backend.DatabaseRepository;
using backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace UserController
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        // Get All
        [HttpGet]
        [Route("GetAllUsers")]
        public IEnumerable<User> GetAllUsers()
        {
            return UserDB.GetAllUsers().ToArray();
        }

        // Get Single
        [HttpGet]
        [Route("GetMenuTypeById")]
        public ActionResult<MenuType> GetMenuTypeById(int GetMenuTypeId)
        {
            return MenuTypeDB.GetMenuTypeById(GetMenuTypeId);
        }

        //// Add
        //[HttpPost]
        //[Route("AddMenuType")]
        //public string AddMenuType()
        //{
        //    return "";
        //}

        //// Delete
        //[HttpDelete]
        //[Route("DeleteMenuTypeById")]
        //public ActionResult<MenuType> DeleteMenuTypeById(int DeleteMenuTypeId)
        //{
        //    return MenuTypeDB.DeleteMenuTypeById(DeleteMenuTypeId);
        //}

        //// Edit
        //[HttpPut]
        //[Route("EditMenuTypeById")]
        //public ActionResult<MenuType> EditMenuTypeById(int EditMenuTypeId)
        //{
        //    return MenuTypeDB.EditMenuTypeById(EditMenuTypeId);
        //}
    }
}