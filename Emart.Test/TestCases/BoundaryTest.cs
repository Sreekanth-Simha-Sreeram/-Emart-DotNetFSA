
using EMart.BusinessLayer.Services;
using EMart.DataLayer;
using EMart.Entities;
using NSubstitute;
using System;
using Xunit;

namespace Emart.Test.TestCases
{
    public class BoundaryTest
    {
        private readonly BuyerServices _Buyerservice;
        private readonly SellerServices _Sellerservice;
        private readonly IMapperSession _session = Substitute.For<IMapperSession>();

        public BoundaryTest()
        {
            _Buyerservice = new BuyerServices(_session);
            _Sellerservice = new SellerServices(_session);
        }

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
            SellerId = 1,
            SellerName = "Mary",
            Email = "Mary@gmail.com",
            Password = "Mary123",
            MobileNumber = 9658743251,
            CompanyName = "Trends",
            PostelAdress = "Delhi",
            GSTIN = "ABVC123XY763BG5",
            BankDetails = "SBI"
        };


        [Fact]
        public void BoundaryTest_ForBuyerPassword_Length()
        {
            var MinLength = 8;
            var MaxLength = 25;

            //Action
            var buyeractualLength = buyer.Password.Length;

            //Assert
            Assert.InRange(buyeractualLength, MinLength, MaxLength);
        }

        [Fact]
        public void BoundaryTest_ForSellerPassword_Length()
        {
            var MinLength = 8;
            var MaxLength = 25;

            //Action
            var selleractualLength = seller.Password.Length;

            //Assert
            Assert.InRange(selleractualLength, MinLength, MaxLength);
        }


        [Fact]
        public void BoundaryTest_ValidEmailFormat()
        {
            //Action
            //Assert
            Assert.Contains("@", buyer.Email);
            Assert.Contains("@", seller.Email);
        }

        [Fact]       
        public void BoundaryTest_ValidMobileNumber()
        {
            //Action
           var BuyerMobileNumber= buyer.MobileNumber.ToString();
            var SellerMobileNumber = seller.MobileNumber.ToString();

            //Assert
            Assert.Equal(10, BuyerMobileNumber.Length);
            Assert.Equal(10, SellerMobileNumber.Length);
        }

        [Fact]
        public void BoundaryTest_ProductPrice()
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

            //Assert
            Assert.InRange(product.Price, 0 , 2147483647);
        }

        [Fact]
        public void BoundaryTest_GSTIN()
        {
            //Action
            //Assert
            Assert.Equal(15, seller.GSTIN.Length);
        }

    }
}
