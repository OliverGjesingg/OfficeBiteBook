using backend.Models;
using backend.DatabaseRepository;
using System.Data;

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
                for (int i = 0; i < menu.Count && i < user.Count; i++)
                {
                    MenuUser menuUser = new MenuUser
                    {
                        MenuId = menu[i].MenuId,
                        MenuTitle = menu[i].MenuTitle,
                        UserId = user[i].UserId,
                        UserName = user[i].UserName
                    };
                    list.Add(menuUser);
                }
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
