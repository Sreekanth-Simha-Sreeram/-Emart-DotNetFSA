using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EMart.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Emart.Web.Controllers
{
    public class SellerController : Controller
    {
        public bool AddStock(List<Products> product, Seller seller, int Stock)
        {
            // code here to add stock
            return false;
        }

        public void CreateReport(Stock stock, DateTime fromDate, DateTime toDate)
        {
            // code here to create report
        }

        public bool Login(string Email, string Password)
        {
            // code for Seller login
            return false;
        }

        public bool Register(Seller seller)
        {
            //code here registration
            return false;
        }

        public List<IStock> ViewSalesInventory(int SellerId)
        {
            // code here to view sales inventory
            List<IStock> Istock = new List<IStock>();
            return Istock;
        }
    }
}

