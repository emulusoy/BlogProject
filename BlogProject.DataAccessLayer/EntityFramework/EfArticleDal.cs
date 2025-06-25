using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogProject.DataAccessLayer.Abstract;
using BlogProject.DataAccessLayer.Context;
using BlogProject.DataAccessLayer.Repositories;
using BlogProject.EntityLayer.Entities;

namespace BlogProject.DataAccessLayer.EntityFramework
{
    public class EfArticleDal : GenericRepository<Article>, IArticleDal
    {
        private readonly BlogContext _context;  
        public EfArticleDal(BlogContext context) : base(context)
        {
            _context = context;
        }

        public List<Article> GetArticleByCategoryId1()
        {
            var values =_context.Articles.Where(x=>x.CategoryId == 1).ToList();
            return values;
        }
    }
}
