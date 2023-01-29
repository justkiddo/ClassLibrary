namespace ClassWork.Tests
{
    [TestFixture]
    public class CalcTests
    {
        private Calc calculatorInst;

        //[SetUp]
        //public void Setup()
        //{
        //    calculatorInst = new Calc();
        //}

        //[TearDown]
        //public void Cleanup()
        //{
        //    calculatorInst = null;
        //}

        [Test]
        [TestCase(1,1, 2)]
        [TestCase(2, 1, 3)]
        public void SumMethodShouldSumTwoIntegersWhenCalled(int a, int b, int expectedResult)
        {
            //arrange
            calculatorInst = new Calc();

            //act
            var result = calculatorInst.Sum(a,b);

            //assert
            Assert.That(expectedResult, Is.EqualTo(result));
        }
    }
}