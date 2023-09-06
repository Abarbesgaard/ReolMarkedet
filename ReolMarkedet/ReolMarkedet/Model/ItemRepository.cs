using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using ReolMarkedet.Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolMarkedet.Model
{
    public class ItemRepository : IItemRepository
    {
        public List<Item> Items = new List<Item>();
       

        
        public void AddItemToList(Item item)
        {
            
            Items.Add(item);
        }

        public void RemoveItemFromList(Item item)
        {
            
            Items.Remove(item);
        }

        public void UpdateItemList(Item item)
        {
           
            string userInput = string.Empty;
            int itemID = 0;
            
            if (itemID == int.Parse(userInput)) 
            { 
            
            }
        }
        public string DatabaseConnectionString()
        {
            IConfigurationRoot config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

            string? ConnectionString = config.GetConnectionString("MyDBConnection");

            return ConnectionString;

        }

        public void RetrieveAll()
        {
            using (SqlConnection connection = new SqlConnection(DatabaseConnectionString()))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT ItemId, Tenant, Barcode, ItemName, Price, Place, ShelfType, Discount FROM Item", connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {    
                        Item item = new Item
                        {
                            Id = Convert.ToInt32(reader["ItemId"].ToString()),
                            Tenant = reader["Tenant"].ToString(),
                            Barcode = reader["Barcode"].ToString(),
                            Name = reader["ItemName"].ToString(),
                            Price = float.Parse(reader["Price"].ToString()),
                            Place = reader["Place"].ToString(),
                            Type = (TypeEnum)Enum.TypeEnum.Parse(typeof(TypeEnum), reader["ShelfType"].ToString()),
                            Discount = float.Parse(reader["Discount"].ToString()),
                        };

                        Items.Add(item);
                    }
                }
            }

        }
        public List<string> SelectDistinctTenant()
        {
            List<string> uniqueTenants = new List<string>();
            using (SqlConnection connection = new SqlConnection(DatabaseConnectionString()))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT ItemId, Tenant, Barcode, ItemName, Price, Place, ShelfType, Discount FROM Item", connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Item item = new Item
                        {
                            Id = Convert.ToInt32(reader["ItemId"].ToString()),
                            Tenant = reader["Tenant"].ToString(),
                            Barcode = reader["Barcode"].ToString(),
                            Name = reader["ItemName"].ToString(),
                            Price = float.Parse(reader["Price"].ToString()),
                            Place = reader["Place"].ToString(),
                            Type = (TypeEnum)Enum.TypeEnum.Parse(typeof(TypeEnum), reader["ShelfType"].ToString()),
                            Discount = float.Parse(reader["Discount"].ToString()),
                        };
                        Items.Add(item);
                    }
                }
            }
            return uniqueTenants;
        }
    }

}
