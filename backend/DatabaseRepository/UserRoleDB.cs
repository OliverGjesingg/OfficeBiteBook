using backend.Models;
using backend.DatabaseRepository;

namespace backend.DatabaseRepository
{
    public class UserRoleDB
    {
        // Get All
        public static List<UserRole> GetAllUserRoles()
        {
            List<UserRole> list = new List<UserRole>();
            /* We make a new list where we will use the structure of the "User Model." 
            Afterwards, we "pump" it with the data we returned inside "GetAllUsers()". */
            List<User> user = UserDB.GetAllUsers();
            List<Role> role = RoleDB.GetAllRoles();

            if (user != null && role != null && user.Count > 0 && role.Count > 0)
            {
                UserRole userRole1 = new UserRole();
                userRole1.UserId = user[0].UserId;
                userRole1.RoleId = role[0].RoleId;
                userRole1.UserName = user[0].UserName;
                userRole1.RoleName = role[0].RoleName;
                list.Add(userRole1);

                UserRole userRole2 = new UserRole();
                userRole2.UserId = user[1].UserId;
                userRole2.RoleId = role[1].RoleId;
                userRole2.UserName = user[1].UserName;
                userRole2.RoleName = role[1].RoleName;
                list.Add(userRole2);

                UserRole userRole3 = new UserRole();
                userRole3.UserId = user[2].UserId;
                userRole3.RoleId = role[2].RoleId;
                userRole3.UserName = user[2].UserName;
                userRole3.RoleName = role[2].RoleName;
                list.Add(userRole3);
            }

            return list;

        }

        // Get Single
        public static UserRole GetUserRoleById(int UserRoleId)
        {
            var userRole = new UserRole();
            userRole = GetAllUserRoles().Where(p => p.UserId == UserRoleId).FirstOrDefault();

            return userRole;
        }
    }
}
