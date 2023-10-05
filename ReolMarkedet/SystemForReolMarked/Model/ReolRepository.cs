using ReolMarkedet.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolMarkedet.Model
{
    public class ReolRepository : IObjectInterface
    {
        private string connectionString = "Server=10.56.8.36;Database=DB_F23_TEAM_05;User Id=DB_F23_TEAM_05;Password=TEAMDB_DB_05;";
        EnumMapperReol EnumMapperReol { get; set; }


        public ReolRepository()
        {
            EnumMapperReol enumMapperReol = new EnumMapperReol();
            ETypeAfReol enumValueAflåstGlasSkab = ETypeAfReol.AflåstGlasSkab;
            string stringValueAflåstGlasSkab = enumMapperReol.GetStringValueFromEnum(enumValueAflåstGlasSkab);

            ETypeAfReol enumValueAflåstGlasSkabHylde = ETypeAfReol.AflåstGlasSkab;
            string stringValueAflåstGlasSkabHylde = enumMapperReol.GetStringValueFromEnum(enumValueAflåstGlasSkabHylde);

            ETypeAfReol enumValueGulvPlads = ETypeAfReol.AflåstGlasSkab;
            string stringValueGulvPlads = enumMapperReol.GetStringValueFromEnum(enumValueGulvPlads);

            ETypeAfReol enumValueAlmindeligReol = ETypeAfReol.AflåstGlasSkab;
            string stringValueAlmindeligReol = enumMapperReol.GetStringValueFromEnum(enumValueAlmindeligReol);
        }


        public Reol OpretReolFraBrugerInput(int reolId, ETypeAfReol typeAfReol, string status, decimal pris, int antalUdlejningsUger = 0)
        {
            Reol reol = new Reol(reolId, typeAfReol, status, pris, antalUdlejningsUger);
            return reol;
        }



        public object HentObject(int idEllerStregkode)
        {
            Reol reol = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string SELECTsql = $"SELECT * FROM SHELF WHERE ShelfId = @shelfId";
                using (SqlCommand command = new SqlCommand(SELECTsql, connection))
                {
                    command.Parameters.AddWithValue("@shelfId", idEllerStregkode);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int shelfId = reader.GetInt32(0);
                            string shelfTypeString = reader.GetString(1);
                            string shelfStatus = reader.GetString(2);
                            decimal shelfprice = reader.GetDecimal(3);
                            int numberOfRentedWeeks = reader.GetInt32(4);

                            if (!reader.IsDBNull(5)) 
                            {
                                decimal shelfDiscount = reader.GetDecimal(5);
                            }
                            
                            if (Enum.TryParse<ETypeAfReol>(shelfTypeString, out ETypeAfReol result))
                            {
                                reol = new Reol(shelfId, result, shelfStatus, shelfprice, numberOfRentedWeeks);
                                Console.WriteLine(reol.ToString());
                            }

                            
                        }
                    }
                }
            }
            return reol;
        }



        public void Slet(object obj)
        {
            throw new NotImplementedException();
        }





        public void Tilføj(object obj)
        {
            Reol reol = obj as Reol;

            if (reol != null)
            {
                EnumMapperReol enumMapperReol = new EnumMapperReol();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string INSERTsql = "INSERT INTO SHELF (ShelfType, ShelfStatus, ShelfPrice, NUmberOfRentedWeeks ) VALUES (@shelfType, @shelfStatus, @shelfPrice, @numberOfRentedWeeks)";

                    string shelfType = enumMapperReol.GetStringValueFromEnum(reol.ReolBeskrivelse.TypeAfReol);
                    string shelfStatus = reol.ReolBeskrivelse.Status;
                    decimal shelfPrice = reol.ReolBeskrivelse.Pris;
                    decimal numberOfRentedWeeks = reol.ReolBeskrivelse.AntalUdlejningsUger;

                    SqlCommand cmd = new SqlCommand(INSERTsql, connection);

                    cmd.Parameters.AddWithValue("@shelfType", shelfType);
                    cmd.Parameters.AddWithValue("@shelfStatus", shelfStatus);
                    cmd.Parameters.AddWithValue("@shelfPrice", shelfPrice);
                    cmd.Parameters.AddWithValue("@numberOfRentedWeeks", numberOfRentedWeeks);

                    cmd.ExecuteNonQuery();

                }
            }

            
        }

        public void Update(object obj)
        {
            Reol reol = obj as Reol;
            if (reol != null) 
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string UpdateSqlString = "UPDATE dbo.SHELF SET ShelfType = @shelfType, ShelfStatus = @shelfStatus, ShelfPrice = @shelfPrice, " +
                        "NumberOfRentedWeeks = @numberOfRentedWeeks, TenantId = @tenantId  WHERE ShelfId = @shlefId";

                    int reolId = reol.ReolId;
                    string shelfType = reol.ReolBeskrivelse.TypeAfReol.ToString();
                    string shelfStatus = reol.ReolBeskrivelse.Status;
                    decimal shelfPrice = reol.ReolBeskrivelse.Pris;
                    int numberOfRentedWeeks = reol.ReolBeskrivelse.AntalUdlejningsUger;
                    int tenantId = reol.LejerId;

                    using (SqlCommand cmd = new SqlCommand(UpdateSqlString, connection))
                    {
                        cmd.Parameters.AddWithValue("@shelfType", shelfType);
                        cmd.Parameters.AddWithValue("@shelfStatus", shelfStatus);
                        cmd.Parameters.AddWithValue("@shelfPrice", shelfPrice);
                        cmd.Parameters.AddWithValue("@numberOfRentedWeeks", numberOfRentedWeeks);
                        cmd.Parameters.AddWithValue("@tenantId", tenantId);
                        cmd.Parameters.AddWithValue("@reolId", reolId);

                        cmd.ExecuteNonQuery();

                    }
                }
            }

        }


        //public void VisReolerMedLedighedPåSøndag() 
        //{
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        string SELECTstring = "SELECT ReolId FROM dbo.SHELF WHERE "




        //    }
        //}
    }
}
