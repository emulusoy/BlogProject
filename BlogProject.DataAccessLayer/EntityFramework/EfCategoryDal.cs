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
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal

    //neden icategorydaldan aldik cunku i categorye ozel de bir seyler yapabiliriz!

    //kategoriye ozel islemler icin icategorydal interface'ini implement ettik.

    {
        private readonly BlogContext _context;
        public EfCategoryDal(BlogContext context) : base(context)
        {
            _context = context;
        }

        public int GetCategoryCount()
        {
            return _context.Categories.Count(); 
        }
    }
}
