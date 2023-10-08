using DemoDeIdentity.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
namespace DemoDeIdentity.Pages.Account;

public class LogoutModel : PageModel
{
    private readonly SignInManager<MyUser> _signInManager;
    public LogoutModel(SignInManager<MyUser> signInManager)
    => _signInManager = signInManager;
    

    public void OnGet()
    {
    }

    public async Task<IActionResult> OnPost(string returnUrl = null)
    {
        await _signInManager.SignOutAsync();
     
        if (returnUrl != null)
        {
            return LocalRedirect(returnUrl);
        }
        else
        {
            return Page();
        }
    }
}
