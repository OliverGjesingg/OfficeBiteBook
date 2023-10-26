using backend.Models;

namespace backend.DatabaseRepository
{
    public class MenuDB
    {
        // Get All
        public static List<Menu> GetAllMenus()
        {
            List<Menu> list = new List<Menu>();

            Menu menu1 = new Menu();
            menu1.MenuId = 1;
            menu1.MenuTypeId = 1;
            menu1.MenuRoomId = 1;
            menu1.MenuPublished = true;
            menu1.MenuTitle = "Fælles Frokost";
            menu1.MenuStartDate = "26-10-2023";
            menu1.MenuEndDate = "26-10-2023";
            menu1.MenuStartTime = "12:00";
            menu1.MenuEndTime = "13:00";
            list.Add(menu1);

            Menu menu2 = new Menu();
            menu2.MenuId = 2;
            menu2.MenuTypeId = 2;
            menu2.MenuRoomId = 2;
            menu2.MenuPublished = false;
            menu2.MenuTitle = "Fælles Morgenmad!";
            menu2.MenuStartDate = "27-10-2023";
            menu2.MenuEndDate = "27-10-2023";
            menu2.MenuStartTime = "09:00";
            menu2.MenuEndTime = "10:00";
            list.Add(menu2);

            Menu menu3 = new Menu();
            menu3.MenuId = 3;
            menu3.MenuTypeId = 3;
            menu3.MenuRoomId = 3;
            menu3.MenuPublished = true;
            menu3.MenuTitle = "Madklubben - Hygge aften!";
            menu3.MenuStartDate = "29-10-2023";
            menu3.MenuEndDate = "29-10-2023";
            menu3.MenuStartTime = "17:00";
            menu3.MenuEndTime = "20:00";
            list.Add(menu3);

            return list;
        }

        // Get Single
        public static Menu GetMenuById(int MenuId)
        {
            var menu = new Menu();
            menu = GetAllMenus().Where(p => p.MenuId == MenuId).FirstOrDefault();

            return menu;
        }

        // Delete
        public static Menu DeleteMenuById(int MenuId)
        {
            var menu = new Menu();
            menu = GetAllMenus().Where(p => p.MenuId == MenuId).FirstOrDefault();

            return menu;
        }

        // Edit
        public static Menu EditMenuById(int MenuId)
        {
            var menu = new Menu();
            menu = GetAllMenus().Where(p => p.MenuId == MenuId).FirstOrDefault();

            return menu;
        }
    }
}
