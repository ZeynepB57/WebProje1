using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class ArticleManager : IArticleService
	{
		IArticleDal ardal;

		public ArticleManager(IArticleDal ardal)
		{
			this.ardal = ardal;
		}

		public void ArticleAdd(Article article)
		{
			throw new NotImplementedException();
		}

		public void ArticleRemove(Article article)
		{
			throw new NotImplementedException();
		}

		public void ArticleUpdate(Article article)
		{
			throw new NotImplementedException();
		}

		public List<Article> GetAllArticles()
		{
			return ardal.GetListAll();
		}

		public Article GetArticleById(int id)
		{
			return ardal.Get(id);
		}
		public List<Article> GetArticleByID(int id)
		{
			return ardal.GetListAll(x => x.ArticleID == id);
		}

		public List<Article> GetArticleByWriter(int id)
		{
			return ardal.GetListAll(x=>x.WriterID == id);
		}

		public List<Article> GetListArticleWithCat()
		{
			return ardal.GetListWithCategory();
		}
	}
}
