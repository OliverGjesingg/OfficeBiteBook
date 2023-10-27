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
                for (int i = 0; i < menu.Count && i < dish.Count; i++)
                {
                    MenuDish menuDish = new MenuDish
                    {
                        MenuId = menu[i].MenuId,
                        MenuTitle = menu[i].MenuTitle,
                        DishId = dish[i].DishId,
                        DishTitle = dish[i].DishTitle
                    };
                    list.Add(menuDish);
                }
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
