using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace duzce_uni.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [Authorize]
        public IActionResult AdminYonetim()
        {
            return View();
        }
    }
}
