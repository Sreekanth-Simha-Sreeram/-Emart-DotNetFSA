using EMart.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMart.BusinessLayer.Interfaces;
using NHibernate;
using EMart.DataLayer;

namespace EMart.BusinessLayer.Services
{
    public class BuyerServices : IBuyerServices
    {
        private readonly IMapperSession _session;

        public BuyerServices(IMapperSession session)
        {
            _session = session;
        }


        public List<Products> SearchProduct(string ProductName, string CategoryName, string SubCategoryName)
        {
            List<Products> product = new List<Products>();
            return product;
        }

      

        public List<Products> FilterProduct(string ProductName, string CategoryName, int Price, string Manufacturer)
        {
            List<Products> product = new List<Products>();
            return product;
        }

        public List<Products> PlaceOrder(List<Products> product, Buyer buyer)
        {
            List<Products> Order = new List<Products>();
            return Order;
        }


        public bool DeleteProductFromCart(List<Products> products, int BuyerId)
        {
            return false;

        }


        public List<Products> ViewProductsInCart(int buyerId)
        {
            List<Products> Productlist = new List<Products>();
            return Productlist;
        }



        public List<Products> GetItemfromCart(int id)
        {
            List<Products> productlists = new List<Products>();
            return productlists;
        }

        public bool AddProductsToCart(List<Products> products)
        {
            return false;
        }

        public bool Register(Buyer buyer)
        {
            return false;
        }

        public bool Login(string Email, string Password)
        {
            return false;
        }
    }
}
