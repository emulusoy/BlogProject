using Microsoft.AspNetCore.Mvc;

namespace BlogProject.PresentationLayer.ViewComponents
{
    public class _FooterDefaultComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
