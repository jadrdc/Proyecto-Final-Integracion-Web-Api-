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
    public class CustomerProfileController : ApiController
    {
        private ICustomerRepository repository;

        public CustomerProfileController()
        {
            repository = new CustomerRepository();
        }

        [HttpDelete]
        public bool DeleteCustomer(long id )
        {
            var cust = repository.GetCustomer(id);

            return repository.DeleteCustomer(cust);
        }



    }
}
