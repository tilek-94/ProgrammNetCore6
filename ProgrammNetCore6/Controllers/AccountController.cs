using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProgrammNetCore6.Data;
using ProgrammNetCore6.Data.StaticClass;
using ProgrammNetCore6.Models;
using ProgrammNetCore6.Models.Dto;
using System.Threading.Tasks;

namespace ProgrammNetCore6.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly AppDbContext _context;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, AppDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
        }
        public async Task<IActionResult> Users()
        {
            var users = await _context.Users.ToListAsync();
            return View(users);
        }
        public IActionResult Login() =>  View(new LoginDto());

        [HttpPost]
        public async Task<IActionResult> Login(LoginDto loginDto)
        {
            if (!ModelState.IsValid) return View(loginDto);

            var user = await _userManager.FindByEmailAsync(loginDto.EmailAddress);
            if (user != null)
            {
                var passwordCheck = await _userManager.CheckPasswordAsync(user, loginDto.Password);
                if (passwordCheck)
                {
                    var result = await _signInManager.PasswordSignInAsync(user, loginDto.Password, false, false);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
                TempData["Error"] = "Неправильные учетные данные. Пожалуйста, попробуйте еще раз!";
                return View(loginDto);
            }

            TempData["Error"] = "Неправильные учетные данные. Пожалуйста, попробуйте еще раз!";
            return View(loginDto);
        }
        public IActionResult Register() => View(new RegistrDto());

        [HttpPost]
        public async Task<IActionResult> Register(RegistrDto registrDto)
        {
            if (!ModelState.IsValid) return View(registrDto);

            var user = await _userManager.FindByEmailAsync(registrDto.EmailAddress);
            if (user != null)
            {
                TempData["Error"] = "Этот почтовый адрес уже занят";
                return View(registrDto);
            }

            var newUser = new ApplicationUser()
            {
                FullName = registrDto.FullName,
                Email = registrDto.EmailAddress,
                UserName = registrDto.EmailAddress,
                DateOfBirth=registrDto.DateOfBirth,
                PhoneNumber = registrDto.PhoneNumber,
                Address=registrDto.Address,
                EmailConfirmed = true

            };
            var newUserResponse = await _userManager.CreateAsync(newUser, registrDto.Password);

            if (newUserResponse.Succeeded)
                await _userManager.AddToRoleAsync(newUser, UserRoles.User);

            return View("Login");
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult AccessDenied(string ReturnUrl)
        {
            return View();
        }
    }
}
