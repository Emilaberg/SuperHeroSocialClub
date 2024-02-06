using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SuperheroSocialClub.Managers;
using SuperheroSocialClub.Models;

namespace SuperheroSocialClub.Pages
{
    public class IndexModel : PageModel
    {
        public UserModel? SignedInUser { get; set; }

        public int SuperHeroId { get; set; } = 1;
        public IActionResult OnGet()
        {
            if (UserManager.SignedInUser == null)
            {
                return RedirectToPage("/auth/login");
            }

            SignedInUser = UserManager.SignedInUser;
            return Page();
        }
    }
}
