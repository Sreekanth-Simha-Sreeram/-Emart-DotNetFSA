using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EMart.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Emart.Web.Controllers
{
    public class BuyerController : Controller
    {
        public List<Products> SearchProduct(string ProductName, string CategoryName, string SubCategoryName)
        {

            //write code to search product

            List<Products> product = new List<Products>();
            return product;
        }
        public List<Products> FilterProduct(string ProductName, string CategoryName, int Price, string Manufacturer)
        {

            //code here to filter products
            List<Products> product = new List<Products>();
            return product;
        }

        public List<Products> PlaceOrder(List<Products> product, Buyer buyer)
        {

            // code to place your order
            List<Products> Order = new List<Products>();
            return Order;
        }


        public bool DeleteProductFromCart(List<Products> products, int BuyerId)
        {
            // code here to delete product from cart
            return false;

        }


        public List<Products> ViewProductsInCart(int buyerId)
        {

            //write code  to view products in cart
            List<Products> Productlist = new List<Products>();
            return Productlist;
        }



        public List<Products> GetItemfromCart(int id)
        {

            // code here to get items from cart
            List<Products> productlists = new List<Products>();
            return productlists;
        }

        public bool AddProductsToCart(List<Products> products)
        {
            // code here to add products to cart
            return false;
        }

        public bool Register(Buyer buyer)
        {
            // code for registration
            return false;
        }

        public bool Login(string Email, string Password)
        {
            //code for buyer login

            return false;
        }
    }
}





