using BlogProject.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject.PresentationLayer.ViewComponents.ArticleDetailViewComponents
{
    public class _ArticleDetailContentComponentPartial: ViewComponent
    {
        private readonly IArticleService _articleService;

        public _ArticleDetailContentComponentPartial(IArticleService articleService)
        {
            _articleService = articleService;
        }

        public IViewComponentResult Invoke(int id)
        {
            var value=_articleService.TGetArticleWithAuthorAndCategoryById(id);
            return View(value);
        }
    } 
}
