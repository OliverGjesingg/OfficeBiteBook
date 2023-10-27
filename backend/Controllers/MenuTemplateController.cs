using backend.DatabaseRepository;
using backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace MenuTemplateController
{
    [ApiController]
    [Route("[controller]")]
    public class MenuTemplateController : ControllerBase
    {
        // Get All
        [HttpGet]
        [Route("GetAllMenuTemplates")]
        public IEnumerable<MenuTemplate> GetAllMenuTemplates()
        {
            return MenuTemplateDB.GetAllMenuTemplates().ToArray();
        }

        // Get Single
        [HttpGet]
        [Route("GetMenuTemplateById")]
        public ActionResult<MenuTemplate> GetMenuById(int MenuTemplateId)
        {
            return MenuTemplateDB.GetMenuTemplateById(MenuTemplateId);
        }

        // Add
        [HttpPost]
        [Route("AddMenuTemplate")]
        public string AddMenu()
        {
            return "";
        }

        // Delete
        [HttpDelete]
        [Route("DeleteMenuTemplateById")]
        public ActionResult<MenuTemplate> DeleteMenuById(int MenuTemplateId)
        {
            return MenuTemplateDB.DeleteMenuTemplateById(MenuTemplateId);
        }

        // Edit
        [HttpPut]
        [Route("EditMenuTemplateById")]
        public ActionResult<MenuTemplate> EditMenuTemplateById(int MenuTemplateId)
        {
            return MenuTemplateDB.EditMenuTemplateById(MenuTemplateId);
        }
    }
}