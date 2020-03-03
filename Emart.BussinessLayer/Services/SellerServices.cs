using EMart.BusinessLayer.Ineterfaces;
using EMart.DataLayer;
using EMart.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMart.BusinessLayer.Services
{
    public class SellerServices : ISellerServices
    {
        private readonly IMapperSession _session;

        public SellerServices(IMapperSession session)
        {
            _session = session;
        }


        public bool AddStock(List<Products> product, Seller seller, int Stock)
        {
            return false;
        }

        public void CreateReport(Stock stock, DateTime fromDate, DateTime toDate)
        { 

        }

        public bool Login(string Email, string Password)
        {
            return false;
        }

        public bool Register(Seller seller)
        {
            return false;
        }

        public List<IStock> ViewSalesInventory(int SellerId)
        {
            List<IStock> Istock = new List<IStock>();
            return Istock;
        }
    }
}
