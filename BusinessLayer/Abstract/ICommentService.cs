using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICommentService
    {
        void CommentAdd(Comment comment);
        //void CategoryRemove(Category category);
        //void CategoryUpdate(Category category);
        List<Comment> GetAllComment(int id);
        //Category GetCategoryById(int id);
    }
}
