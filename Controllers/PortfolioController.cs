using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace PortfolioWebsite.Controllers
{
    public class PortfolioController : Controller
    {
        public IActionResult Home()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Projects()
        {
            return View();
        }

        public IActionResult Skills()
        {
            return View();
        }

        public IActionResult Certificates()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult DownloadResume()
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "files", "My Resume placement.pdf");
            if (!System.IO.File.Exists(filePath))
            {
                return NotFound("Resume file not found.");
            }

            var fileBytes = System.IO.File.ReadAllBytes(filePath);
            return File(fileBytes, "application/pdf", "My Resume placement.pdf");
        }
    }
}