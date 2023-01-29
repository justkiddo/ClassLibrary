using ClassLibrary.Classes;
using ClassLibrary.Interfaces;
using Moq;

namespace ClassLibrary.Tests
{
    [TestFixture]
    public class ShopDiscounterTests
    {
        private IShopDiscounter discounter;


        [SetUp]
        public void Setup()
        {
            var logger = new Mock<ILogger>();
            logger.Setup(l => l.Warn(It.IsAny<string>()));

            discounter = new ShopDiscounter(logger.Object);
        }

        [TearDown]
        public void Cleanup()
        {
            discounter = null;
        }

        [Test]
        [TestCase(10)]
        public void ShouldReturnItemWithCorrectPriceWhenCalled(int percent)
        {
            decimal price = 10;
            var itm = new ShopItem("test", price);

            var result = discounter.AddDiscountToItem(itm, percent);

            Assert.That(9.0, Is.EqualTo(result.Price));
        }

        [Test]
        [TestCase(120)]
        public void Test(int percent)
        {
            decimal price = 10;
            var itm = new ShopItem("test", price);

            var ex = Assert.Throws<Exception>(
                () =>
                {
                    discounter.AddDiscountToItem(itm, percent);
                });
            Assert.That(ex?.Message, Is.EqualTo("Wrong discount percent"));
        }
    }
}