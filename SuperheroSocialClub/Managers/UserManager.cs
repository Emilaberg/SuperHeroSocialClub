using SuperheroSocialClub.Models;

namespace SuperheroSocialClub.Managers
{
    public static class UserManager
    {
        public static List<UserModel> Users { get; set; } = new()
        {
            new UserModel { Id = 1, Password = "pass", Username = "user" }
        };

        public static bool ValidateUsername(string username)
        {
            bool isValidUsername = true;

            foreach (IUser user in _Users)
            {
                if (user._Username == username)
                {
                    isValidUsername = false;
                }
            }
            return isValidUsername;
        }
    }
}
