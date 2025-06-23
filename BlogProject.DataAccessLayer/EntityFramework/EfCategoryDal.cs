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
        public EfCategoryDal(BlogContext context) : base(context)
        {
        }
    }
}
