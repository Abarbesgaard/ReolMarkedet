using ReolMarkedet.Model;

namespace ReolMarkedet.UnitTests
{
    [TestClass]
    public class UnitTestVærdiAfReolRabatMedReelVærdi
    {
        [TestMethod]
        public void TestVærdiafReolRabatMedReelVærdi()
        {
            // Arrange

            Reol reol1 = new Reol(2, ETypeAfReol.AflåstGlasSkabHylde, true, 100.0m, 5);




            // Act 
            decimal værdiAfReolRabat = reol1.UdlejningsRabat.BeregnVærdiAfReolRabat();


            // Assert

            Assert.AreEqual(50m, værdiAfReolRabat);

        }
    }
}

