using backend.DatabaseRepository;
using backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace DishController
{
    [ApiController]
    [Route("[controller]")]
    public class DishController : ControllerBase
    {
        // Get All
        [HttpGet]
        [Route("GetAllDishes")]
        public IEnumerable<Dish> GetAllDishes()
        {
            return DishDB.GetAllDishes().ToArray();
        }

        // Get Single
        [HttpGet]
        [Route("GetDishById")]
        public ActionResult<Dish> GetDishById(int DishId)
        {
            return DishDB.GetDishById(DishId);
        }

        // Add
        [HttpPost]
        [Route("AddDish")]
        public string AddDish()
        {
            return "";
        }

        // Delete
        [HttpDelete]
        [Route("DeleteDishById")]
        public ActionResult<Dish> DeleteDishById(int DishId)
        {
            return DishDB.DeleteDishById(DishId);
        }

        // Edit
        [HttpPut]
        [Route("EditDishById")]
        public ActionResult<Dish> EditDishById(int DishId)
        {
            return DishDB.EditDishById(DishId);
        }
    }
}