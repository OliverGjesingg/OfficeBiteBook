using backend.Models;
using System.Data;

namespace backend.DatabaseRepository
{
    public class MenuTemplateDishDB
    {
        // Get All
        public static List<MenuTemplateDish> GetAllMenuTemplateDishes()
        {
            List<MenuTemplateDish> list = new List<MenuTemplateDish>();
            List<MenuTemplate> menuTemplate = MenuTemplateDB.GetAllMenuTemplates();
            List<Dish> dish = DishDB.GetAllDishes();

            if (menuTemplate != null && dish != null && menuTemplate.Count > 0 && dish.Count > 0)
            {
                for (int i = 0; i < menuTemplate.Count && i < dish.Count; i++)
                {
                    MenuTemplateDish menuTemplateDish = new MenuTemplateDish
                    {
                        TemplateId = menuTemplate[i].TemplateId,
                        DishId = dish[i].DishId,
                    };
                    list.Add(menuTemplateDish);
                }
            }

            return list;
        }

        // Get Single
        public static MenuTemplateDish GetMenuTemplateDishById(int MenuTemplateDishId)
        {
            var menuTemplateDish = new MenuTemplateDish();
            menuTemplateDish = GetAllMenuTemplateDishes().Where(p => p.TemplateId == MenuTemplateDishId).FirstOrDefault();

            return menuTemplateDish;
        }

        // Delete
        public static MenuTemplateDish DeleteMenuTemplateDishById(int MenuTemplateDishId)
        {
            var menuTemplateDish = new MenuTemplateDish();
            menuTemplateDish = GetAllMenuTemplateDishes().Where(p => p.TemplateId == MenuTemplateDishId).FirstOrDefault();

            return menuTemplateDish;
        }

        // Edit
        public static MenuTemplateDish EditMenuTemplateDishById(int MenuTemplateDishId)
        {
            var menuTemplateDish = new MenuTemplateDish();
            menuTemplateDish = GetAllMenuTemplateDishes().Where(p => p.TemplateId == MenuTemplateDishId).FirstOrDefault();

            return menuTemplateDish;
        }
    }
}