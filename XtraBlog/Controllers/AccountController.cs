using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Buffers.Text;
using XtraBlog.DAL;
using XtraBlog.Model;
using XtraBlog.VM;

namespace XtraBlog.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signinManager;
        private readonly ApplicationContext _context;
        public AccountController(UserManager<AppUser> userManager,SignInManager<AppUser>sign, ApplicationContext context)
        {
            _userManager = userManager;
            _signinManager = sign;
            _context = context;
        }
        public async Task<IActionResult> CreateUser()
        {
            AppUser appUser = new AppUser
            {
                FullName = "Admin",
                Email = "admin@admin.com",
                UserName = "Superadmin",
            };
            await _userManager.CreateAsync(appUser, "admin123");
            //_context.Users.Add(appUser);
            //_context.SaveChanges();
            return Content("User hasbeen created");
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVm loginVm)
        {
            if(!ModelState.IsValid) return View();
            AppUser user=await _userManager.FindByEmailAsync(loginVm.Email);
            if(user == null) 
            {
                ModelState.AddModelError(" ", "Email or Password not correct!");
                return View();  
            };
            var result = await _signinManager.PasswordSignInAsync(user, loginVm.Password, true, false);
            if (!result.Succeeded)
            {
                ModelState.AddModelError(" ", "Email or password is incorrect!");
                return View();
            }
            return RedirectToAction("Index", "Dashboard", new { Area="manage"});
        }
        public async Task<IActionResult> Logout()
        {
            await _signinManager.SignOutAsync();
            return RedirectToAction("Index", "home");
        }
    }
}
