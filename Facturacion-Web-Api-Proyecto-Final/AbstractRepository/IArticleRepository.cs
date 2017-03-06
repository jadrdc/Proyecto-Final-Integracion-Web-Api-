using Facturacion_Web_Api_Proyecto_Final.Models;
using Facturacion_Web_Api_Proyecto_Final.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion_Web_Api_Proyecto_Final.AbstractRepository
{
    interface IArticleRepository
    {

        ArticleViewModel GetArticleViewModel(long id);
        Article GetArticle(long id);

        bool DeleteArticle(Article article);
        IEnumerable<ArticleViewModel> GetArticles();
        Boolean UpdateArticle(long id,Article article);
        Article AddArticle( Article art);


    }

}
