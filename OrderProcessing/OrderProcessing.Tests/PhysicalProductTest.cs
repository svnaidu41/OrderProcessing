using BussinessRules;
using System;
using Xunit;

namespace OrderProcessing.Tests
{
    //If the payment is for a physical product, generate a packing slip for shipping.
    public class PhysicalProductTest
    {
        private ConcreteOrderProcessingFactory _orderProcessingFactory;

        public PhysicalProductTest()
        {
            _orderProcessingFactory = new ConcreteOrderProcessingFactory();
        }
        [Theory(DisplayName = "Generates Physical Product")]
        [InlineData("physicalProduct")]
        public void GeneratePhyicalProductTest(string orderType)
        {
            // Arrange

            // Act
            Iorder order = _orderProcessingFactory.getOrderDetails(orderType);

            // Assert
            Assert.True(order.GetType() == typeof(PhysicalProduct));
            Assert.Equal("packing slip for shipping",order.ProcessOrder());
        }
    }
}
