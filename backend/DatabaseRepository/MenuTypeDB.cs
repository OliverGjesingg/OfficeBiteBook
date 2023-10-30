using backend.Models;

namespace backend.DatabaseRepository
{
    public class MenuTypeDB
    {
        // Get All
        public static List<MenuType> GetAllMenuTypes()
        {
            List<MenuType> list = new List<MenuType>();

            MenuType type1 = new MenuType();
            type1.MenuTypeId = 1;
            type1.Name = "Breakfast";
            type1.DefaultStart = "08:00";
            type1.DefaultEnd = "09:00";
            list.Add(type1);

            MenuType type2 = new MenuType();
            type2.MenuTypeId = 2;
            type2.Name = "Lunch";
            type2.DefaultStart = "12:00";
            type2.DefaultEnd = "13:00";
            list.Add(type2);

            MenuType type3 = new MenuType();
            type3.MenuTypeId = 3;
            type3.Name = "Dinner";
            type3.DefaultStart = "18:00";
            type3.DefaultEnd = "19:00";
            list.Add(type3);

            return list;
        }

        // Get Single
        public static MenuType GetMenuTypeById(int MenuTypeId)
        {
            var menuType = new MenuType();
            menuType = GetAllMenuTypes().Where(p => p.MenuTypeId == MenuTypeId).FirstOrDefault();

            return menuType;
        }

        // Delete
        public static MenuType DeleteMenuTypeById(int MenuTypeId)
        {
            var menuType = new MenuType();
            menuType = GetAllMenuTypes().Where(p => p.MenuTypeId == MenuTypeId).FirstOrDefault();

            return menuType;
        }

        // Edit
        public static MenuType EditMenuTypeById(int MenuTypeId)
        {
            var menuType = new MenuType();
            menuType = GetAllMenuTypes().Where(p => p.MenuTypeId == MenuTypeId).FirstOrDefault();

            return menuType;
        }
    }
}
