using backend.Models;
using backend.DatabaseRepository;

namespace backend.DatabaseRepository
{
    public class MenuDishDB
    {
        // Get All
        public static List<MenuDish> GetAllMenuDishes()
        {
            List<MenuDish> list = new List<MenuDish>();
            List<Menu> menu = MenuDB.GetAllMenus();
            List<Dish> dish = DishDB.GetAllDishes();

            if (menu != null && dish != null && menu.Count > 0 && dish.Count > 0)
            {
                MenuDish menuDish1 = new MenuDish();
                menuDish1.MenuId = menu[0].MenuId;
                menuDish1.MenuTitle = menu[0].MenuTitle;
                menuDish1.DishId = dish[0].DishId;
                menuDish1.DishTitle = dish[0].DishTitle;
                list.Add(menuDish1);

                MenuDish menuDish2 = new MenuDish();
                menuDish2.MenuId = menu[1].MenuId;
                menuDish2.MenuTitle = menu[1].MenuTitle;
                menuDish2.DishId = dish[1].DishId;
                menuDish2.DishTitle = dish[1].DishTitle;
                list.Add(menuDish2);

                MenuDish menuDish3 = new MenuDish();
                menuDish3.MenuId = menu[2].MenuId;
                menuDish3.MenuTitle = menu[2].MenuTitle;
                menuDish3.DishId = dish[2].DishId;
                menuDish3.DishTitle = dish[2].DishTitle;
                list.Add(menuDish3);
            }

            return list;

        }

        // Get Single
        public static MenuDish GetMenuDishById(int MenuDishId)
        {
            var menuDish = new MenuDish();
            menuDish = GetAllMenuDishes().Where(p => p.MenuId == MenuDishId).FirstOrDefault();

            return menuDish;
        }
    }
}
