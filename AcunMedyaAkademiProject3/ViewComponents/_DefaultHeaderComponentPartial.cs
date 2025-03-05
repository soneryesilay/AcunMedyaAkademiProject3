using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaAkademiProject3.ViewComponents
{
    public class _DefaultHeaderComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
