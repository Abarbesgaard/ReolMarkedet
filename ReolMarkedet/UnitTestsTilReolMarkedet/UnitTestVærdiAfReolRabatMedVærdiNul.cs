using ReolMarkedet.Model;

namespace ReolMarkedet.UnitTests
{
    [TestClass]
    public class UnitTestVærdiAfReolRabatMedVærdiNul
    {
        [TestMethod]
        public void TestVærdiafReolRabatMedVærdiNul()
        {
            // Arrange

            Reol reol1 = new Reol(2, ETypeAfReol.AflåstGlasSkabHylde, true, 100.0m, 2);




            // Act 
            decimal værdiAfReolRabat = reol1.UdlejningsRabat.BeregnVærdiAfReolRabat();


            // Assert

            Assert.AreEqual(0m, værdiAfReolRabat);

        }
    }
}
