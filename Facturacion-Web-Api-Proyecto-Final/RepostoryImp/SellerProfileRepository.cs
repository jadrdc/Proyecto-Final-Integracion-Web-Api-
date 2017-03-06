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

        public IEnumerable<Sellers_Profile> AllSellersProfile()
        {
            return db.Sellers_Profiles.ToList();
        }

        public bool UpdateSellerProfile(long id, Sellers_Profile sellerProfile)
        {
            Sellers_Profile spro = GetSellerProfile(id);
            spro.CommisionId = sellerProfile.CommisionId;
            spro.UserId = sellerProfile.UserId;
            spro.Status = sellerProfile.Status;

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