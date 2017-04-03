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
    public class SellerProfileController : ApiController
    {
        private ISellerProfileRepository repository;

        public SellerProfileController()
        {
            repository = new SellerProfileRepository();
        }


        [HttpGet]
        public SellerViewModel GetSellerProfile(long id)
        {
            var spro = repository.GetSellerProfileViewModel(id);
            return spro;
        }

        [HttpGet]
        public SellerViewModel GetSellerProfile(string username,string password)
        {
            var spro =(
                from seller in repository.AllSellersProfile()
                where String.Equals(username, seller.username) && String.Equals(password, seller.password)
                select seller).FirstOrDefault();


            return spro;  
                } 

        
        [HttpGet]
        public List<SellerViewModel> AllSellersProfile()
        {
            return repository.AllSellersProfile().ToList();
        }

        [HttpPost]
        public bool AddCustomer(string name, string lastname, string ident, string username, string password,decimal commision)
        {

            var seller = new Sellers_Profile();
            seller.Status = "1";
            seller.Commision_Type=new Commision_Type() {   Description="Esta es una comision de "+commision  ,Comission_Value=commision};

            var user = new User();
            user.Name = name;
            user.LastName = lastname;
            user.Identification = ident;
            user.Password = password.Replace(" ","");
            user.UserName = username;
            user.Status = "1";
            user.Creation_Date = DateTime.Now;
            user.Sellers_Profiles.Add(seller);
            var subject = new UserRepository().AddUser(user);

            return true;
        }



/*
        [HttpPost]
        public Sellers_Profile AddSellerProfile(int commisionId, int userId)
        {
            var spro = new Sellers_Profile()
            {
                CommisionId = commisionId,
                UserId = userId,
                Status = "1"
            };

            return repository.AddSellerProfile(spro);
        }
        */

        [HttpDelete]
        public bool DeleteSellerProfile(long id)
        {
            var spro = repository.GetSellerProfile(id);
            return repository.DeleteSellerProfile(spro);
        }




        [HttpPut]
        public bool UpdateSellerProfile(int id, string name, string lastname,string username ,string ident, string password, decimal comission)
        {
            var seller = repository.GetSellerProfile(id);

            seller.User.Name = name;
            seller.User.LastName = lastname;
            seller.User.Identification = ident;
            seller.User.Password = password;
            seller.User.UserName = username;
            seller.Commision_Type = repository.GetSellerProfile(id).Commision_Type;
            seller.Commision_Type.Comission_Value = comission;
           /* Commision_Type commisionT = new Commision_Type() { Description = "Esta es una comision de " + comission, Comission_Value = comission };
            seller.Commision_Type = commisionT;
            */
            return repository.UpdateSellerProfile(id, seller);
        }


      /*  [HttpPut]
        public bool UpdateSellerProfile(long id, int commisionId, int userId, string status)
        {
            Sellers_Profile spro = new Sellers_Profile();

            spro.CommisionId = commisionId;
            spro.UserId = userId;
            spro.Status = status;

            return repository.UpdateSellerProfile(id, spro);
        }*/
    }
}
