using BussinessRules;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace OrderProcessing.Tests
{
    public class LearningtoSkiTest
    {
        private ConcreteOrderProcessingFactory _orderProcessingFactory;

        public LearningtoSkiTest()
        {
            _orderProcessingFactory = new ConcreteOrderProcessingFactory();
        }
        [Theory(DisplayName = "Learning to SKI")]
        [InlineData("Learning to Ski")]
        public void ActivatesMembershipTest(string orderType)
        {
            // Arrange

            // Act
            Iorder order = _orderProcessingFactory.getOrderDetails(orderType);

            // Assert
            Assert.True(order.GetType() == typeof(LearningToSki));
            Assert.Equal("free “First Aid” video to the packing slip (the result of a court decision in 1997)", order.ProcessOrder());
        }
    }
}
