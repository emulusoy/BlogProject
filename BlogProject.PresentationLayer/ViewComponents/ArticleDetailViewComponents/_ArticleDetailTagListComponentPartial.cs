using BlogProject.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject.PresentationLayer.ViewComponents.ArticleDetailViewComponents
{
    public class _ArticleDetailTagListComponentPartial:ViewComponent
    {
        private readonly ITagService _tagService;

        public _ArticleDetailTagListComponentPartial(ITagService tagService)
        {
            this._tagService = tagService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _tagService.TGetListAll();
            return View(values);
        }
    }
}
