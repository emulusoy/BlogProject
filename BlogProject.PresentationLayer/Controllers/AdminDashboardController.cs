using BlogProject.EntityLayer.Entities;
using BlogProject.PresentationLayer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.General;

namespace BlogProject.PresentationLayer.Controllers
{
    public class AdminDashboardController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public AdminDashboardController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Profile()
        {
            var user = await _userManager.GetUserAsync(User);

            if (user == null)
            {
                return NotFound();
            }

            var model = new AdminProfileUpdateViewModel
            {
                Name = user.Name,
                Surname = user.Surname,
                ImageUrl = user.ImageUrl,
                Email = user.Email,
                Username = user.UserName,
                Description = user.Description
            };

            return View(model);
        }

        // POST: Profil güncelleme
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Profile(AdminProfileUpdateViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await _userManager.GetUserAsync(User);

            if (user == null)
            {
                return NotFound();
            }

            // Temel bilgileri güncelle
            user.Name = model.Name;
            user.Surname = model.Surname;
            user.ImageUrl = model.ImageUrl;
            user.Email = model.Email;
            user.UserName = model.Username;
            user.Description = model.Description;

            // Şifre değişikliği istenmişse
            if (!string.IsNullOrEmpty(model.NewPassword))
            {
                // Mevcut şifreyi doğrula
                var passwordCheck = await _userManager.CheckPasswordAsync(user, model.CurrentPassword);

                if (!passwordCheck)
                {
                    ModelState.AddModelError(string.Empty, "Mevcut şifre yanlış.");
                    return View(model);
                }

                // Yeni şifreyi ayarla
                var changePasswordResult = await _userManager.ChangePasswordAsync(user, model.CurrentPassword, model.NewPassword);

                if (!changePasswordResult.Succeeded)
                {
                    foreach (var error in changePasswordResult.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                    return View(model);
                }

                // Şifre değiştiği için yeniden giriş yap
                await _signInManager.RefreshSignInAsync(user);
            }

            // Kullanıcı bilgilerini güncelle
            var updateResult = await _userManager.UpdateAsync(user);

            if (!updateResult.Succeeded)
            {
                foreach (var error in updateResult.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
                return View(model);
            }

            TempData["SuccessMessage"] = "Profil bilgileriniz başarıyla güncellendi.";
            return RedirectToAction(nameof(Profile));
        }
    }
}
