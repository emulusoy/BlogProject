using BlogProject.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject.PresentationLayer.Controllers
{
    public class ArticleController : Controller
    {
        private readonly IArticleService _articleService;

        public ArticleController(IArticleService articleService)
        {
            _articleService = articleService;
        }

        public IActionResult ArticleDetail(int id)
        {
            ViewBag.id = id;
            return View();
        }
    }
}
