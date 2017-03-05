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

        [HttpGet]
        public List<CustomerViewModel> GetCustomer()
        {
            var customers = repository.GetCustomersViewModel();

            return customers ;
        }




    }
}
