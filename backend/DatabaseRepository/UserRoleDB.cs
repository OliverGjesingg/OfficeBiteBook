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
                /* Instead of writing each of our users manually, one for one, we can rather, 
                and more simply, loop all that exist out from the UserDB & RoleDB.
                This also make it easier to automatically retrieve new users & roles if added in the future. */
                for (int i = 0; i < user.Count && i < role.Count; i++)
                {
                    UserRole userRole = new UserRole
                    {
                        UserId = user[i].UserId,
                        UserName = user[i].UserName,
                        RoleId = role[i].RoleId,
                        RoleName = role[i].RoleName
                    };
                    list.Add(userRole);
                }
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
