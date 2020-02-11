using Microsoft.VisualStudio.TestTools.UnitTesting;
using Class_Student_Unittest;

namespace TestFirst
{
    [TestClass]
    public class HorseTestFirst
    {
        [TestMethod]
        public void TestMethod1()
        {
            Horse horse = new Horse();
            Assert.AreEqual(4, horse.legs);
        }
    }
}


