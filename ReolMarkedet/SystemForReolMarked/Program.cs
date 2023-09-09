using ReolMarkedet.Model;

namespace SystemForReolMarked
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Item item1 = new Item( new Tenant(), "123", "Bamse", 25f, PlaceType.Shelf, ReolMarkedet.ItemType.Clothes, 25);
            //ItemRepository itemRepo = new ItemRepository();
            //itemRepo.AddItemToDatabase(item1);
            //Item item2 = new Item( new Tenant(), "156", "Dukke", 80f, PlaceType.Shelf, ReolMarkedet.ItemType.Clothes, 20);
            //itemRepo.AddItemToDatabase(item2);

            ItemRepository itemRepo = new ItemRepository();
            Item item1 = new Item(new Tenant(), "123", "Bamse", 25, PlaceType.Shelf, ReolMarkedet.ItemType.Stuff, 25);
            itemRepo.AddItemToDatabase(item1);
            Item item2 = new Item(new Tenant(), "156", "Dukke", 80, PlaceType.Shelf, ReolMarkedet.ItemType.Clothes, 20);
            itemRepo.AddItemToDatabase(item2);
            Item selectedItem1 = itemRepo.GetItemFromDatabase(item1.ItemId);
            Item selectedItem2 = itemRepo.GetItemFromDatabase(item2.ItemId);
            ItemSale itemSale = new ItemSale();
            itemSale.AddToitemsInSale(selectedItem1);
            itemSale.AddToitemsInSale(selectedItem2);
            (decimal totalPrice, string Text) = itemSale.CalculatePricesPlusDiscountsPlusTotalValue();
            Console.WriteLine(Text);
            Console.WriteLine(totalPrice.ToString());



        }
    }
}