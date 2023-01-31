using ClassLibrary.Classes;
using ClassLibrary.Interfaces;
using Moq;

namespace ClassLibrary.ShopTests
{
    [TestFixture]
    public class ShopTests
    {




        [SetUp]
        public void Setup()
        {
            var logger = new Mock<ILogger>();
            var database = new Mock<IDb>();
            var item = new Mock<IItem>();

            logger.Setup(l =>l.Warn(It.IsAny<string>()));
            database.Setup(d => d.GetItem(item.Name));
            
        }

        [Test]
        public void ShouldGetItemFromDatabase()
        {
            var itm = new ShopItem("test item",15);
            var db = new Mock<IDb>();
            var s = db.Setup(d => d.GetItem("test name"));
            s.Returns(itm);                                 // Не уверен в правильности реализации, хотелы чтобы итем как будто 
            Assert.That("test item", Is.EqualTo(itm.Name)); //бы возвращался из бд
        }

        [Test]
        public void Test2()
        {
            Assert.Pass();
        }
        

    }
}