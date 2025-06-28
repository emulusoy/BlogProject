using Microsoft.AspNetCore.Mvc;

namespace BlogProject.PresentationLayer.ViewComponents
{
    public class _HeaderDefaultComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
