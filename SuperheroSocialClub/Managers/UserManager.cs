using SuperheroSocialClub.Models;

namespace SuperheroSocialClub.Managers
{
    public static class UserManager
    {
        private static int UserId = 0;

        public static UserModel? SignedInUser { get; set; }


        public static List<UserModel> Users { get; set; } = new()
        {
            new UserModel { Id = GenerateUserId(), Password = "pass", Username = "user" }
        };

        public static bool ValidateUsername(string username)
        {
            bool isValidUsername = false;

            foreach (var user in Users)
            {
                if (user.Username == username)
                {
                    isValidUsername = true;
                }
            }
            return isValidUsername;
        }

        public static UserModel? RegisterUser(string username, string password)
        {
            if (ValidateUsername(username) == false)
            {
                UserModel newUser = new UserModel
                {
                    Id = GenerateUserId(),
                    Password = password,
                    Username = username,
                };

                Users.Add(newUser);

                return newUser;
            }

            return null;

        }

        public static int GenerateUserId()
        {
            return UserId++;
        }

        public static bool SignInUser(string username, string password)
        {
            foreach (UserModel user in Users)
            {
                if (user.Username == username && user.Password == password)
                {
                    // user found!
                    SignedInUser = user;

                    return true;
                }
            }

            return false;
        }


    }
}
