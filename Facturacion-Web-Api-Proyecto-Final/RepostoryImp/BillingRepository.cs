﻿using Facturacion_Web_Api_Proyecto_Final.Configs;
using Facturacion_Web_Api_Proyecto_Final.Models;
using Facturacion_Web_Api_Proyecto_Final.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Linq;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Facturacion_Web_Api_Proyecto_Final.RepostoryImp
{
    public class BillingRepository
    {
        private static readonly string constr = ConfigurationManager.ConnectionStrings["FacturacionConnectionString"].ConnectionString;
        private DataContextBill db;
        ArticleRepository artrepository;
        CustomerRepository custRepository;

        public BillingRepository()
        {
            db = new DataContextBill(constr);

        }
        public List<ReportViewModel> GetReportBaseonParameters(string id, string entity)
        {
            List<ReportViewModel> list = new List<ReportViewModel>();
             switch(entity)
            {
                case "Cliente":
                    {
                        
                       list= db.Orders.Where(cust => String.Equals(cust.Customers_Profile.User.Identification, id)).Select(model => new ReportViewModel()
                        {   Amount = model.Amount,
                            Customer = model.Customers_Profile.User.Name + " " + model.Customers_Profile.User.LastName,
                            Seller = model.Sellers_Profile.User.Name + " " + model.Sellers_Profile.User.LastName
                        }).ToList();

                         
                        break;
                    }

                case "Vendedores":
                    {

                        list = db.Orders.Where(cust => String.Equals(cust.Sellers_Profile.User.Identification, id)).Select(model => new ReportViewModel()
                        {
                            Amount = model.Amount,
                            Customer = model.Customers_Profile.User.Name + " " + model.Customers_Profile.User.LastName,
                            Seller = model.Sellers_Profile.User.Name + " " + model.Sellers_Profile.User.LastName
                        }).ToList();

                        break;
                    }
           }

            return list;


        }






        public Order BillCustomer(int customer, int seller, int [] articles)
        {


            artrepository = new ArticleRepository();
            EntitySet<Order_Detail> details = new EntitySet<Order_Detail>();
            Order order = new Order();
            order.CustomerId = customer;
            order.Date = DateTime.Now;
            order.SellerId = seller;
            order.Amount = 0;

            foreach (int x in articles)
            {
                var article = artrepository.GetArticle(Convert.ToInt64(x));
                Order_Detail detail = new Order_Detail();
                detail.Price = Convert.ToInt32(article.Price);
                detail.Quantity = 1;
                detail.ArticleId = article.Id;
                detail.Amount = detail.Price;
                order.Amount += detail.Price;
                detail.Order = order;
            }
            order.Order_Details = details;



            try
            {

                db.Orders.InsertOnSubmit(order);
                db.SubmitChanges();


            }
            catch (Exception e)
            {
                return null;
            }


            return order;
        }



    }
}