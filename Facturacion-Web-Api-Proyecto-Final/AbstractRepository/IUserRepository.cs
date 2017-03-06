using Facturacion_Web_Api_Proyecto_Final.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Facturacion_Web_Api_Proyecto_Final.AbstractRepository
{
    interface IUserRepository
    {
        User GetUser(long id);
        bool DeleteUser(User user);
        List<User> AllUsers();
        Boolean UpdateUser(long id, User user);
        User AddUser(User user);
    }
}