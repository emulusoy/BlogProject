using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogProject.EntityLayer.Entities;

namespace BlogProject.DataAccessLayer.Abstract
{
    public interface IArticleDal : IGenericDal<Article>
    {
    }
}
