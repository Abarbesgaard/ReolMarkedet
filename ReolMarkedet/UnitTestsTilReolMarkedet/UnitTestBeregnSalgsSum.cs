//using ReolMarkedet.Model;

//namespace ReolMarkedet.UnitTests
//{
//    [TestClass]
//    public class UnitTestBeregnSalgsSum
//    {
//        [TestMethod]
//        public void TestBeregnSalgsSum()
//        {
//            // Arrange

//            ReolBeskrivelse reolBeskrivelse1 = new ReolBeskrivelse(ETypeAfReol.AflåstGlasSkab, true);
//            Reol reol1 = new Reol("1", reolBeskrivelse1, new Rabat(), null, 2);
//            Rabat reolRabat1 = new Rabat(null, reol1, 0, 3);
//            reol1.Rabat = reolRabat1;

//            //VareBeskrivelse vareBeskrivelse2 = new VareBeskrivelse("Lampe", EVareType.Ting, 100.0m);
//            //Vare vare1 = new Vare("123", vareBeskrivelse2, 20);
//            //Rabat vareRabat1 = new Rabat(vare1, null, 20);
//            //vare1.Rabat = vareRabat1;


//            SalgsLinje salgsLinje = new SalgsLinje();
//            List<Object> indkøbsListe = new List<Object>();

//            indkøbsListe.Add(reol1);
//            //indkøbsListe.Add((vare1));





//            // Act 

//            decimal salgSum = salgsLinje.BeregnSalgsSum();


//            // Assert

//            Assert.AreEqual(300, salgSum);


//        }
//    }
//}
