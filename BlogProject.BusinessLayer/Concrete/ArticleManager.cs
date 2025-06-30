using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogProject.BusinessLayer.Abstract;
using BlogProject.DataAccessLayer.Abstract;
using BlogProject.EntityLayer.Entities;

namespace BlogProject.BusinessLayer.Concrete
{
    public class ArticleManager : IArticleService
    {
        private readonly IArticleDal _articleDal;

        public ArticleManager(IArticleDal articleDal)
        {
            _articleDal = articleDal;
        }

        public void TDelete(int id)
        {
            _articleDal.Delete(id);
        }

        public List<Article> TGetArticleByAuthor(string id)
        {
            return _articleDal.GetArticleByAuthor(id);
        }

        public List<Article> TGetArticleByCategoryId1()
        {
            return _articleDal.GetArticleByCategoryId1(); 
        }

        public List<Article> TGetArticleWithAppUser()
        {
            return _articleDal.GetArticleWithAppUser();
        }

        public Article TGetArticleWithAuthorAndCategoryById(int id)
        {
            return _articleDal.GetArticleWithAuthorAndCategoryById(id);
        }

        public List<Article> TGetArticleWithCategories()
        {
            return _articleDal.GetArticleWithCategories();
        }

        public List<Article> TGetArticleWithCategoriesAndAppUsers()
        {
           return _articleDal.GetArticleWithCategoriesAndAppUsers();
        }

        public Article TGetById(int id)
        {
            return _articleDal.GetById(id);
        }

        public List<Article> TGetListAll()
        {
            return _articleDal.GetListAll();
        }

        public void TInsert(Article entity)
        {
            if (entity.Title != null && entity.Title.Length>10 && entity.CategoryId !=0 && entity.Content.Length <=100)
            {
                _articleDal.Insert(entity);
            } 
          
        }
        public void TUpdate(Article entity)
        {
           _articleDal.Update(entity);  
        }
    }
}
