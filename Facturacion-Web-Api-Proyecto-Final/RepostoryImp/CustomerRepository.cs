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

            db = new DataContextBill(constr);
        }

        public User AddCustomer(User customer)
        {


            try
            {

                db.Users.InsertOnSubmit(customer);
                db.SubmitChanges();


                return customer;

            }
            catch (Exception e)
            {
                return null;
            }
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
        public Customers_Profile GetCustomer(int id)
        {
            return db.Customers_Profiles.Where(cust => cust.Id == id).FirstOrDefault();


        }
        public Customers_Profile GetCustomer(string username, string password)
        {
            return db.Customers_Profiles.Where(customer => customer.User.UserName == username
 && customer.User.Password == password
            ).FirstOrDefault();

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

            return db.Customers_Profiles.Select(model => new CustomerViewModel()
            {
                id = model.Id,
                account = model.Account.ToString(),
                date = model.User.Creation_Date,
                identification = model.User.Identification,
                lastName = model.User.LastName,
                name = model.User.Name,
                username = model.User.UserName
            }).ToList();



        }

        public bool UpdateCustomer(int id, Customers_Profile customer)
        {
            
            try
            {
                db.SubmitChanges();

                return true;
            }
            catch (Exception e)
            {

                return false;
            }
        }
    }
}