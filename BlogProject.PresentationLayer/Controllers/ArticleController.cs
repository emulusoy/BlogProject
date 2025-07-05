using System.Security.Claims;
using BlogProject.BusinessLayer.Abstract;
using BlogProject.DataAccessLayer.Context;
using BlogProject.EntityLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlogProject.PresentationLayer.Controllers
{

    public class ArticleController : Controller
    {
        private readonly IArticleService _articleService;
        private readonly BlogContext _context;

        public ArticleController(IArticleService articleService, BlogContext context)
        {
            _articleService = articleService;
            _context = context;
        }

        public IActionResult ArticleDetail(int id)
        {
            ViewBag.id = id;
            return View();
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> AddComment(int articleId, string commentDetail)
        {
            if (string.IsNullOrEmpty(commentDetail))
            {
                TempData["ErrorMessage"] = "Yorum boş olamaz";
                return RedirectToAction("ArticleDetail", new { id = articleId });
            }

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var comment = new Comment
            {
                ArticleId = articleId,
                AppUserId = userId,
                CommentDetail = commentDetail,
                CommentDate = DateTime.Now,
                IsToxic = false // Varsa toksik içerik analizi yapabilirsiniz
            };

            _context.Comments.Add(comment);
            await _context.SaveChangesAsync();

            TempData["SuccessMessage"] = "Yorumunuz başarıyla eklendi";
            return RedirectToAction("ArticleDetail", new { id = articleId });
        }

    }
}
