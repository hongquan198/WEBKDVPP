using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WKDVPP.Data;
using WKDVPP.Models;

namespace WKDVPP.Controllers
{
    public class HomeController : Controller
    {
        private readonly WKDVPPContext _context;

        public HomeController(WKDVPPContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Product.Include(p => p.category).ToList());
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
    }
}