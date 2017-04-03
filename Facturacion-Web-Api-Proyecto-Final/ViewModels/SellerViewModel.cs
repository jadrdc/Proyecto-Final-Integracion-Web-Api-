using Facturacion_Web_Api_Proyecto_Final.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Facturacion_Web_Api_Proyecto_Final.ViewModels
{
    public class SellerViewModel
    {
         public int id { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }
        public string username { get; set; }
        public string password { get; set; }

        public string identification { get; set; }
        public DateTime date { get; set; }

        public decimal  comissiontype { get; set; }

    }
}