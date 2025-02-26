using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaAkademiProject3.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
