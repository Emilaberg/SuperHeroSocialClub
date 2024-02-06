using SuperheroSocialClub.Models;

namespace SuperheroSocialClub.Managers
{
    public static class SuperpowerManager
    {
        public static List<SuperpowerModel> Superpowers { get; set; } = new()
        {
            new SuperpowerModel { Id = 1, Name = "Telekinesis" },
            new SuperpowerModel { Id = 2, Name = "Invisibility" },
            new SuperpowerModel { Id = 3, Name = "Super Strength" },
            new SuperpowerModel { Id = 4, Name = "Teleportation" },
            new SuperpowerModel { Id = 5, Name = "Flight" },
            new SuperpowerModel { Id = 6, Name = "Time Manipulation" },
            new SuperpowerModel { Id = 7, Name = "Shape-shifting" },
            new SuperpowerModel { Id = 8, Name = "Mind Reading" },
            new SuperpowerModel { Id = 9, Name = "Super Speed" },
            new SuperpowerModel { Id = 10, Name = "Healing Factor" },
            new SuperpowerModel { Id = 11, Name = "Elemental Control" },
            new SuperpowerModel { Id = 12, Name = "X-ray Vision" },
            new SuperpowerModel { Id = 13, Name = "Telepathy" },
            new SuperpowerModel { Id = 14, Name = "Inhuman Durability" },
            new SuperpowerModel { Id = 15, Name = "Energy Projection" },
            new SuperpowerModel { Id = 16, Name = "Molecular Manipulation" },
            new SuperpowerModel { Id = 17, Name = "Weather Control" },
        };
    }
}
