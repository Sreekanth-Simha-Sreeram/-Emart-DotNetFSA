using EMart.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMart.BusinessLayer.Ineterfaces
{
    public interface ISellerServices
    {
        bool Register(Seller seller);
        bool Login(string Email, string Password);
        bool AddStock(List<Products> product, Seller seller, int Stock);
        List<IStock> ViewSalesInventory(int SellerId);
        void CreateReport(Stock stock, DateTime fromDate, DateTime toDate);

    }
}
