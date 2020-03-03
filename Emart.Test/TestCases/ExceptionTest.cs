using Emart.Test.Exceptions;
using EMart.BusinessLayer.Services;
using EMart.DataLayer;
using EMart.Entities;
using EMart.Tests.Exceptions;
using NSubstitute;
using System;
using Xunit;

namespace Emart.Test.TestCases
{
   public class ExceptionTest
    {
        private readonly BuyerServices _Buyerservice;
        private readonly SellerServices _Sellerservice;
        private readonly IMapperSession _session = Substitute.For<IMapperSession>();

        public ExceptionTest()
        {
            _Buyerservice = new BuyerServices(_session);
            _Sellerservice = new SellerServices(_session);
        }

        [Fact]
        public void TestException_ForSearchProducts()
        {
            //Arrange
            string ProductName = "tv";
            string CategoryName = "Electrical";
            string Subcategory = "sub";

            //Assert
            var ex = Assert.Throws<ProductNotFoundException>(() => _Buyerservice.SearchProduct(ProductName, CategoryName, Subcategory));
            Assert.Equal("Item is Not found in stock", ex.Message);
        }

        [Fact]
        public void ExceptionTestFor_UserNotFound()
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
            //Assert
            var ex = Assert.Throws<UserNotFoundException>(() => _Buyerservice.Login(buyer.Email, buyer.Password));
            var exc = Assert.Throws<UserNotFoundException>(() => _Sellerservice.Login(seller.Email, seller.Password));

            Assert.Equal("User Not Found in User List", ex.Messages);
            Assert.Equal("User Not Found in User List", exc.Messages);

        }

        [Fact]
        public void ExceptionTestFor_ValidUser_InvalidPassword()
        {
            //Action
            //Assert
            var ex = Assert.Throws<InvalidCredentialsExceptions>(() => _Buyerservice.Login("abc@gmail.com", "987654321"));
            var exc = Assert.Throws<InvalidCredentialsExceptions>(() => _Sellerservice.Login("example@gmail.com", "987655321"));

            Assert.Equal("Please enter valid usename & password", ex.Messages);
            Assert.Equal("Please enter valid usename & password", exc.Messages);

        }


        [Fact]
        public void ExceptionTestFor_InvalidUser_validPassword()
        {
            //Action
            //Assert
            var ex = Assert.Throws<InvalidCredentialsExceptions>(() => _Buyerservice.Login("abc@gmail.com", "987654321"));
            var exc = Assert.Throws<InvalidCredentialsExceptions>(() => _Sellerservice.Login("example@gmail.com", "987655321"));

            Assert.Equal("Please enter valid usename & password", ex.Messages);
            Assert.Equal("Please enter valid usename & password", exc.Messages);

        }

    }
}
