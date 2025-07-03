using BlogProject.EntityLayer.Entities;
using BlogProject.PresentationLayer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject.PresentationLayer.Controllers
{
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult UserLogin()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UserLogin(UserLoginViewModel model)
        {
            var result=await _signInManager.PasswordSignInAsync(model.UserName, model.Password,true,false);
            if (result.Succeeded)
            {
                ViewBag.username = model.UserName; // Kullanıcı adını sakla
                return RedirectToAction("Index", "Default");
            }
            else
            {
                ModelState.AddModelError("", "Kullanıcı adı veya şifre hatalı.");
            }
            return View();
        }
    }
}
