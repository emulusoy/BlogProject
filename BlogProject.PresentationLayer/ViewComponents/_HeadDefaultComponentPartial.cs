using Microsoft.AspNetCore.Mvc;

namespace BlogProject.PresentationLayer.ViewComponents
{
    public class _HeadDefaultComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
