using Facturacion_Web_Api_Proyecto_Final.Contabilidad;
using Facturacion_Web_Api_Proyecto_Final.Models;
using Facturacion_Web_Api_Proyecto_Final.RepostoryImp;
using Facturacion_Web_Api_Proyecto_Final.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Facturacion_Web_Api_Proyecto_Final.Controllers
{
    public class BillingController : ApiController
    {

        BillingRepository billing;



        [HttpGet]
        public List<ReportViewModel> GetReportData( string identification , string entity)
        {
            billing = new BillingRepository();
            var list = billing.GetReportBaseonParameters(identification, entity);

            return list;

        }

















        [HttpPost]
        public bool Bill(int customer, int seller, string articles)
        {
            billing = new BillingRepository();
            var list = (articles.Split(',').Select(x => int.Parse(x))).ToArray();


            var bill = billing.BillCustomer(customer, seller, list);
            

             if (bill!=null)
               {
                try
                {


                    var client = new Contabilidad.ContabilidadClient();


                    var debito = new entradaContableDet();
                    var credito = new entradaContableDet();
                    debito.monto = (float)bill.Amount;
                    credito.monto = (float)bill.Amount;
                    credito.cuentaContable = "6";
                    debito.cuentaContable = "13";

                    credito.tipoMovimiento = "CR";
                    debito.tipoMovimiento = "DB";

                    entradaContableDet[] lise = new entradaContableDet[2];
                    lise[0] = debito;
                    lise[1] = credito;


                    Contabilidad.entradaContable asiento = new Contabilidad.entradaContable();
                    asiento.auxiliar = "3";
                    asiento.descripcion = "Grupo de Jose Agustin Reinoso";
                    asiento.entradasContables = lise;
                    var response = client.crearAsiento(asiento);

                }
                catch (Exception e)
                {
                    return false;
                }
                
            }
               
            return true;
        }

        

    }
}