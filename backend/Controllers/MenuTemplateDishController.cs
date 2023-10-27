using backend.DatabaseRepository;
using backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace MenuTemplateDishController
{
    [ApiController]
    [Route("[controller]")]
    public class MenuTemplateDishController : ControllerBase
    {
        // Get All
        [HttpGet]
        [Route("GetAllMenuTemplateDishes")]
        public IEnumerable<MenuTemplateDish> GetAllMenuTemplateDishes()
        {
            return MenuTemplateDishDB.GetAllMenuTemplateDishes().ToArray();
        }

        // Get Single
        [HttpGet]
        [Route("GetMenuTemplateDishById")]
        public ActionResult<MenuTemplateDish> GetMenuTemplateDishById(int MenuTemplateDishId)
        {
            return MenuTemplateDishDB.GetMenuTemplateDishById(MenuTemplateDishId);
        }

        // Add
        [HttpPost]
        [Route("AddMenuTemplateDish")]
        public string AddMenuTemplateDish()
        {
            return "";
        }

        // Delete
        [HttpDelete]
        [Route("DeleteMenuTemplateDishById")]
        public ActionResult<MenuTemplateDish> DeleteMenuTemplateDishById(int MenuTemplateDishId)
        {
            return MenuTemplateDishDB.DeleteMenuTemplateDishById(MenuTemplateDishId);
        }

        // Edit
        [HttpPut]
        [Route("EditMenuTemplateDishById")]
        public ActionResult<MenuTemplateDish> EditMenuTemplateDishById(int MenuTemplateDishId)
        {
            return MenuTemplateDishDB.EditMenuTemplateDishById(MenuTemplateDishId);
        }
    }
}