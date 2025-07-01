using BlogProject.DataAccessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject.PresentationLayer.ViewComponents.ArticleDetailViewComponents
{
    public class _ArticleDetailRecentArticleComponentPartial:ViewComponent
    {
        private readonly IArticleDal _articleDal;

        public _ArticleDetailRecentArticleComponentPartial(IArticleDal articleDal)
        {
            _articleDal = articleDal;
        }

        public IViewComponentResult Invoke()
        {
            var values=_articleDal.GetListAll().OrderByDescending(x => x.CreatedDate).Take(3).ToList();
            return View(values);
        }
    }
}
