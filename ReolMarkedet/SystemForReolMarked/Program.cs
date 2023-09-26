using ReolMarkedet.Model;
using System.Data.SqlClient;
using System.Net.NetworkInformation;

namespace ReolMarkedet
{
    public class Program
    {
        private const  string connectionString = "Server=10.56.8.36;Database=DB_F23_TEAM_05;User Id=DB_F23_TEAM_05;Password=TEAMDB_DB_05;";

        static void Main(string[] args)
        {
            Tilføj();
        }


        //Vare vare2 = new Vare("126", "lampe", EVareType.Ting, 20.0m, 20);
        //Salg salg = new Salg();
        //SalgsLinje salgsLinje = new SalgsLinje();
        //List<Object> indkøbsListe = new List<Object>();
        //indkøbsListe.Add(vare2);
        //salg.UdskrivKvitterig();

     
        public static void Tilføj()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string INSERTsql = "INSERT INTO TENANT (FirstName, LastName, Email, Phone, FinancialInformation, TenantStatus) VALUES (@FirstName, @LastName, @Email, @Phone, @FinancialInformation, @TenantStatus)";

                using (SqlCommand INSERTcmd = new SqlCommand(INSERTsql, connection))
                {
                    INSERTcmd.Parameters.AddWithValue("@FirstName", "John");
                    INSERTcmd.Parameters.AddWithValue("@LastName", "Johnsen");
                    INSERTcmd.Parameters.AddWithValue("@Email", "JohnsEmail");
                    INSERTcmd.Parameters.AddWithValue("@Phone", "JohnsPhone");
                    INSERTcmd.Parameters.AddWithValue("@FinancialInformation", "JohnsFinance");
                    INSERTcmd.Parameters.AddWithValue("@TenantStatus", "Active");

                    int generatedTenatId = Convert.ToInt32(INSERTcmd.ExecuteScalar());

                    Console.WriteLine(generatedTenatId);
                }

            }


        }



    }
}







