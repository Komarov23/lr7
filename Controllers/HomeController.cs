using Microsoft.AspNetCore.Mvc;

namespace lr7.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DownloadFile(string firstName, string lastName, string fileName)
        {
            System.IO.File.WriteAllText($"App_Data/{fileName}.txt", $"Ім'я: {firstName}\nПрізвище: {lastName}");
            return PhysicalFile(Path.Combine(Directory.GetCurrentDirectory(), $"App_Data/{fileName}.txt"), "text/plain", $"{fileName}.txt");
        }
    }
}