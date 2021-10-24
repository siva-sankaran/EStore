using ShoppingCartService.BusinessLogic;
using ShoppingCartService.DataAccess.Entities;
using System;
using System.Collections.Generic;
using Xunit;

namespace ShoppingCartService.Tests
{
    public class ShippingCalculatorCalculateShippingCostSameCountry
    {
        [Fact]
        public void CalculateShippingCostGivenSameCountryStandardShippingMethod()
        {
            //Arrange
            var shippingCalculator = new ShippingCalculator();
            var cart = new Cart()
            {
                Id = "C1",
                CustomerId = "Cu1",
                CustomerType = Models.CustomerType.Standard,
                ShippingMethod = Models.ShippingMethod.Standard,
                Items = new List<Item>() { new Item() { Price = 50, ProductId = "P1", ProductName = "Pencil", Quantity = 4 } },
                ShippingAddress = new Models.Address()
                {
                    Country = "USA",
                    City = "Jacksonvile",
                    Street = "1234 right lane."
                }
            };
            //Act
            var shippingCost = shippingCalculator.CalculateShippingCost(cart);

            //Assert
            Assert.Equal(8.0, shippingCost);
        }

        [Fact]
        public void CalculateShippingCostGivenSameCountryExpeditedShippingMethod()
        {
            //Arrange
            var shippingCalculator = new ShippingCalculator();
            var cart = new Cart()
            {
                Id = "C1",
                CustomerId = "Cu1",
                CustomerType = Models.CustomerType.Standard,
                ShippingMethod = Models.ShippingMethod.Expedited,
                Items = new List<Item>() { new Item() { Price = 50, ProductId = "P1", ProductName = "Pencil", Quantity = 4 } },
                ShippingAddress = new Models.Address()
                {
                    Country = "USA",
                    City = "Jacksonvile",
                    Street = "1234 right lane."
                }
            };
            //Act
            var shippingCost = shippingCalculator.CalculateShippingCost(cart);

            //Assert
            Assert.Equal(9.6, shippingCost);
        }

        [Fact]
        public void CalculateShippingCostGivenSameCountryPriorityShippingMethod()
        {
            //Arrange
            var shippingCalculator = new ShippingCalculator();
            var cart = new Cart()
            {
                Id = "C1",
                CustomerId = "Cu1",
                CustomerType = Models.CustomerType.Standard,
                ShippingMethod = Models.ShippingMethod.Priority,
                Items = new List<Item>() { new Item() { Price = 50, ProductId = "P1", ProductName = "Pencil", Quantity = 4 } },
                ShippingAddress = new Models.Address()
                {
                    Country = "USA",
                    City = "Jacksonvile",
                    Street = "1234 right lane."
                }
            };
            //Act
            var shippingCost = shippingCalculator.CalculateShippingCost(cart);

            //Assert
            Assert.Equal(16.0, shippingCost);
        }

        [Fact]
        public void CalculateShippingCostGivenSameCountryExpressShippingMethod()
        {
            //Arrange
            var shippingCalculator = new ShippingCalculator();
            var cart = new Cart()
            {
                Id = "C1",
                CustomerId = "Cu1",
                CustomerType = Models.CustomerType.Standard,
                ShippingMethod = Models.ShippingMethod.Express,
                Items = new List<Item>() { new Item() { Price = 50, ProductId = "P1", ProductName = "Pencil", Quantity = 4 } },
                ShippingAddress = new Models.Address()
                {
                    Country = "USA",
                    City = "Jacksonvile",
                    Street = "1234 right lane."
                }
            };
            //Act
            var shippingCost = shippingCalculator.CalculateShippingCost(cart);

            //Assert
            Assert.Equal(20.0, shippingCost);
        }

        [Fact]
        public void CalculateShippingCostGivenSameCountryStandardShippingMethodPremiumCustomer()
        {
            //Arrange
            var shippingCalculator = new ShippingCalculator();
            var cart = new Cart()
            {
                Id = "C1",
                CustomerId = "Cu1",
                CustomerType = Models.CustomerType.Premium,
                ShippingMethod = Models.ShippingMethod.Standard,
                Items = new List<Item>() { new Item() { Price = 50, ProductId = "P1", ProductName = "Pencil", Quantity = 4 } },
                ShippingAddress = new Models.Address()
                {
                    Country = "USA",
                    City = "Jacksonvile",
                    Street = "1234 right lane."
                }
            };
            //Act
            var shippingCost = shippingCalculator.CalculateShippingCost(cart);

            //Assert
            Assert.Equal(8.0, shippingCost);
        }

        [Fact]
        public void CalculateShippingCostGivenSameCountryExpeditedShippingMethodPremiumCustomer()
        {
            //Arrange
            var shippingCalculator = new ShippingCalculator();
            var cart = new Cart()
            {
                Id = "C1",
                CustomerId = "Cu1",
                CustomerType = Models.CustomerType.Premium,
                ShippingMethod = Models.ShippingMethod.Expedited,
                Items = new List<Item>() { new Item() { Price = 50, ProductId = "P1", ProductName = "Pencil", Quantity = 4 } },
                ShippingAddress = new Models.Address()
                {
                    Country = "USA",
                    City = "Jacksonvile",
                    Street = "1234 right lane."
                }
            };
            //Act
            var shippingCost = shippingCalculator.CalculateShippingCost(cart);

            //Assert
            Assert.Equal(8.0, shippingCost);
        }

        [Fact]
        public void CalculateShippingCostGivenSameCountryPriorityShippingMethodPremiumCustomer()
        {
            //Arrange
            var shippingCalculator = new ShippingCalculator();
            var cart = new Cart()
            {
                Id = "C1",
                CustomerId = "Cu1",
                CustomerType = Models.CustomerType.Premium,
                ShippingMethod = Models.ShippingMethod.Priority,
                Items = new List<Item>() { new Item() { Price = 50, ProductId = "P1", ProductName = "Pencil", Quantity = 4 } },
                ShippingAddress = new Models.Address()
                {
                    Country = "USA",
                    City = "Jacksonvile",
                    Street = "1234 right lane."
                }
            };
            //Act
            var shippingCost = shippingCalculator.CalculateShippingCost(cart);

            //Assert
            Assert.Equal(8.0, shippingCost);
        }

        [Fact]
        public void CalculateShippingCostGivenSameCountryExpressShippingMethodPremiumCustomer()
        {
            //Arrange
            var shippingCalculator = new ShippingCalculator();
            var cart = new Cart()
            {
                Id = "C1",
                CustomerId = "Cu1",
                CustomerType = Models.CustomerType.Premium,
                ShippingMethod = Models.ShippingMethod.Express,
                Items = new List<Item>() { new Item() { Price = 50, ProductId = "P1", ProductName = "Pencil", Quantity = 4 } },
                ShippingAddress = new Models.Address()
                {
                    Country = "USA",
                    City = "Jacksonvile",
                    Street = "1234 right lane."
                }
            };
            //Act
            var shippingCost = shippingCalculator.CalculateShippingCost(cart);

            //Assert
            Assert.Equal(20.0, shippingCost);
        }
    }
}
