using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SuperheroSocialClub.Pages
{
    public class IndexModel : PageModel
    {
        public static bool isLoggedIn { get; set; } = false;
        public int SuperHeroId { get; set; } = 1;
        public IActionResult OnGet()
        {
            if (!isLoggedIn)
            {
                return RedirectToPage("/auth/login");
            }
            return Page();
        }
    }
}
