using backend.Models;
using System.Runtime.Intrinsics.X86;

namespace backend.DatabaseRepository
{
    public class MenuDB
    {
        // Get All
        public static List<Menu> GetAllMenus()
        {
            List<Menu> list = new List<Menu>();
            List<LocationRoom> locationRoom = LocationRoomDB.GetAllLocationRooms();
            List<MenuType> menuType = MenuTypeDB.GetAllMenuTypes();
            List<MenuTemplate> menuTemplate = MenuTemplateDB.GetAllMenuTemplates();

            Menu menu1 = new Menu();
            menu1.MenuId = 1;
            menu1.MenuTypeId = menuType[0].MenuTypeId;
            menu1.RoomId = locationRoom[0].LocationId;
            menu1.MenuPublished = true;
            menu1.MenuTitle = menuTemplate[0].Title;
            menu1.MenuStartDate = "26-10-2023";
            menu1.MenuEndDate = "26-10-2023";
            list.Add(menu1);

            Menu menu2 = new Menu();
            menu2.MenuId = 2;
            menu2.MenuTypeId = menuType[1].MenuTypeId;
            menu2.RoomId = locationRoom[1].LocationId;
            menu2.MenuPublished = false;
            menu2.MenuTitle = menuTemplate[1].Title;
            menu2.MenuStartDate = "27-10-2023";
            menu2.MenuEndDate = "27-10-2023";
            list.Add(menu2);

            Menu menu3 = new Menu();
            menu3.MenuId = 3;
            menu3.MenuTypeId = menuType[2].MenuTypeId;
            menu3.RoomId = locationRoom[2].LocationId;
            menu3.MenuPublished = true;
            menu3.MenuTitle = menuTemplate[2].Title;
            menu3.MenuStartDate = "29-10-2023";
            menu3.MenuEndDate = "29-10-2023";
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
