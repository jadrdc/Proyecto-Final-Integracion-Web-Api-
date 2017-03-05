using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Facturacion_Web_Api_Proyecto_Final.ViewModels
{
    public class ArticleViewModel
    {
        public int id { get; set; }

        public string description { get; set; }
        public decimal price { get; set; }


    }
}