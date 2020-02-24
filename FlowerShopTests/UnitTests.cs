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
            IClient MockingClient = Substitute.For<IClient>();
            IOrderDAO MockingOrderDAO = Substitute.For<IOrderDAO>();
            Order me = new Order (MockingOrderDAO, MockingClient);

            //Act
            me.Deliver();

            //Assert
            MockingOrderDAO.Received().SetDelivered(me);
            //Assert.Pass();
        }

        [Test]
        public void TestPrice()
        {
            //arrange
            IClient MockingClient = Substitute.For<IClient>();
            IOrderDAO MockingOrderDAO = Substitute.For<IOrderDAO>();
            IFlowerDAO MockingFlowerDAO = Substitute.For<IFlowerDAO>();
            Order me = new Order(MockingOrderDAO, MockingClient);
            Flower MockingFlower = Substitute.For<Flower>(MockingFlowerDAO, "ThisFlower", 12.00, 6); //Price of 12.00 Rand


            //Act
            me.AddFlowers(MockingFlower,6 ); ///not sure what is wrong here. cant seem to get it to work. I get an error message with this line.

            //Assert
            Assert.AreEqual(14.40, me.Price);
        }
    }
}