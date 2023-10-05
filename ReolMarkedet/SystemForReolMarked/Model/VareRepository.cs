using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ReolMarkedet.Model
{
    public class VareRepository: IObjectInterface
    {
        private string connectionString = "Server=10.56.8.36;Database=DB_F23_TEAM_05;User Id=DB_F23_TEAM_05;Password=TEAMDB_DB_05;";
        public Vare OpretVareUdFraBrugerInput(string stregkode, string navn, EVareType vareType, decimal pris, int rabatIProcent = 0) 
        {
            Vare vare = new Vare(stregkode, navn, vareType, pris, rabatIProcent);
            return vare;
        }



        public object HentObject(int idEllerStregkodeInt)
        {
            Vare vare = null;
            using (SqlConnection connectinon  = new SqlConnection(connectionString)) 
            {
                connectinon.Open();

                string SELECTsql = "SELECT * from ITEM_AND_SERVICE where Barcode = @idEllerStregkode";
                using (SqlCommand cmd = new SqlCommand(SELECTsql, connectinon))
                {
                    string idEllerStregkode = idEllerStregkodeInt.ToString();
                    cmd.Parameters.AddWithValue("@idEllerStregkode", idEllerStregkode);


                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string stregkode = reader.GetString(0);
                            string navn = reader.GetString(1);
                            EVareType vareType = (EVareType)Enum.Parse(typeof(EVareType), reader.GetString(2));
                            decimal pris = reader.GetDecimal(4);
                            int rabatIProcent = reader.GetInt32(5);

                            vare = new Vare(stregkode, navn, vareType, pris, rabatIProcent);


                            
                        }
                    }
                }
            } return vare;
        }

        

        public void Slet(object obj)
        {
            throw new NotImplementedException();
        }

        public void Tilføj(object obj)
        {
            Vare vare = obj as Vare;
            if (vare != null) 
            {
                using (SqlConnection connection = new SqlConnection(connectionString)) 
                {
                    connection.Open();

                    
                    string INSERTsql = "INSERT INTO ITEM_AND_SERVICE (Barcode, ItemName, ItemType, ItemPrice, DiscountInProcent)" +
                        " VALUES (@barcode, @itemName, @itemType, @itemPrice, @discountInProcent);";

                    string barcode = vare.Stregkode;
                    string itemName = vare.VareBeskrivelse.Navn;
                    string itemType = vare.VareBeskrivelse.VareType.ToString();
                    decimal itemPrice = vare.VareBeskrivelse.Pris;
                    int discountInProcent = vare.RabatIProcent;

                    using( SqlCommand cmd = new SqlCommand(INSERTsql, connection)) 
                    {
                        cmd.Parameters.AddWithValue("@barcode", barcode);
                        cmd.Parameters.AddWithValue("@itemName", itemName);
                        cmd.Parameters.AddWithValue("@itemType", itemType);
                        cmd.Parameters.AddWithValue("@itemPrice", itemPrice);
                        cmd.Parameters.AddWithValue("@discountInProcent", discountInProcent
                        );

                        cmd.ExecuteNonQuery();
                    }
                   
                }
            }
        }

        public void Update(Object obj)
        {
            Vare vare = obj as Vare;    
            using ( SqlConnection connection = new SqlConnection(connectionString)) 
            {
                connection.Open();

                string UpdateSqlStatement = "UPDATE dbo.ITEM_AND_SERVICE  SET ItemName = @itemName, ItemType = @itemType, ItemPrice = @itemPrice, DiscountInProcent = @discountInProcent, ShelfId = @shelfId  " +
                    " WHERE Barcode = @barcode ";

                string barcode = vare.Stregkode;
                string itemName = vare.VareBeskrivelse.Navn;
                EnumMapperVareType emt = new EnumMapperVareType();
                string enumString = emt.GetStringValueFromEnum(vare.VareBeskrivelse.VareType);
                decimal itemPrice = vare.VareBeskrivelse.Pris;
                int discountInProcent = vare.RabatIProcent;
                int shelfId = vare.Reol;

                using (SqlCommand cmd = new SqlCommand(UpdateSqlStatement, connection))
                {
                    cmd.Parameters.AddWithValue("@barcode", barcode);
                    cmd.Parameters.AddWithValue("@itemName", itemName);
                    cmd.Parameters.AddWithValue("@itemType", enumString);
                    cmd.Parameters.AddWithValue("@itemPrice", itemPrice);
                    cmd.Parameters.AddWithValue("@discountInProcent", discountInProcent);
                    cmd.Parameters.AddWithValue("@shelfId", shelfId);

                    cmd.ExecuteNonQuery();

                }
            }

        }

        
    }
}
