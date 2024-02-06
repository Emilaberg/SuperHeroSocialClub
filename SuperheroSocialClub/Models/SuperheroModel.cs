namespace SuperheroSocialClub.Models
{
    public class SuperheroModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? SecretIdentity { get; set; }
        public string? Image { get; set; }

        public List<SuperpowerModel> Superpowers { get; set; } = new()
        {

        };

    }
}
