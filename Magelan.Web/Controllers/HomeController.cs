using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Magelan.Domains;
using Magelan.Services;
using Microsoft.AspNetCore.Mvc;
using Magelan.Web.Models;
using Microsoft.Extensions.DependencyInjection;

namespace Magelan.Web.Controllers {
    public class HomeController : Controller {
        private readonly IMagelanService _service;
        
        public HomeController(IMagelanService service) {
            _service = service;
        }

        public IActionResult Index() {
            return View();
        }

        public IActionResult Privacy() {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}