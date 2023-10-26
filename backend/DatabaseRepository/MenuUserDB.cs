using backend.Models;
using backend.DatabaseRepository;

namespace backend.DatabaseRepository
{
    public class MenuUserDB
    {
        // Get All
        public static List<MenuUser> GetAllMenuUsers()
        {
            List<MenuUser> list = new List<MenuUser>();
            List<Menu> menu = MenuDB.GetAllMenus();
            List<User> user = UserDB.GetAllUsers();

            if (menu != null && user != null && menu.Count > 0 && user.Count > 0)
            {
                MenuUser menuUser1 = new MenuUser();
                menuUser1.MenuId = menu[0].MenuId;
                menuUser1.MenuTitle = menu[0].MenuTitle;
                menuUser1.UserId = user[0].UserId;
                menuUser1.UserName = user[0].UserName;
                list.Add(menuUser1);

                MenuUser menuUser2 = new MenuUser();
                menuUser2.MenuId = menu[1].MenuId;
                menuUser2.MenuTitle = menu[1].MenuTitle;
                menuUser2.UserId = user[1].UserId;
                menuUser2.UserName = user[1].UserName;
                list.Add(menuUser2);

                MenuUser menuUser3 = new MenuUser();
                menuUser3.MenuId = menu[2].MenuId;
                menuUser3.MenuTitle = menu[2].MenuTitle;
                menuUser3.UserId = user[2].UserId;
                menuUser3.UserName = user[2].UserName;
                list.Add(menuUser3);
            }

            return list;

        }

        // Get Single
        public static MenuUser GetMenuUserById(int MenuUserId)
        {
            var menuUser = new MenuUser();
            menuUser = GetAllMenuUsers().Where(p => p.MenuId == MenuUserId).FirstOrDefault();

            return menuUser;
        }
    }
}
