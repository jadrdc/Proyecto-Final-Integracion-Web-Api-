using Facturacion_Web_Api_Proyecto_Final.AbstractRepository;
using Facturacion_Web_Api_Proyecto_Final.Models;
using Facturacion_Web_Api_Proyecto_Final.RepostoryImp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Facturacion_Web_Api_Proyecto_Final.Controllers
{
    public class UserController : ApiController
    {
        private IUserRepository repository;

        public UserController()
        {
            repository = new UserRepository();
        }


        [HttpGet]
        public User GetUser(long id)
        {
            var user = repository.GetUser(id);
            return user;
        }


        [HttpGet]
        public List<User> AllUsers()
        {
            return repository.AllUsers().ToList();
        }


        [HttpPost]
        public User AddUser(string name, string lastName, string identification, string userName, string password)
        {
            var user = new User() { Name = name,
                                    LastName = lastName,
                                    Identification = identification,
                                    UserName = userName,
                                    Password = password,
                                    Creation_Date = DateTime.Now,
                                    Status = "1" };

            return repository.AddUser(user);
        }


        [HttpDelete]
        public bool DeleteUser(long id)
        {
            var user = repository.GetUser(id);
            return repository.DeleteUser(user);
        }


        [HttpPut]
        public bool UpdateUser(long id, string name, string lastName, string identification, string userName, string password, string status)
        {
            User user = new User();
            user.Name = name;
            user.LastName = lastName;
            user.Identification = identification;
            user.UserName = userName;
            user.Password = password;
            user.Status = status;

            return repository.UpdateUser(id, user);
        }

    }
}
