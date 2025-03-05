using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaAkademiProject3.ViewComponents
{
    public class _DefaultFooterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
