using Microsoft.AspNetCore.Mvc;

namespace BlogProject.PresentationLayer.ViewComponents.ArticleDetailViewComponents
{
    public class _ArticleDetailAddCommentComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            ViewBag.id = id;
            return View(); 
        }
    }
}
