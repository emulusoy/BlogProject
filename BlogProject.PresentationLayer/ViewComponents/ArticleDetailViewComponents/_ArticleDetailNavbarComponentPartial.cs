using Microsoft.AspNetCore.Mvc;

namespace BlogProject.PresentationLayer.ViewComponents.ArticleDetailViewComponents
{
    public class _ArticleDetailNavbarComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
