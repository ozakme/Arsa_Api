using ArsaProject.EntityLayer.Concrete;
using ArsaProject.WebUI.Dtos.RegisterDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ArsaProject.WebUI.Controllers
{
    public class RegisterController : Controller
    {
        //[AllowAnonymous]
       
            private readonly UserManager<AppUser> _userManager;
            public RegisterController(UserManager<AppUser> userManager)
            {
                _userManager = userManager;
            }
            [HttpGet]
            public IActionResult Index()
            {
                return View();
            }

            [HttpPost]
            public async Task<IActionResult> Index(CreateNewUserDto createNewUserDto)
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }
                var appUser = new AppUser()
                {
                    Name = createNewUserDto.Name,
                    Email = createNewUserDto.Mail,
                    Surname = createNewUserDto.Surname,
                    UserName = createNewUserDto.Username,
                   // WorkLocationID = 1
                };
                var result = await _userManager.CreateAsync(appUser, createNewUserDto.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Login");
                }
                return View();
            }
        }
    }
