using Microsoft.AspNetCore.Mvc;

namespace BlogProject.PresentationLayer.ViewComponents.ArticleDetailViewComponents
{
    public class _ArticleDetailAddCommentComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            return View();
        }
    }
}
