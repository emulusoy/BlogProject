﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogProject.EntityLayer.Entities;

namespace BlogProject.DataAccessLayer.Abstract
{
    public interface IArticleDal : IGenericDal<Article>
    {
       public List<Article> GetArticleByCategoryId1();//categori id si bir olan makale
        public List<Article> GetArticleWithAppUser();
        public List<Article> GetArticleWithCategories();
        public List<Article> GetArticleWithCategoriesAndAppUsers();
        Article  GetArticleWithAuthorAndCategoryById(int id);//yazarla birlikte

        List<Article> GetArticleByAuthor(string id);//my articles list
    }
}
