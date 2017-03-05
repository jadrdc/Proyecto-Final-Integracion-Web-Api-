using Facturacion_Web_Api_Proyecto_Final.Models;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Web;

namespace Facturacion_Web_Api_Proyecto_Final.Configs
{
    public class DataContextBill : DatabaseModelDataContext
    {
        public DataContextBill(String connection): base  (connection)
        {

        }

    }
}