using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface IArticleService
	{
        void ArticleAdd(Article article);
        void ArticleRemove(Article article);
        void ArticleUpdate(Article article);
        List<Article> GetAllArticles();
        Article GetArticleById(int id);
        List<Article> GetListArticleWithCat();
        List<Article> GetArticleByWriter(int id);
    }
}
