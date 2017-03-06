using Facturacion_Web_Api_Proyecto_Final.AbstractRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Facturacion_Web_Api_Proyecto_Final.Models;
using System.Configuration;
using Facturacion_Web_Api_Proyecto_Final.Configs;

namespace Facturacion_Web_Api_Proyecto_Final.RepostoryImp
{
    public class UserRepository : IUserRepository
    {
        private static readonly string constr = ConfigurationManager.ConnectionStrings["FacturacionConnectionString"].ConnectionString;
        private DataContextBill db;

        public UserRepository()
        {
            db = new DataContextBill(constr);
        }

        public User AddUser(User user)
        {
            try
            {
                db.Users.InsertOnSubmit(user);
                db.SubmitChanges();

                return user;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public bool DeleteUser(User user)
        {
            try
            {
                db.Users.DeleteOnSubmit(user);
                db.SubmitChanges();

                return true;

            }
            catch (Exception e)
            {
                return false;
            }
        }

        public User GetUser(long id)
        {
            return db.Users.Where(usr => usr.Id == id).FirstOrDefault();
        }

        public List<User> AllUsers()
        {
            return db.Users.ToList();
        }

        public bool UpdateUser(long id, User user)
        {
            User usr = GetUser(id);
            usr.Name = user.Name;
            usr.LastName = user.LastName;
            usr.Identification = user.Identification;
            usr.UserName = user.UserName;
            usr.Password = user.Password;

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