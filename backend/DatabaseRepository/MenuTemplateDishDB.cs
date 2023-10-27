using backend.Models;

namespace backend.DatabaseRepository
{
    public class MenuTemplateDishDB
    {
        // Get All
        public static List<MenuTemplateDish> GetAllMenuTemplateDishes()
        {
            List<MenuTemplateDish> list = new List<MenuTemplateDish>();

            MenuTemplateDish menuTemplateDish1 = new MenuTemplateDish();
            menuTemplateDish1.TemplateId = 1;
            menuTemplateDish1.TemplateTitle = "The Morning Grand Feast";
            menuTemplateDish1.DishId = 1;
            menuTemplateDish1.DishTitle = "Eggs & Bacon";
            list.Add(menuTemplateDish1);

            MenuTemplateDish menuTemplateDish2 = new MenuTemplateDish();
            menuTemplateDish2.TemplateId = 2;
            menuTemplateDish2.TemplateTitle = "The Lunch Devour";
            menuTemplateDish2.DishId = 2;
            menuTemplateDish2.DishTitle = "So much salad... and so much spaghetti!";
            list.Add(menuTemplateDish2);

            MenuTemplateDish menuTemplateDish3 = new MenuTemplateDish();
            menuTemplateDish3.TemplateId = 3;
            menuTemplateDish3.TemplateTitle = "The Lunch Devour";
            menuTemplateDish3.DishId = 3;
            menuTemplateDish3.DishTitle = "So much salad... and so much spaghetti!";
            list.Add(menuTemplateDish3);

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