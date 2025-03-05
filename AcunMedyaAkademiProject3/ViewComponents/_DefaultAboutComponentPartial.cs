using AcunMedyaAkademiProject3.Context;
using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaAkademiProject3.ViewComponents
{
    public class _DefaultAboutComponentPartial : ViewComponent
    {
        #region Dependency Injection

        private readonly ProjectContext _context;
        
        //constractor
        public _DefaultAboutComponentPartial(ProjectContext context)
        {
            _context = context;
        }

        #endregion

        public IViewComponentResult Invoke()
        {
            var values = _context.Abouts.ToList();
            return View(values);
        }
    }
}
