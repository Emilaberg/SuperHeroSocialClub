using SuperheroSocialClub.Models;

namespace SuperheroSocialClub.Managers
{
    public static class SuperheroManager
    {
        public static List<SuperheroModel> Superheroes { get; set; } = new()
        {
            new SuperheroModel
            {
                Id = 1,
                Name = "Superman",
                SecretIdentity = "Clark Kent",
                Image = "Superman.jpg",
                Superpowers = new List<SuperpowerModel>()
                {
                    SuperpowerManager.Superpowers[3],
                    SuperpowerManager.Superpowers[4],
                    SuperpowerManager.Superpowers[6]
                }
            }
        };
    }
}
