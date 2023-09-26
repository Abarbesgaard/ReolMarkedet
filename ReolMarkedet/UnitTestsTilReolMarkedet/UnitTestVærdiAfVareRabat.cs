using ReolMarkedet.Model;

namespace ReolMarkedet.UnitTests
{
    [TestClass]
    public class UnitTestVærdiAfVareRabat
    {
        [TestMethod]
        public void TestVærdiAfVareRabat()
        {
            // Arrange
           Vare vare1 = new Vare("123", "Bamse", EVareType.Ting, 20.0m, 10);



            // Act

            decimal værdiAfRabat1 = vare1.VareRabat.BeregnVærdiAfVareRabat();




            // Assert

            Assert.AreEqual(2.0m, værdiAfRabat1);


        }
    }
}
