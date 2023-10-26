using backend.Models;

namespace backend.DatabaseRepository
{
    public class RoleDB
    {
        // Get All
        public static List<Role> GetAllRoles()
        {
            List<Role> list = new List<Role>();

            Role role1 = new Role();
            role1.RoleId = 1;
            role1.RoleName = "Admin";
            list.Add(role1);

            Role role2 = new Role();
            role2.RoleId = 2;
            role2.RoleName = "Superuser";
            list.Add(role2);

            Role role3 = new Role();
            role3.RoleId = 3;
            role3.RoleName = "User";
            list.Add(role3);

            return list;
        }

        // Get Single
        public static Role GetRoleById(int RoleId)
        {
            var role = new Role();
            role = GetAllRoles().Where(p => p.RoleId == RoleId).FirstOrDefault();

            return role;
        }

        // Delete
        public static Role DeleteRoleById(int RoleId)
        {
            var role = new Role();
            role = GetAllRoles().Where(p => p.RoleId == RoleId).FirstOrDefault();

            return role;
        }

        // Edit
        public static Role EditRoleById(int RoleId)
        {
            var role = new Role();
            role = GetAllRoles().Where(p => p.RoleId == RoleId).FirstOrDefault();

            return role;
        }
    }
}
