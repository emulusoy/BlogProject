using Microsoft.AspNetCore.Mvc;

namespace BlogProject.PresentationLayer.ViewComponents.ArticleDetailViewComponents
{
    public class _ArticleDetailContentComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    } 
}
