using EMart.BusinessLayer.Services;
using EMart.DataLayer;
using EMart.Entities;
using NSubstitute;
using System;
using System.Collections.Generic;
using Xunit;

namespace Emart.Test.TestCases
{
   public class FunctionalTest
    {
    
        private readonly BuyerServices _Buyerservice;
        private readonly SellerServices _Sellerservice;
        
        private readonly IMapperSession _session = Substitute.For<IMapperSession>();

        public FunctionalTest()
        {
        _Buyerservice = new BuyerServices(_session);
        _Sellerservice = new SellerServices(_session);
           
        }

        [Fact]
        public void Test_For_Valid_Register()
        {
            //Arrange
            Buyer buyer = new Buyer()
            {
                BuyerId = 1,
                BuyerName = "John",
                Email = "John@gamail.com",
                Password = "John123",
                MobileNumber = 9876543210

            };

            Seller seller = new Seller()
            {
                SellerId = 10,
                SellerName = "Mary",
                Email = "Mary@gmail.com",
                Password = "Mary123",
                PostelAdress = "Delhi",
                GSTIN = "ABVC123XY763BG5",
                BankDetails = "SBI"
            };

            //Action
            var IsRegisterededBuyer = _Buyerservice.Register(buyer);
            var IsRegistedSeller = _Sellerservice.Register(seller);
            //Assert
            Assert.True(IsRegisterededBuyer);
            Assert.True(IsRegistedSeller);
        }


        [Fact]
        public void Test_For_Valid_Login()
        {
            //Arrange

            Buyer buyer = new Buyer()
            {
                BuyerId = 1,
                BuyerName = "John",
                Email = "John@gamail.com",
                Password = "John123",
                MobileNumber = 9876543210
                
            };

            Seller seller = new Seller()
            {   SellerId =10,
                SellerName ="Mary",
                Email ="Mary@gmail.com",
                Password = "Mary123",
                PostelAdress ="Delhi",
                GSTIN = "ABVC123XY763BG5",
                BankDetails ="SBI"
            };
            
            //Action
            var IsLoggedBuyer = _Buyerservice.Login(buyer.BuyerName, buyer.Password);
            var IsLoggedSeller = _Sellerservice.Login(seller.SellerName, seller.Password);
            //Assert
            Assert.True(IsLoggedBuyer);
            Assert.True(IsLoggedSeller);
        }

        [Fact]
        public void TestFor_StockAdding()
        {
            //Arrange
            Products Product = new Products()
            {
                Id = 1,
                ProductName = "Mobile",
                SubCategoryId = "2",
                Price = 400,
                BuyerId = 2,
                CategoryId = "2"

            };
            List<Products> productList = new List<Products>();
            productList.Add(Product);


            Seller seller = new Seller()
            {
                SellerId = 10,
                SellerName = "Mary",
                Email = "Mary@gmail.com",
                Password = "Mary123",
                PostelAdress = "Delhi",
                GSTIN = "ABVC123XY763BG5",
                BankDetails = "SBI"
            };
            var NumberOfStock = 1;

            //Action
            var IsAddedStock = _Sellerservice.AddStock(productList, seller, NumberOfStock);

            //Assert
            Assert.True(IsAddedStock);
        }


        [Fact]
        public void TestFor_AddProductsToCart()
        {
            //Arrange - Create some test products
            Products Product = new Products()
            {
                Id = 1,
                ProductName = "Mobile",
                SubCategoryId = "2",
                Price = 400,
                BuyerId = 2,
                CategoryId = "2"
            };
            List<Products> itemlist = new List<Products>();
            itemlist.Add(Product);


            //Action
            var result= _Buyerservice.AddProductsToCart(itemlist);

            //Assert
             Assert.True(result);

        }

        [Fact]
        public void TestFor_PlaceOrder()
        {
            //Arrange

            Buyer buyer = new Buyer()
            {
                BuyerId = 1,
                BuyerName = "John",
                Email = "John@gamail.com",
                Password = "John123",
                MobileNumber = 9876543210
            }; 
            var buyerId = buyer.BuyerId;

            //Action
            List<Products> productsForBuying = _Buyerservice.GetItemfromCart(buyer.BuyerId);
            List<Products> orderedProducts = _Buyerservice.PlaceOrder(productsForBuying, buyer);

            //Assert
            Assert.Equal(productsForBuying, orderedProducts);
        }

        [Fact]
        public void TestFor_ValidSearchProducts()
        {
            //Action
            Products product = new Products()
            {
                Id = 1,
                ProductName = "Mobile",
                SubCategoryId = "2",
                Price = 400,
                BuyerId = 2,
                CategoryId = "2"
            };
            Category category = new Category() 
            {
                CategoryId = 1,
                CategoryName="electrical"

            };
            SubCategory subCategory = new SubCategory()
            {
                SubCategoryId = 10,
                CategoryId=1,
                SubCategoryName="Mobile"
            };

            List<Products> list = _Buyerservice.SearchProduct(product.ProductName, category.CategoryName, subCategory.SubCategoryName);

            //Assert
            Assert.NotNull(list);
        }

        [Fact]
        public void TestFor_DeletionOfProductsFromCart()
        {

            Buyer buyer = new Buyer()
            {
                BuyerId = 1,
                BuyerName = "John",
                Email = "John@gamail.com",
                Password = "John123",
                MobileNumber = 9876543210
                
            };
            //Action
            Products Product = new Products()
            {
                Id = 1,
                ProductName = "Mobile",
                SubCategoryId = "2",
                Price = 400,
                BuyerId = 2,
                CategoryId = "2"
            };
            List<Products> productlist = new List<Products>();
            productlist.Add(Product);

            bool IsDeletedItems = _Buyerservice.DeleteProductFromCart(productlist, buyer.BuyerId);

            //Assert
            Assert.True(IsDeletedItems);
        }
    }
}
