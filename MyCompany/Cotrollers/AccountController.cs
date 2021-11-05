using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyCompany.Models;

namespace MyCompany.Cotrollers
{
    [Authorize]
    public class AccountController
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;
        public AccountController(UserManager<IdentityUser> userMng, SignInManager<IdentityUser> signInMng)
        {
            userManager = userMng;
            signInManager = signInMng;
        }
    }

    [AllowAnonymous]
    public IActionResult Login()
    {
        ViewBag.returnUrl = retutnUrl;
        return View(new LoginViewModel);
    }

    [HttpPost]
    [AllowAnonymous]
    public async Task<IActionResult> Login(LoginViewModel model, string returnUrl)
    {
        if (ModelState.IsValid)
        {

        }
    }
}
