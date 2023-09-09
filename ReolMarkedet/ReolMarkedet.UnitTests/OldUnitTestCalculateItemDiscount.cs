using ReolMarkedet.Model;

namespace ReolMarkedet.UnitTests
{
    [TestClass]
    public class CalculateItemDiscount
    {
        [TestMethod]
        public void TestCalculateItemDiscount()
        {
            // Arrange
            OldItem item = new OldItem(1, new OldTenant(), "223", "dukke", 200.00, OldPlaceType.Shelf, OldItemType.Stuff);
            OldDiscount discount = new OldDiscount(item, 10);
           

            // Act 
            discount.CalculateItemDiscount(item);


            // Assert
            Assert.AreEqual(180, discount.CalculateItemDiscount(item));


        }
    }
}
