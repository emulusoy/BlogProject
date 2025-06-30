using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogProject.DataAccessLayer.Abstract;
using BlogProject.DataAccessLayer.Context;
using BlogProject.DataAccessLayer.Repositories;
using BlogProject.EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlogProject.DataAccessLayer.EntityFramework
{
    public class EfCommentDal : GenericRepository<Comment>, ICommentDal
    {
        private readonly BlogContext _context;
        public EfCommentDal(BlogContext context) : base(context)
        {
            _context = context;
        }

        public List<Comment> GetCommentsByArticleId(int id)
        {
            var values = _context.Comments.Include(y=>y.AppUser).Where(x => x.ArticleId ==id);
            return values.ToList();
        }
    }
}
