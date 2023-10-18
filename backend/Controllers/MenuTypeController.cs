using backend.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MenuTypeController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public MenuTypeController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }


        [HttpGet]
        [Route("GetAllMenuTypes")]
        public IEnumerable<MenuType> GetAllMenuTypes()
        {
            List<MenuType> list = new List<MenuType>();
            MenuType type = new MenuType();
            type.Name = "Breakfeast";
            type.MenuTypeId = 1;
            type.DefaultStartTime = "08:00";
            type.DefaultEndTime = "09:00";
            MenuType type1 = new MenuType();
            type1.Name = "Lunch";
            type1.MenuTypeId = 2;
            type1.DefaultStartTime = "11:00";
            type1.DefaultEndTime = "13:00";
            list.Add(type);
            list.Add(type1);
            return list.ToArray();
        }
        [HttpGet]
        [Route("GetString")]
        public string GetString()
        {
            return "";
        }
        [HttpGet]
        [Route("GetMenuTypeById")]
        public string GetMenuTypeById(int MenuTypeId)
        {
            return "";
        }
        // AddMenuType
        // DeleteMenuType
        // EditMenuType
    }
}