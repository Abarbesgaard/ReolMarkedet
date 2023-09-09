using ReolMarkedet.Model;

namespace ReolMarkedet.UnitTestsTilReolMarkedet
{
    [TestClass]
    public class UnitTestCalculatePricesPlusDiscountsPlusTotalValue
    {
        [TestMethod]
        public void TestCalculatePricesPlusDiscountsPlusTotalValue()
        {
            // Arrange
            Item item1 = new Item(new Tenant(), "123", "Bamse", 20, PlaceType.Shelf, ItemType.Stuff, 10);
            Item item2 = new Item(new Tenant(), "567", "Dukke", 100, PlaceType.Shelf, ItemType.Stuff, 50);
            ItemSale itemSale = new ItemSale();
            itemSale.AddToitemsInSale(item1);
            itemSale.AddToitemsInSale(item2);
            

            // Act 
            (decimal TotalPrice, string Text) = itemSale.CalculatePricesPlusDiscountsPlusTotalValue();


            // Assert
            string ExpectedText = "Bamse: 20, Rabat: 2\r\nDukke: 100, Rabat: 50\r\n";
            Assert.AreEqual((TotalPrice, Text), (68, ExpectedText));

        }
    }
}
