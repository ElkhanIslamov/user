using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;
using ProniaP336.Models;

namespace ProniaP336.Controllers;

public class UserController : Controller
{
    private readonly UserManager<AppUser> _userManager;

    public UserController(UserManager<AppUser> userManager)
    {
        _userManager = userManager;
    }

    public IActionResult Register()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> Result (RegisterViewModel registerViewModel)
    {
        if(!ModelState.IsValid )
        {
            return View();
        }
        AppUser appUser = new AppUser()
        {
            Fullname = registerViewModel.Fullname,
            Username = registerViewModel.Username,
            Email = registerViewModel.Email,
            IsActive = true
        };

        await _userManager.CreateAsync(appUser,registerViewModel.Password);


        return RedirectToAction("Index", "Home");
    }

}
