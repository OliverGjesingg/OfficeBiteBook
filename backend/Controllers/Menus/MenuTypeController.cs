using backend.DatabaseRepository;
using backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace MenuTypesController
{
    [ApiController]
    [Route("[controller]")]
    public class MenuTypeController : ControllerBase
    {
        private readonly ILogger<MenuTypeController> _logger;

        public MenuTypeController(ILogger<MenuTypeController> logger)
        {
            _logger = logger;
        }

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
        public ActionResult<MenuType> GetMenuTypeById(int GetMenuTypeId)
        {
            return MenuTypeDB.GetMenuTypeById(GetMenuTypeId);
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
        public ActionResult<MenuType> DeleteMenuTypeById(int DeleteMenuTypeId)
        {
            return MenuTypeDB.DeleteMenuTypeById(DeleteMenuTypeId);
        }

        // Edit
        [HttpPut]
        [Route("EditMenuTypeById")]
        public ActionResult<MenuType> EditMenuTypeById(int EditMenuTypeId)
        {
            return MenuTypeDB.EditMenuTypeById(EditMenuTypeId);
        }
    }
}