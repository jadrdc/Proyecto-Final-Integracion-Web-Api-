using Facturacion_Web_Api_Proyecto_Final.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Facturacion_Web_Api_Proyecto_Final.ViewModels
{
    public class AccountEntry
    {
        public int id { get; set; }
        public string movement;
        public string description { get; set; }
        public decimal amount { get; set; }
        public Order order { get; set; }


    }
}