using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaAkademiProject3.ViewComponents
{
    public class _DefaulScriptComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
