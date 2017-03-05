using Facturacion_Web_Api_Proyecto_Final.AbstractRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Facturacion_Web_Api_Proyecto_Final.Models;
using Facturacion_Web_Api_Proyecto_Final.Configs;
using System.Configuration;
using Facturacion_Web_Api_Proyecto_Final.ViewModels;

namespace Facturacion_Web_Api_Proyecto_Final.RepostoryImp
{
    public class CustomerRepository : ICustomerRepository
    {
        private static readonly string constr = ConfigurationManager.ConnectionStrings["FacturacionConnectionString"].ConnectionString;
        private DataContextBill db;

        public CustomerRepository()
        {

        }
        public bool DeleteCustomer(Customers_Profile customer)
        {

            try
            {
                db.Customers_Profiles.DeleteOnSubmit(customer);
                db.SubmitChanges();

                return true;

            }
            catch (Exception e)
            {
                return false;
            }


        }
        public Customers_Profile GetCustomer(long id)
        {
            return db.Customers_Profiles.Where(cust => cust.Id==id).FirstOrDefault();


        }
        public Customers_Profile GetCustomer(string username, string password)
        {
         return   db.Customers_Profiles.Where(cust => (cust.User.Name.Equals(username) && cust.User.Password.Equals(password))).FirstOrDefault();

        }

        public IEnumerable<Customers_Profile> GetCustomers()
        {
            IEnumerable<Customers_Profile> customerList;
            using (db = new DataContextBill(constr))
            {
                customerList = db.Customers_Profiles.ToList();

            }

            return customerList;
        }

        public List<CustomerViewModel> GetCustomersViewModel()
        {
          var list=  (from cust in GetCustomers()
                select new CustomerViewModel
                {
                    id = cust.Id,
                    status = cust.Status,
                    identification = cust.Identification,
                    account = cust.Account,
                    userdata = new UserViewModel()
                    {
                        id = cust.User.Id,
                        lastname = cust.User.LastName,
                        name = cust.User.Name,
                        creationdate = cust.User.Creation_Date,
                        password = cust.User.Password,
                        identification = cust.User.Identification,
                        status = cust.User.Identification,
                        username = cust.User.UserName
                    }
                }).ToList();
            return list;
            ;



        }

        public bool UpdateCustomer(Customers_Profile customer)
        {
            throw new NotImplementedException();
        }
    }
}