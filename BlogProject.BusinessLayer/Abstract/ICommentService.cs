using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogProject.EntityLayer.Entities;

namespace BlogProject.BusinessLayer.Abstract
{
    public interface ICommentService:IGenericService<Comment>
    {
        List<Comment> TGetCommentsByArticleId(int id);
    }
}
