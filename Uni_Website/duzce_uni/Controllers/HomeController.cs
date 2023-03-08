using duzce_uni.Data;
using duzce_uni.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace duzce_uni.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger,ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.duyurulars.ToList());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Duyurular()
        {
            return View(_context.duyurulars.ToList());
        }
        public IActionResult DuyuruDetay(int id)
        {
            var duyuru = _context.duyurulars.Where(x => x.Id == id);
            _context.SaveChanges();
            return View(duyuru.FirstOrDefault());
        }
        public IActionResult Rektor()
        {
            return View();
        }
    }
}