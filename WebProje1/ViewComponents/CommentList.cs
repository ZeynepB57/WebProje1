using Azure.Identity;
using Microsoft.AspNetCore.Mvc;
using WebProje1.Models;

namespace WebProje1.ViewComponents
{
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var comment = new List<UserComment>
            {
                new UserComment
                {
                    ID=1, UserName="Murat"
                },
                new UserComment {
                    ID=2, UserName="Mesut"
                },
                new UserComment
                {
                    ID=3, UserName="Cansu"
                },
            };
            return View(comment);
        }
    }
}
