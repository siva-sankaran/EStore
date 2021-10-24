using ShoppingCartService.BusinessLogic;
using ShoppingCartService.DataAccess.Entities;
using System;
using System.Collections.Generic;
using Xunit;

namespace ShoppingCartService.Tests
{
    public class ShippingCalculatorCalculateShippingCostSameCity
    {
        [Fact]
        public void CalculateShippingCostGivenSameCityStandardShippingMethod()
        {
            //Arrange
            var shippingCalculator = new ShippingCalculator();
            var cart = new Cart() { Id = "C1",
                CustomerId = "Cu1",
                CustomerType = Models.CustomerType.Standard,
                ShippingMethod = Models.ShippingMethod.Standard,
                Items = new List<Item>() { new Item() { Price = 50, ProductId = "P1", ProductName = "Pencil", Quantity = 4 } },
                ShippingAddress = new Models.Address()
                {
                    Country = "USA",
                    City = "Dallas",
                    Street = "1234 right lane."
                }
            };
            //Act
            var shippingCost = shippingCalculator.CalculateShippingCost(cart);

            //Assert
            Assert.Equal(4.0, shippingCost);
        }

        [Fact]
        public void CalculateShippingCostGivenSameCityExpeditedShippingMethod()
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
                    City = "Dallas",
                    Street = "1234 right lane."
                }
            };
            //Act
            var shippingCost = shippingCalculator.CalculateShippingCost(cart);

            //Assert
            Assert.Equal(4.8, shippingCost);
        }

        [Fact]
        public void CalculateShippingCostGivenSameCityPriorityShippingMethod()
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
                    City = "Dallas",
                    Street = "1234 right lane."
                }
            };
            //Act
            var shippingCost = shippingCalculator.CalculateShippingCost(cart);

            //Assert
            Assert.Equal(8.0, shippingCost);
        }

        [Fact]
        public void CalculateShippingCostGivenSameCityExpressShippingMethod()
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
                    City = "Dallas",
                    Street = "1234 right lane."
                }
            };
            //Act
            var shippingCost = shippingCalculator.CalculateShippingCost(cart);

            //Assert
            Assert.Equal(10.0, shippingCost);
        }

        [Fact]
        public void CalculateShippingCostGivenSameCityStandardShippingMethodPremiumCustomer()
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
                    City = "Dallas",
                    Street = "1234 right lane."
                }
            };
            //Act
            var shippingCost = shippingCalculator.CalculateShippingCost(cart);

            //Assert
            Assert.Equal(4.0, shippingCost);
        }

        [Fact]
        public void CalculateShippingCostGivenSameCityExpeditedShippingMethodPremiumCustomer()
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
                    City = "Dallas",
                    Street = "1234 right lane."
                }
            };
            //Act
            var shippingCost = shippingCalculator.CalculateShippingCost(cart);

            //Assert
            Assert.Equal(4.0, shippingCost);
        }

        [Fact]
        public void CalculateShippingCostGivenSameCityPriorityShippingMethodPremiumCustomer()
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
                    City = "Dallas",
                    Street = "1234 right lane."
                }
            };
            //Act
            var shippingCost = shippingCalculator.CalculateShippingCost(cart);

            //Assert
            Assert.Equal(4.0, shippingCost);
        }

        [Fact]
        public void CalculateShippingCostGivenSameCityExpressShippingMethodPremiumCustomer()
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
                    City = "Dallas",
                    Street = "1234 right lane."
                }
            };
            //Act
            var shippingCost = shippingCalculator.CalculateShippingCost(cart);

            //Assert
            Assert.Equal(10.0, shippingCost);
        }
    }
}
