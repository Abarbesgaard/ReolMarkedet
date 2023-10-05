using ReolMarkedet.Model;

namespace ReolMarkedet.UnitTests
{
    [TestClass]
    public class UnitTestCalculateTotalPrice
    {
        [TestMethod]
        public void TestCalculateTotalPrice()
        {
            // Arrange
            OldItemSale itemSale = new OldItemSale();
            OldItem item1 = new OldItem(1, new OldTenant(), "123", "bamse", 100.00, OldPlaceType.Shelf, OldItemType.Clothes );
            item1.Price = 100;
            OldItem item2 = new OldItem(2, new OldTenant(), "567", "dukke", 50.00, OldPlaceType.Floor, OldItemType.Stuff);
            item2.Price = 20;
            itemSale.Add(item1);
            itemSale.Add(item2);



            // Act 
            Double total = itemSale.CalculateTotalItemPrice();


            // Assert
            Assert.AreEqual(120, total);

        }
    }
}