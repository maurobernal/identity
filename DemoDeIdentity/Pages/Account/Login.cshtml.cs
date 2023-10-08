using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DemoDeIdentity.Identity.Account;
using DemoDeIdentity.Pages.Account;

namespace DemoDeIdentity.Identity.Account;

[AllowAnonymous]
public class LoginModel : PageModel
{
    private readonly UserManager<MyUser> _userManager;
    private readonly SignInManager<MyUser> _signInManager;

    public LoginModel(
        UserManager<MyUser> userManager, 
        SignInManager<MyUser> signInManager)
    {
        _userManager = userManager;
        _signInManager = signInManager;
    }

    [BindProperty]
    public LoginDTO Login { get; set; }


    public void OnGet()
    {
    }

    public async Task<IActionResult> OnPostAsync()
    {
        var res = await _signInManager
            .PasswordSignInAsync(Login.Email, Login.Password, true, true);

        return LocalRedirect("/");
    }
}