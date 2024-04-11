using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Zadatak_Novena.Models;
using Zadatak_Novena.Repository;

namespace Zadatak_Novena.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AktualnostiRepository _aktualnostiRepository;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _aktualnostiRepository = new AktualnostiRepository();
        }

        public IActionResult Index()
        {
            ViewBag.Aktualnosti = _aktualnostiRepository.GetAllAktualnosti();

            return View();
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
