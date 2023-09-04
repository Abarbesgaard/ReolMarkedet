using ReolMarkedet.Model;

namespace ReolMarkedet
{
    public class Program
    {
        static void Main(string[] args)
        {
            Item item0 = new Item(1,"sdf","123123123","Ole Hansen", 1.54f,"reol", Model.Enum.TypeEnum.Clothes, 0.25f);
            Item item1 = new Item(1,"sdf","123123123","Ole Hansen", 1.54f,"reol", Model.Enum.TypeEnum.Clothes, 0.25f);
            Item item2 = new Item(1, "sdf", "123123123", "Ole Hansen", 1.54f, "reol", Model.Enum.TypeEnum.Clothes, 0.25f);


            ItemSale itemSale = new ItemSale();
            itemSale.items.Add(item0);
            itemSale.items.Add(item1);
            itemSale.items.Add(item2);

            itemSale.CreateSale();
            Console.ReadLine();
        }
    }
}