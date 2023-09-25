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
          
           
            VareBeskrivelse vareBeskrivelse1 = new VareBeskrivelse("Bamse", EVareType.Ting, 20.0m);
            Vare vare1 = new Vare("123", vareBeskrivelse1, 10);
            Rabat rabat1 = new Rabat(vare1, 10, 0);


            // Act

            decimal værdiAfRabat1 = rabat1.VærdiAfRabat();




            // Assert

            Assert.AreEqual(2.0m, værdiAfRabat1);


        }
    }
}
