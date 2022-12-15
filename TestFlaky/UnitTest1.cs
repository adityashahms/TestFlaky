namespace TestFlaky
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Random rd = new Random();
            int rand_num = rd.Next(1, 4);

            Assert.IsTrue(rand_num % 2 == 1);
        }
    }
}