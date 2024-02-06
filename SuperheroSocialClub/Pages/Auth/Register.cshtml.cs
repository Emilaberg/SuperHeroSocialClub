using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SuperheroSocialClub.Pages.Auth
{
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
            if(ConfirmPassword == Password) 
            {
                IndexModel.isLoggedIn = true;
                return RedirectToPage("/Index", 1);
            }else
            {
                return Page();
            }
        }
    }
}
