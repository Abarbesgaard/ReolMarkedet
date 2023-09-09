using ReolMarkedet.Model;

namespace ReolMarkedet.UnitTests
{
    [TestClass]
    public class UnitTestCalculateValueOfDiscount

    {
        [TestMethod]
        public void TestCalculateValueOfDiscount()
        {
            // Arrange
            Item item1 = new Item( new Tenant(), "123", "Bamse", 20, PlaceType.Shelf, ItemType.Stuff, 10);
            Discount discount = new Discount(item1, 10);


            // Act 
            decimal ValueOfItemDiscount = discount.CalculateValueOfItemDiscount(item1);
         

            // Assert
            Assert.AreEqual(2, ValueOfItemDiscount);
            

        }
    }
}
