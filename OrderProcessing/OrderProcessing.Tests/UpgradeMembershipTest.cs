using BussinessRules;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace OrderProcessing.Tests
{
    public class UpgradeMembershipTest
    {
        private ConcreteOrderProcessingFactory _orderProcessingFactory;

        public UpgradeMembershipTest()
        {
            _orderProcessingFactory = new ConcreteOrderProcessingFactory();
        }
        [Theory(DisplayName = "Upgrades Membership")]
        [InlineData("upgradeToMembership")]
        public void ActivatesMembershipTest(string orderType)
        {
            // Arrange

            // Act
            Iorder order = _orderProcessingFactory.getOrderDetails(orderType);
            //_emailMembership.Setup(x => x.EMailDetails(It.IsAny<string>())).Verifiable();

            // Assert
            Assert.True(order.GetType() == typeof(UpgrateMembership));
            //_emailMembership.Verify(x => x.EMailDetails(""), Times.AtLeastOnce());
            Assert.Equal("Upgrated the membership", order.ProcessOrder());
        }
    }
}
