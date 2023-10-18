using backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace MenuTypeController
{
    [ApiController]
    [Route("[controller]")]
    public class MenuTypesController : ControllerBase
    {
        private readonly ILogger<MenuTypesController> _logger;

        public MenuTypesController(ILogger<MenuTypesController> logger)
        {
            _logger = logger;
        }

        // Get All
        [HttpGet]
        [Route("GetAllMenuTypes")]
        public IEnumerable<MenuTypes> GetAllMenuTypes()
        {
            List<MenuTypes> list = new List<MenuTypes>();
            MenuTypes type = new MenuTypes();
            type.Name = "Breakfast";
            type.MenuTypeId = 1;
            type.DefaultStartTime = "08:00";
            type.DefaultEndTime = "09:00";
            MenuTypes type1 = new MenuTypes();
            type1.Name = "Lunch";
            type1.MenuTypeId = 2;
            type1.DefaultStartTime = "12:00";
            type1.DefaultEndTime = "13:00";
            MenuTypes type2 = new MenuTypes();
            type2.Name = "Dinner";
            type2.MenuTypeId = 3;
            type2.DefaultStartTime = "18:00";
            type2.DefaultEndTime = "19:00";
            list.Add(type);
            list.Add(type1);
            list.Add(type2);
            return list.ToArray();
        }

        // Get
        [HttpGet]
        [Route("GetMenuTypesById/{GetMenuTypeId}")]
        public ActionResult<MenuTypes> GetMenuTypesById(int GetMenuTypeId)
        {
            // Loop and return any found MenuTypes if any MenuTypeId match with the entered value.
            foreach (var menuType in GetAllMenuTypes())
            {
                // Check if value and MenuTypeId match with one another.
                if (menuType.MenuTypeId == GetMenuTypeId) 
                {
                    // Return the found MenuType.
                    return menuType;
                }
            }

            // Inform if the entered MenuTypeId isn't a valid ID or doesn't exist.
            return NotFound("Make sure to write MenuTypeId correctly!");
        }

        // Add
        [HttpPost]
        [Route("AddMenuTypes")]
        public string AddMenuTypes()
        {
            return "";
        }

        // Delete
        [HttpDelete]
        [Route("DeleteMenuTypes")]
        public string DeleteMenuTypes(int DeleteMenuTypesId)
        {
            return "";
        }

        // Edit
        [HttpPut]
        [Route("EditMenuTypes")]
        public string EditMenuTypes(int EditMenuTypesId)
        {
            return "";
        }
    }
}