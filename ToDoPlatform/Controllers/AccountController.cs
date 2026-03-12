
using Microsoft.AspNetCore.Mvc;


namespace ToDoPlatform.Controllers;

public class AccountControllers : Controller
{
    private readonly ILogger<AccountControllers> _logger;

    public AccountControllers(ILogger<AccountControllers> logger)
    {
        _logger = logger;
    }

    public IActionResult Login()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View("Error!");
    }
}
