using SuperheroSocialClub.Models;

namespace SuperheroSocialClub.Managers
{
    public static class UserManager
    {
        public static List<UserModel> Users { get; set; } = new()
        {
            new UserModel { Id = 1, Password = "pass", Username = "user" }
        };
    }
}
