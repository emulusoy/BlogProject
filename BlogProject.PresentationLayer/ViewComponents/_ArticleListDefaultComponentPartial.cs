using BlogProject.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

public class _ArticleListDefaultComponentPartial : ViewComponent
{
    private readonly IArticleService _articleService;

    public _ArticleListDefaultComponentPartial(IArticleService articleService)
    {
        _articleService = articleService;
    }

    public IViewComponentResult Invoke()
    {
        int page = 1;

        if (HttpContext.Request.Query.ContainsKey("page"))
        {
            int.TryParse(HttpContext.Request.Query["page"], out page);
            if (page <= 0) page = 1;
        }

        int pageSize = 9;
        var allArticles = _articleService.TGetArticleWithCategoriesAndAppUsers()
                                         .OrderByDescending(x => x.CreatedDate)
                                         .ToList();

        var paginatedArticles = allArticles
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToList();

        ViewBag.CurrentPage = page;
        ViewBag.TotalPages = (int)Math.Ceiling((double)allArticles.Count / pageSize);

        return View(paginatedArticles);
    }
}
