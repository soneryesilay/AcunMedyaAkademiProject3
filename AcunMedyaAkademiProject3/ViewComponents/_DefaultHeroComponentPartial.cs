using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaAkademiProject3.ViewComponents
{
    public class _DefaultHeroComponentPartial  : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
