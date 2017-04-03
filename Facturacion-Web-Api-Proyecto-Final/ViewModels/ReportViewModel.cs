using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Facturacion_Web_Api_Proyecto_Final.ViewModels
{
    public class ReportViewModel
{


        public string Seller { get; set; }
        public string Customer { get; set; }
        public decimal Amount { get; set; }

    }
}