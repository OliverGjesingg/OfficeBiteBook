using backend.DatabaseRepository;
using backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace MenuDishController
{
    [ApiController]
    [Route("[controller]")]
    public class MenuDishController : ControllerBase
    {
        // Get All
        [HttpGet]
        [Route("GetAllMenuDishes")]
        public IEnumerable<MenuDish> GetAllMenuDishes()
        {
            return MenuDishDB.GetAllMenuDishes().ToArray();
        }

        // Get Single
        [HttpGet]
        [Route("GetMenuDishById")]
        public ActionResult<MenuDish> GetMenuDishById(int MenuDishId)
        {
            return MenuDishDB.GetMenuDishById(MenuDishId);
        }
    }
}