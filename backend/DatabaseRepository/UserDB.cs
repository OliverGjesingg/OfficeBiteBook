using backend.Models;

namespace backend.DatabaseRepository
{
    public class UserDB
    {
        // Get All
        public static List<User> GetAllUsers()
        {
            List<User> list = new List<User>();

            User user1 = new User();
            user1.UserId = 1;
            user1.UserName = "Frank Reynolds";
            user1.UserEmail = "real-frank-reynolds@gmail.com";
            user1.UserPhone = "+45 4450 4450";
            user1.UserBirthday = "12-12-1965";
            user1.UserImage = "url_to_user_profile_picture";
            list.Add(user1);

            User user2 = new User();
            user2.UserId = 2;
            user2.UserName = "Charlie Kelly";
            user2.UserEmail = "rat-king@outlook.com";
            user2.UserPhone = "+44 5555 5555";
            user2.UserBirthday = "19-08-1987";
            user2.UserImage = "url_to_user_profile_picture";
            list.Add(user2);

            User user3 = new User();
            user3.UserId = 3;
            user3.UserName = "Dennis Reynolds";
            user3.UserEmail = "the-implication@email.com";
            user3.UserPhone = "+40 6666 6666";
            user3.UserBirthday = "16-06-1966";
            user3.UserImage = "url_to_user_profile_picture";
            list.Add(user3);

            return list;
        }

        // Get Single
        public static User GetUserById(int UserId)
        {
            var user = new User();
            user = GetAllUsers().Where(p => p.UserId == UserId).FirstOrDefault();

            return user;
        }

        // Delete
        public static User DeleteUserById(int UserId)
        {
            var user = new User();
            user = GetAllUsers().Where(p => p.UserId == UserId).FirstOrDefault();

            return user;
        }

        // Edit
        public static User EditUserById(int UserId)
        {
            var user = new User();
            user = GetAllUsers().Where(p => p.UserId == UserId).FirstOrDefault();

            return user;
        }
    }
}
