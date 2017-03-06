using Facturacion_Web_Api_Proyecto_Final.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion_Web_Api_Proyecto_Final.AbstractRepository
{
    interface ISellerProfileRepository
    {

        Sellers_Profile GetSellerProfile(long id);
        bool DeleteSellerProfile(Sellers_Profile sellerProfile);
        IEnumerable<Sellers_Profile> AllSellersProfile();
        Boolean UpdateSellerProfile(long id, Sellers_Profile sellerProfile);
        Sellers_Profile AddSellerProfile(Sellers_Profile sellerProfile);
    }
}
