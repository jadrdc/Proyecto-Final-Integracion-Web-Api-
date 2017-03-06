using Facturacion_Web_Api_Proyecto_Final.AbstractRepository;
using Facturacion_Web_Api_Proyecto_Final.Models;
using Facturacion_Web_Api_Proyecto_Final.RepostoryImp;
using Facturacion_Web_Api_Proyecto_Final.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Facturacion_Web_Api_Proyecto_Final.Controllers
{
    public class ArticleController : ApiController
    {
        private IArticleRepository repository;

        public ArticleController()
        {
            repository = new ArticleRepository();
        }

        [HttpGet]
        public ArticleViewModel GetArticle(long id)
        {
            var article = repository.GetArticleViewModel(id);

            return article;
        }
        [HttpGet]
        public List<ArticleViewModel> GetArticles()
        {

            return repository.GetArticles().ToList();
        }

        
        [HttpPost]
        public Article AddArticle(string description, decimal price)
        {
            var article = new Article() { Description = description, Price = price ,Status="1"};

            return repository.AddArticle(article);
        }
        [HttpDelete]
        public bool  DeleteArticle(long id )
        {
            var article = repository.GetArticle(id);

            return repository.DeleteArticle(article);
        }
        [HttpPut]
        public bool UpdateArticle(long id, decimal price, string description)
        {
            Article article = new Article();
            article.Description = description;
            article.Price = price; 

            return repository.UpdateArticle(id, article);
                }

    }
}
