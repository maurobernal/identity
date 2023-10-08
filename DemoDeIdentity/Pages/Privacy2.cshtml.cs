using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DemoDeIdentity.Pages;

[Authorize( Roles ="admin")]
public class Privacy2Model : PageModel
{
    private readonly ILogger<Privacy2Model> _logger;

    public Privacy2Model(ILogger<Privacy2Model> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}
