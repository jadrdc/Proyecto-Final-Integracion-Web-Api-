using Facturacion_Web_Api_Proyecto_Final.Models;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Web;

namespace Facturacion_Web_Api_Proyecto_Final.ViewModels
{
    public class CustomerViewModel
    {

        public int id { get; set; }

        public string identification { get; set; }
        public string status  { get; set; }

        public int account { get; set; }
     //   public List<OrderViewModel>orders{ get; set; }
       public UserViewModel userdata { get; set; }
        
        
        
    }
    
}