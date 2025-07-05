using System.Security.Claims;
using BlogProject.DataAccessLayer.Context;
using BlogProject.EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject.PresentationLayer.Controllers
{
    public class CommentController : Controller
    {
        private readonly BlogContext _context;

        public CommentController(BlogContext context)
        {
            _context = context;
        }

        public IActionResult PostComment(string comment, int articleId)
        {
            if (string.IsNullOrWhiteSpace(comment))
            {
                TempData["Error"] = "Yorum boş olamaz.";
                return RedirectToAction("Detail", "Post", new { id = articleId });
            }

            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (userId == null)
            {
                TempData["Error"] = "Kullanıcı bilgisi alınamadı.";
                return RedirectToAction("Detail", "Post", new { id = articleId });
            }

            // ✅ ArticleId burada kullanılıyor
            var newComment = new Comment
            {
                CommentDetail = comment,
                AppUserId = userId,
                ArticleId = articleId, // 🔥 BU satır hatayı çözer
                CommentDate = DateTime.Now
            };

            _context.Comments.Add(newComment);
            _context.SaveChanges();

            TempData["Success"] = "Yorum başarıyla eklendi.";
            return RedirectToAction("ArticleDetail", "ArticleD"); 
        
        }
    }
}
