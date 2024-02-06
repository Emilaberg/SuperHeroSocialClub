using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SuperheroSocialClub.Pages
{
    public class EditModel : PageModel
    {
        //public SuperHero Superhero { get; set; }
        public int Id { get; set; }
        public void OnGet(int id)
        {
            //get the specified superhero from superheromanager
            Id = id;
        }
    }
}
