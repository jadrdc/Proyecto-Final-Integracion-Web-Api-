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
    public class SellerProfileController : ApiController
    {
        private ISellerProfileRepository repository;

        public SellerProfileController()
        {
            repository = new SellerProfileRepository();
        }


        [HttpGet]
        public Sellers_Profile GetSellerProfile(long id)
        {
            var spro = repository.GetSellerProfile(id);
            return spro;
        }


        [HttpGet]
        public List<Sellers_Profile> AllSellersProfile()
        {
            return repository.AllSellersProfile().ToList();
        }


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


        [HttpDelete]
        public bool DeleteSellerProfile(long id)
        {
            var spro = repository.GetSellerProfile(id);
            return repository.DeleteSellerProfile(spro);
        }


        [HttpPut]
        public bool UpdateSellerProfile(long id, int commisionId, int userId, string status)
        {
            Sellers_Profile spro = new Sellers_Profile();

            spro.CommisionId = commisionId;
            spro.UserId = userId;
            spro.Status = status;

            return repository.UpdateSellerProfile(id, spro);
        }
    }
}
