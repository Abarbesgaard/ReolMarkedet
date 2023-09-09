using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolMarkedet.Model
{
    public class ItemRepository
    {
        private string connectionString = "Server=10.56.8.36;Database=DB_F23_TEAM_05;User Id=DB_F23_TEAM_05;Password=TEAMDB_DB_05";
        public ItemRepository()
        { }

        public void AddItemToDatabase(Item item)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "INSERT INTO dbo.Items_Ulla (Tenant, Barcode, ItemName, ItemPrice, ItemPlace, ItemType, ChosenDiscountInProcent ) VALUES (@Tenant, @Barcode, @ItemName, @ItemPrice, @ItemPlace, @ItemType, @ItemDiscountInProcent)" +
                    "SELECT @@IDENTITY";
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@Tenant", "");
                    cmd.Parameters.AddWithValue("@Barcode", item.Barcode);
                    cmd.Parameters.AddWithValue("@ItemName", item.ItemName);
                    cmd.Parameters.AddWithValue("@ItemPrice", item.ItemPrice);
                    cmd.Parameters.AddWithValue("@ItemPlace", item.PlaceEnum);
                    cmd.Parameters.AddWithValue("@ItemType", item.TypeEnum);
                    cmd.Parameters.AddWithValue("@ItemDiscountInProcent", item.DiscountInProcent.DiscountInProcent);


                    int itemId = Convert.ToInt32(cmd.ExecuteScalar());
                    item.ItemId = itemId;

                };
            }
        }

        public void DeleteItemFromDatabase(int itemId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "DELETE FROM dbo.Items_Ulla WHERE ItemId = @ItemId";
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@ItemId", itemId);
                    int rowsAffected = cmd.ExecuteNonQuery();

                };
            }



        }
        public void UpdateItemInDatabase(int itemId) { }


        public Item GetItemFromDatabase(int itemId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "SELECT * FROM dbo.Items_Ulla WHERE ItemId = @ItemId";
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@ItemId", itemId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        reader.Read();

                        // reader.GetOrdinal returnerer det kolonne-nummer, som metodens parameter har.
                        // Så reader.GetOrdinal("Tenant") returnerer "Tenant's" kolonne-nummer som int.

                        //reader.GetString tager en int som parameter og returnerer tabel-cellens værdi som en string.
                        // tilsvarende tager GetDecimal også en int som parameter og returnerer tabel-cellens værdi, bare som en decimal.


                        string tenant = reader.GetString(reader.GetOrdinal("Tenant"));
                        string barcode = reader.GetString(reader.GetOrdinal("Barcode"));
                        string itemName = reader.GetString(reader.GetOrdinal("ItemName"));
                        decimal itemPrice = reader.GetDecimal(reader.GetOrdinal("ItemPrice"));

                        // Der findes ingen reader.GetEnum
                        //Men jeg har tastet min celle-værdi som en int (enums gemmes som tal-værdi)
                        //Jeg kan derfor stadig bruge reader.GetInt32(reader.GetOrdinal())
                        //Derfra parser jeg til den rigtige type af enum.

                        PlaceType placeType = (PlaceType)(reader.GetInt32(reader.GetOrdinal("ItemPlace")));
                        ItemType itemType = (ItemType)(reader.GetInt32(reader.GetOrdinal("ItemType")));
                        int discountInProcent = reader.GetInt32(reader.GetOrdinal("ChosenDiscountInProcent"));

                        return new Item(new Tenant(), barcode, itemName, itemPrice, placeType, itemType, discountInProcent);



                    }

                }

            }
        }
    }
}
