using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebProje1.ViewComponents.Article
{
	public class WriterLastArticle:ViewComponent
	{
		ArticleManager ar = new ArticleManager(new EFArticleRepository());
		public IViewComponentResult Invoke()
		{
			var values = ar.GetArticleByWriter(1);
			return View(values);	
		}

	}
}
