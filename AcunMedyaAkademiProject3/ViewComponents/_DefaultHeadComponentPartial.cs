using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaAkademiProject3.ViewComponents
{
    public class _DefaultHeadComponentPartial : ViewComponent
    {
         public IViewComponentResult Invoke()
         {
            return View();
         }
        
    }
}
