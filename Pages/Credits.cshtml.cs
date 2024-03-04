using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace StudentCrud.Pages;

public class CreditsModel : PageModel
{
    private readonly ILogger<CreditsModel> _logger;

    public CreditsModel(ILogger<CreditsModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

