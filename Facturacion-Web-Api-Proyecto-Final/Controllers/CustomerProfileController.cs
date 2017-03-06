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
        public bool DeleteCustomer(int id)
        {
            var cust = repository.GetCustomer(id);

            return repository.DeleteCustomer(cust);
        }

        [HttpPut]
        public bool UpdateCustomer(int id, string name, string lastname, string ident, string password, int account)
        {
            var customer = new Customers_Profile();
            customer.Account = account;
            customer.User = new User();
            customer.User.Name = name;
            customer.User.LastName = lastname;
            customer.Identification = ident;
            customer.User.Password = password;

            return repository.UpdateCustomer(id, customer);
        }




        [HttpGet]
        public Customers_Profile GetCustomer(string username, string password)
        {
            var customer = repository.GetCustomer(username, password);

            return customer;
        }



        [HttpGet]
        public List<CustomerViewModel> GetCustomers()
        {

            return repository.GetCustomersViewModel();
        }



        [HttpPost]
        public bool AddCustomer(string name, string lastname, string ident, string username, string password, int account)
        {

            var customer = new Customers_Profile();
            customer.Account = account;
            customer.Status = "1";
            customer.Identification = ident;
            var user = new User();
            user.Name = name;
            user.LastName = lastname;
            user.Identification = ident;
            user.Password = password;
            user.UserName = username;
            user.Status = "1";
            user.Creation_Date = DateTime.Now;
            user.Customers_Profiles.Add(customer);
            var subject = repository.AddCustomer(user);

            return true;
        }





    }
}
