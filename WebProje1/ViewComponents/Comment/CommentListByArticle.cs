using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebProje1.ViewComponents.Comment
{
    public class CommentListByArticle:ViewComponent

    {
        CommentManager cm = new CommentManager(new EFCommentRepository());
        public IViewComponentResult Invoke(int id)
        {
            var values = cm.GetAllComment(id);
            return View(values);  
        }
    }
}
