using Facturacion_Web_Api_Proyecto_Final.AbstractRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Facturacion_Web_Api_Proyecto_Final.Models;
using Facturacion_Web_Api_Proyecto_Final.Configs;
using System.Configuration;

namespace Facturacion_Web_Api_Proyecto_Final.RepostoryImp
{
    public class ArticleRepository : IArticleRepository
    {
        private static readonly string constr = ConfigurationManager.ConnectionStrings["FacturacionConnectionString"].ConnectionString;
        private DataContextBill db;

 
        public ArticleRepository()
        {
            db = new DataContextBill(constr);
        }

        public Article AddArticle(Article article)
        {

            try
            {
                db.Articles.InsertOnSubmit(article);
                db.SubmitChanges();

                return article;

            }
            catch (Exception e)
            {
                return null;
            }

        }

        public bool DeleteArticle(Article article)
        {
            try
            {
                db.Articles.DeleteOnSubmit(article);
                db.SubmitChanges();

                return true;

            }
            catch (Exception e)
            {
                return false;
            }

        }

        public Article GetArticle(long id )
        {
            return db.Articles.Where(art => art.Id == id).FirstOrDefault();
 
        }

        public IEnumerable<Article> GetArticles()
        {

            return db.Articles.ToList();
        }

       

        public bool UpdateArticle(long id,Article article)
        {
            Article art = GetArticle(id);
            art.Price = article.Price;
            art.Description = article.Description;
            try
            {
                db.SubmitChanges();

                return true;
            }
            catch(Exception e)
            {

                return false;
            }

        }

    }
}