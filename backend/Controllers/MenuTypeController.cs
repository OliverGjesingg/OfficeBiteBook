using backend.DatabaseRepository;
using backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace MenuTypeController
{
    [ApiController]
    [Route("[controller]")]
    public class MenuTypeController : ControllerBase
    {
        // Get All
        [HttpGet]
        [Route("GetAllMenuTypes")]
        public IEnumerable<MenuType> GetAllMenuTypes()
        {
            return MenuTypeDB.GetAllMenuTypes().ToArray();
        }

        // Get Single
        [HttpGet]
        [Route("GetMenuTypeById")]
        public ActionResult<MenuType> GetMenuTypeById(int MenuTypeId)
        {
            return MenuTypeDB.GetMenuTypeById(MenuTypeId);
        }

        // Add
        [HttpPost]
        [Route("AddMenuType")]
        public string AddMenuType()
        {
            return "";
        }

        // Delete
        [HttpDelete]
        [Route("DeleteMenuTypeById")]
        public ActionResult<MenuType> DeleteMenuTypeById(int MenuTypeId)
        {
            return MenuTypeDB.DeleteMenuTypeById(MenuTypeId);
        }

        // Edit
        [HttpPut]
        [Route("EditMenuTypeById")]
        public ActionResult<MenuType> EditMenuTypeById(int MenuTypeId)
        {
            return MenuTypeDB.EditMenuTypeById(MenuTypeId);
        }
    }
}