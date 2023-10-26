using backend.DatabaseRepository;
using backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace MenuController
{
    [ApiController]
    [Route("[controller]")]
    public class MenuController : ControllerBase
    {
        // Get All
        [HttpGet]
        [Route("GetAllMenus")]
        public IEnumerable<Menu> GetAllMenus()
        {
            return MenuDB.GetAllMenus().ToArray();
        }

        // Get Single
        [HttpGet]
        [Route("GetMenuById")]
        public ActionResult<Menu> GetMenuById(int MenuId)
        {
            return MenuDB.GetMenuById(MenuId);
        }

        // Add
        [HttpPost]
        [Route("AddMenu")]
        public string AddMenu()
        {
            return "";
        }

        // Delete
        [HttpDelete]
        [Route("DeleteMenuById")]
        public ActionResult<Menu> DeleteMenuById(int MenuId)
        {
            return MenuDB.DeleteMenuById(MenuId);
        }

        // Edit
        [HttpPut]
        [Route("EditMenuById")]
        public ActionResult<Menu> EditMenuById(int MenuId)
        {
            return MenuDB.EditMenuById(MenuId);
        }
    }
}