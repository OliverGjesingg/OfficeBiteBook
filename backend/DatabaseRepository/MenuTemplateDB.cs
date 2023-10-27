using backend.Models;

namespace backend.DatabaseRepository
{
    public class MenuTemplateDB
    {
        // Get All
        public static List<MenuTemplate> GetAllMenuTemplates()
        {
            List<MenuTemplate> list = new List<MenuTemplate>();

            MenuTemplate menuTemplate1 = new MenuTemplate();
            menuTemplate1.TemplateId = 1;
            menuTemplate1.MenuTypeId = 1;
            menuTemplate1.LocationId = 1;
            menuTemplate1.Title = "Morgenmad";
            list.Add(menuTemplate1);

            MenuTemplate menuTemplate2 = new MenuTemplate();
            menuTemplate2.TemplateId = 2;
            menuTemplate2.MenuTypeId = 2;
            menuTemplate2.LocationId = 2;
            menuTemplate2.Title = "Frokost";
            list.Add(menuTemplate2);

            MenuTemplate menuTemplate3 = new MenuTemplate();
            menuTemplate3.TemplateId = 3;
            menuTemplate3.MenuTypeId = 3;
            menuTemplate3.LocationId = 3;
            menuTemplate3.Title = "Aftensmad";
            list.Add(menuTemplate3);

            return list;
        }

        // Get Single
        public static MenuTemplate GetMenuTemplateById(int MenuTemplateId)
        {
            var menuTemplate = new MenuTemplate();
            menuTemplate = GetAllMenuTemplates().Where(p => p.TemplateId == MenuTemplateId).FirstOrDefault();

            return menuTemplate;
        }

        // Delete
        public static MenuTemplate DeleteMenuTemplateById(int MenuTemplateId)
        {
            var menuTemplate = new MenuTemplate();
            menuTemplate = GetAllMenuTemplates().Where(p => p.TemplateId == MenuTemplateId).FirstOrDefault();

            return menuTemplate;
        }

        // Edit
        public static MenuTemplate EditMenuTemplateById(int MenuTemplateId)
        {
            var menuTemplate = new MenuTemplate();
            menuTemplate = GetAllMenuTemplates().Where(p => p.TemplateId == MenuTemplateId).FirstOrDefault();

            return menuTemplate;
        }
    }
}