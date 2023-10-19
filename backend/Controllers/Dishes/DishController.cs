using backend.DatabaseRepository;
using backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace DishesController
{
    [ApiController]
    [Route("[controller]")]
    public class DishController : ControllerBase
    {
        private readonly ILogger<DishController> _logger;

        public DishController(ILogger<DishController> logger)
        {
            _logger = logger;
        }

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
        public ActionResult<Dish> GetDishById(int GetDishId)
        {
            return DishDB.GetDishById(GetDishId);
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
        public ActionResult<Dish> DeleteDishById(int DeleteDishId)
        {
            return DishDB.DeleteDishById(DeleteDishId);
        }

        // Edit
        [HttpPut]
        [Route("EditDishById")]
        public ActionResult<Dish> EditDishById(int EditDishId)
        {
            return DishDB.EditDishById(EditDishId);
        }
    }
}