using BlogProject.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject.PresentationLayer.ViewComponents.ArticleDetailViewComponents
{
    public class _ArticleDetailCommentComponentPartial:ViewComponent
    {
        private readonly ICommentService _commentService;

        public _ArticleDetailCommentComponentPartial(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public IViewComponentResult Invoke(int id)
        {
            var values = _commentService.TGetCommentsByArticleId(id);
            return View(values);
        }
    }
}
