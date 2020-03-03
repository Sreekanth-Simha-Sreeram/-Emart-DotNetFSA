using EMart.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMart.BusinessLayer.Interfaces
{
   public interface IBuyerServices
    {
        bool Register(Buyer buyer);
        bool Login(string Email, string Password);
        List<Products> SearchProduct(string ProductName, string CategoryName, string SubCategoryName);
        bool AddProductsToCart(List<Products> products);
        List<Products> FilterProduct(string ProductName, string CategoryName, int Price, string Manufacturer);
        bool DeleteProductFromCart(List<Products> products, int BuyerId);
        List<Products> ViewProductsInCart(int buyerId);
        List<Products> PlaceOrder(List<Products> product, Buyer buyer);
        List<Products> GetItemfromCart(int id);

    }
}
