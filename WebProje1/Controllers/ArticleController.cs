using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebProje1.Controllers
{
    public class ArticleController : Controller
    {
        ArticleManager articleManager = new ArticleManager(new EFArticleRepository());
        public IActionResult Index()
        {
            var values=articleManager.GetListArticleWithCat();
            return View(values);
        }
        public IActionResult ArticleReadAll(int id)
        {
            ViewBag.Id = id;
            var values = articleManager.GetArticleByID(id);
            return View(values);
        }
    }
}
