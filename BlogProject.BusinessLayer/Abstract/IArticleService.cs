using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogProject.EntityLayer.Entities;

namespace BlogProject.BusinessLayer.Abstract
{
    public interface IArticleService:IGenericService<Article>
    {
        public List<Article> TGetArticleByCategoryId1();
        public List<Article> TGetArticleWithAppUser();
        public List<Article> TGetArticleWithCategories();
        public List<Article> TGetArticleWithCategoriesAndAppUsers();
    }
}
