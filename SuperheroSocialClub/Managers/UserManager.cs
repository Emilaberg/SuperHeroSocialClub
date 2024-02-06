using SuperheroSocialClub.Models;

namespace SuperheroSocialClub.Managers
{
    public class UserManager
    {
        public List<UserModel> Users { get; set; } = new()
        {
            new UserModel { Id = 1, Password = "pass", Username = "user" }
        };
    }
}
