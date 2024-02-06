using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SuperheroSocialClub.Managers;
using SuperheroSocialClub.Models;

namespace SuperheroSocialClub.Pages.Auth
{
    [BindProperties]
    public class RegisterModel : PageModel
    {
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string ConfirmPassword { get; set; } = null!;

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if(Password != ConfirmPassword)
            {
                return Page();
            }

            UserModel? newUser = UserManager.RegisterUser(Username, Password);
            if (newUser == null)
            {
                return Page();
            }

            UserManager.SignedInUser = newUser;

            return RedirectToPage("/Index", UserManager.SignedInUser!.Id);
        }
    }
}
