namespace TestProject1
{
    [TestClass]
    public class ListDrones
    {
        [TestMethod]
        public void Test1()
        {
            int numberTen = 10;
            int numberNine = 9;


            int result = numberTen;

            Assert.AreEqual(numberNine, result);

        }
        [TestMethod]
        public void Test2()
        {
            int numberTen = 10;


            int result = numberTen;

            Assert.AreEqual(numberTen, result);
        }
        [TestMethod]
        public void Test3()
        {
            int numberTen = 10;
            int numberEleven = 11;


            int result = numberTen;

            Assert.AreEqual(numberEleven, result,"Le nombre doit etre maximum 10.");
        }
    }
}