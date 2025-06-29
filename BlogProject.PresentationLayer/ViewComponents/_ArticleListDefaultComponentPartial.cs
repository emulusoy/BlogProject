using Microsoft.AspNetCore.Mvc;
using BlogProject.BusinessLayer.Abstract;

namespace BlogProject.PresentationLayer.ViewComponents
{
    public class _ArticleListDefaultComponentPartial : ViewComponent
    {
        private readonly IArticleService _articleService;
        public _ArticleListDefaultComponentPartial(IArticleService articleService)
        {
            _articleService = articleService;
        }
        public IViewComponentResult Invoke()
        {
            var values = _articleService.TGetArticleWithCategoriesAndAppUsers();
            return View(values);
        }
    }
}