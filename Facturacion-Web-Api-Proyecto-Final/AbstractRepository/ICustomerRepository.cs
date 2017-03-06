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
        Customers_Profile GetCustomer(int id);
        User AddCustomer(User customer);
        bool DeleteCustomer(Customers_Profile customer);
        IEnumerable<Customers_Profile> GetCustomers();
        bool UpdateCustomer(int id,Customers_Profile customer);
        List<Customers_Profile> GetCustomersViewModel();
    }
}
