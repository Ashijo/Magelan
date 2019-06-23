using Magelan.Domains;
using Magelan.Repositories;
using Magelan.Repositories.DbContexts;
using Magelan.Services;
using Magelan.Services.Services;
using Magelan.Web.Models.UserViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Magelan.Web.Controllers {
    public class UserController : Controller {


        [HttpGet]
        public IActionResult Create() {
            return View();
        }

        [HttpPost]
        public IActionResult Create([FromServices] MagelanDbContext context, CreateUserViewModel userViewModel) {
            AspNetUsers user = new AspNetUsers();
            PasswordHasher<AspNetUsers> hasher = new PasswordHasher<AspNetUsers>();

            user.Email = userViewModel.Email;
            user.UserName = userViewModel.UserName;
            user.PhoneNumber = userViewModel.PhoneNumber;
            user.LockoutEnabled = userViewModel.LockoutEnabled;

            UserService.Add(user, userViewModel.Password, context);
            
//            user.AspNetUserRoles = userViewModel.AspNetUserRoles;
            return RedirectToAction("Index", "Home");
        }
        
        // GET
        public IActionResult Index() {
            return View();
        }
    }
}