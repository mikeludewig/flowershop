using NUnit.Framework;
using NSubstitute;
using FlowerShop;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void DeliveryTest1()
        {
            //arrange
            IClient MockClient = Substitute.For<IClient>();
            IOrderDAO MockOrderDAO = Substitute.For<IOrderDAO>();
            Order me = new Order (MockOrderDAO, MockClient);

            //Act
            me.Deliver();

            //Assert
            MockOrderDAO.Received().SetDelivered(me);
            //Assert.Pass();
        }
    }
}