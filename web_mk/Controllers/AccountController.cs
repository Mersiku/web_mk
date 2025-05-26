using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using web_mk.Models.Users;

namespace web_mk.Controllers
{
    public class AccountController : Controller
    {
        UserManager<AppUser> UserManager;

        SignInManager<AppUser> signInManager;

        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            UserManager = userManager;
            this.signInManager = signInManager;
        }

        public async Task <IActionResult> Logout()
        {
            await signInManager.SignOutAsync();

            return RedirectToAction("Index");
        }

        public async Task <IActionResult> Login()
        {
            var result = await signInManager.PasswordSignInAsync("TestUser", "Test", false, false);

            if (result.Succeeded)
            {
                ViewBag.msg = "Pomyślnie zalogowano";
            }else
            {
                ViewBag.msg = "Blędy: " + result;
            }

            return View();
        }

        public async Task <IActionResult> Register()
        {
            var user = await UserManager.FindByNameAsync("TestUser");

            if (user != null)
            {
                ViewBag.msg = "Użytkownik o podanej nazwie już istnieje!";
            }else
            {
                user = new AppUser()
                {
                    UserName = "TestUser",
                    Email = "testuser@ukw.edu.pl",
                    FirstName = "Jan",
                    LastName = "Kowalski"
                };
                var result = await UserManager.CreateAsync(user, "Test");

                ViewBag.msg = result.ToString();

            }

            return View();
        }
    }
}
