using ShoppingCartService.BusinessLogic;
using ShoppingCartService.DataAccess.Entities;
using System;
using System.Collections.Generic;
using Xunit;

namespace ShoppingCartService.Tests
{
    public class ShippingCalculatorCalculateShippingCostInternational
    {
        [Fact]
        public void CalculateShippingCostGivenStandardShippingMethod()
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
                    Country = "Mexico",
                    City = "Dallas",
                    Street = "1234 right lane."
                }
            };
            //Act
            var shippingCost = shippingCalculator.CalculateShippingCost(cart);

            //Assert
            Assert.Equal(60.0, shippingCost);
        }

        [Fact]
        public void CalculateShippingCostGivenExpeditedShippingMethod()
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
                    Country = "Mexico",
                    City = "Dallas",
                    Street = "1234 right lane."
                }
            };
            //Act
            var shippingCost = shippingCalculator.CalculateShippingCost(cart);

            //Assert
            Assert.Equal(72.0, shippingCost);
        }

        [Fact]
        public void CalculateShippingCostGivenPriorityShippingMethod()
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
                    Country = "Mexico",
                    City = "Dallas",
                    Street = "1234 right lane."
                }
            };
            //Act
            var shippingCost = shippingCalculator.CalculateShippingCost(cart);

            //Assert
            Assert.Equal(120.0, shippingCost);
        }

        [Fact]
        public void CalculateShippingCostGivenExpressShippingMethod()
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
                    Country = "Mexico",
                    City = "Dallas",
                    Street = "1234 right lane."
                }
            };
            //Act
            var shippingCost = shippingCalculator.CalculateShippingCost(cart);

            //Assert
            Assert.Equal(150.0, shippingCost);
        }

        [Fact]
        public void CalculateShippingCostGivenStandardShippingMethodPremiumCustomer()
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
                    Country = "Mexico",
                    City = "Dallas",
                    Street = "1234 right lane."
                }
            };
            //Act
            var shippingCost = shippingCalculator.CalculateShippingCost(cart);

            //Assert
            Assert.Equal(60.0, shippingCost);
        }

        [Fact]
        public void CalculateShippingCostGivenExpeditedShippingMethodPremiumCustomer()
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
                    Country = "Mexico",
                    City = "Dallas",
                    Street = "1234 right lane."
                }
            };
            //Act
            var shippingCost = shippingCalculator.CalculateShippingCost(cart);

            //Assert
            Assert.Equal(60.0, shippingCost);
        }

        [Fact]
        public void CalculateShippingCostGivenPriorityShippingMethodPremiumCustomer()
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
                    Country = "Mexico",
                    City = "Dallas",
                    Street = "1234 right lane."
                }
            };
            //Act
            var shippingCost = shippingCalculator.CalculateShippingCost(cart);

            //Assert
            Assert.Equal(60.0, shippingCost);
        }

        [Fact]
        public void CalculateShippingCostGivenExpressShippingMethodPremiumCustomer()
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
                    Country = "Mexico",
                    City = "Dallas",
                    Street = "1234 right lane."
                }
            };
            //Act
            var shippingCost = shippingCalculator.CalculateShippingCost(cart);

            //Assert
            Assert.Equal(150.0, shippingCost);
        }
    }
}
