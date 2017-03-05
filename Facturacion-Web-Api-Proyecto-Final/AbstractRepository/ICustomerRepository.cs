using Facturacion_Web_Api_Proyecto_Final.Models;
using Facturacion_Web_Api_Proyecto_Final.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion_Web_Api_Proyecto_Final.AbstractRepository
{
    interface ICustomerRepository
    {
        Customers_Profile GetCustomer(string username , string password);
        Customers_Profile DeleteCustomer(Customers_Profile customer);
        IEnumerable<Customers_Profile> GetCustomers();
        Boolean UpdateCustomer(Customers_Profile customer);
        List<CustomerViewModel> GetCustomersViewModel();
    }
}
