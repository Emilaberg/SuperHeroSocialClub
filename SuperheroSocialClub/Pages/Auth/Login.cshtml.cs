using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SuperheroSocialClub.Managers;

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
            if(!UserManager.ValidateUsername(Username))
            {
                return Page();
                
            }else
            {
                if (!UserManager.SignInUser(Username, Password))
                {
                    return Page();
                }
                return RedirectToPage("/Index", UserManager.SignedInUser!.Id);
            }
        }
    }
}
