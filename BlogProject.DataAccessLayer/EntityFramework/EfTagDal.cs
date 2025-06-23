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
    public class EfTagDal : GenericRepository<Tag>, ITagDal
    {
        public EfTagDal(BlogContext context) : base(context)
        {

        }
    }
}
