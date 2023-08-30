using Microsoft.AspNetCore.Mvc;
using FutureValue.Models;

namespace FutureValue.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.FutureValue = "";
            return View();
        }

        [HttpPost]
        public IActionResult Index(FutureValueModel fv)
        {
            if (ModelState.IsValid)
            {
                ViewBag.FutureValue = fv.CalculateFutureValue()?.ToString("c") ?? string.Empty;
            }
            else
            {
                ViewBag.FutureValue = "";
            }

            return View();
        }
    }
}