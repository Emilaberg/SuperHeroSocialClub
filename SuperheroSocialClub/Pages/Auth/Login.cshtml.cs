using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SuperheroSocialClub.Pages.Auth
{
    [BindProperties]
    public class LoginModel : PageModel
    {
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            //kör validationController
            //om det är korrekt logga in o redirecta till mainpage
            // returnerar ett id som vi kan skicka med
            IndexModel.isLoggedIn = true;
            return RedirectToPage("/Index");
        }
    }
}
