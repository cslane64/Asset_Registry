using AssetRegistry.Data;
using AssetRegistry.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace AssetRegistry.Controllers
{
    public class HomeController : Controller
    {
        private readonly YourDatabaseContext _context;

        public HomeController(YourDatabaseContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var assets = await _context.Assets
                .AsNoTracking()
                .Include(a => a.AssetType)
                .Include(a => a.AssignedUser)
                .Include(a => a.Location)
                .Include(a => a.Status)
                .OrderBy(a => a.AssetId)
                .ToListAsync();

            return View(assets);
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