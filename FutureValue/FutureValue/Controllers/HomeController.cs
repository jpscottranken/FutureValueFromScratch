using FutureValue.Models;
using Microsoft.AspNetCore.Mvc;

namespace FutureValue.Controllers
{
    public class HomeController : Controller
    {
        //  Display the form (View)
        [HttpGet]
        public IActionResult Index()
        {
            //  Start with "clean slate"
            ViewBag.futureValue = 0;
            return View();
        }

        //  Submit the form (View)
        [HttpPost]
        public IActionResult Index(FutureValueModel fv)
        {
            //  Validate data
            if (ModelState.IsValid)
            {
                ViewBag.FutureValue = fv.CalculateFutureValue();
            }
            else
            {
                ViewBag.FutureValue = 0;
            }

            //  Add fv to the () below
            return View(fv);
        }
    }
}
