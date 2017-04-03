using Facturacion_Web_Api_Proyecto_Final.AbstractRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Facturacion_Web_Api_Proyecto_Final.Models;
using System.Configuration;
using Facturacion_Web_Api_Proyecto_Final.Configs;
using Facturacion_Web_Api_Proyecto_Final.ViewModels;
using System.Web.Http;

namespace Facturacion_Web_Api_Proyecto_Final.RepostoryImp
{
    public class SellerProfileRepository : ISellerProfileRepository
    {
        private static readonly string constr = ConfigurationManager.ConnectionStrings["FacturacionConnectionString"].ConnectionString;
        private DataContextBill db;

        public SellerProfileRepository()
        {
            db = new DataContextBill(constr);
        }

        public Sellers_Profile AddSellerProfile(Sellers_Profile sellerProfile)
        {
            try
            {
                db.Sellers_Profiles.InsertOnSubmit(sellerProfile);
                db.SubmitChanges();

                return sellerProfile;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public bool DeleteSellerProfile(Sellers_Profile sellerProfile)
        {
            try
            {
                db.Sellers_Profiles.DeleteOnSubmit(sellerProfile);
                db.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public Sellers_Profile GetSellerProfile(long id)
        {
            return db.Sellers_Profiles.Where(spro => spro.Id == id).FirstOrDefault();
        }

        public Sellers_Profile GetSellerProfile( string username , string password)
        {
            return null;/*(from seller in db.Sellers_Profiles
                   where seller.User.Password==password && seller.User.UserName=username
                   select seller).FirstOrDefault();*/
        }

        public bool UpdateSellerProfile(long id, Sellers_Profile sellerProfile)
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

       
        public SellerViewModel GetSellerProfileViewModel(long id)
        {

            return db.Sellers_Profiles.Where(spro => spro.Id == id).Select(model => new SellerViewModel()
            {
                id = model.Id,
                comissiontype = model.Commision_Type.Comission_Value,
                date = model.User.Creation_Date,
                identification = model.User.Identification,
                lastName = model.User.LastName,
                name = model.User.Name,
                username = model.User.UserName, password=model.User.Password
            }).FirstOrDefault();

        }



        IEnumerable<SellerViewModel> ISellerProfileRepository.AllSellersProfile()
        {
            return db.Sellers_Profiles.Select(model => new SellerViewModel()
            {
                id = model.Id,
                comissiontype = model.Commision_Type.Comission_Value,
                date = model.User.Creation_Date,
                identification = model.User.Identification,
                lastName = model.User.LastName,
                name = model.User.Name,
                username = model.User.UserName,
                password = model.User.Password
            });
        }
    }
    
}