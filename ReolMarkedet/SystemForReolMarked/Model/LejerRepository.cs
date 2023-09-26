using System.Data.SqlClient;
using System.Numerics;

namespace ReolMarkedet.Model
{
    public class LejerRepository : IObjectInterface
    {
        private string connectionString = "Server=10.56.8.36;Database=DB_F23_TEAM_05;User Id=DB_F23_TEAM_05;Password=TEAMDB_DB_05;";

        private List<Lejer> lejerList = new List<Lejer>();  


        public LejerRepository()
        {
        }

        public List<object> HentAlle()
        {
            throw new NotImplementedException();
        }

        public List<object> HentAlle(string idEllerStregkode)
        {
            throw new NotImplementedException();
        }

        public void Slet(object obj)
        {
            throw new NotImplementedException();
        }

        public void Tilføj(object obj)
        {
            using(SqlConnection connection = new SqlConnection(connectionString)) 
            {
                connection.Open();

                string INSERTsql = "INSERT INTO Tenant (FirstName, LastName, Email, Phone, FinancialInformation, TenantStatus) VALUES (@FirstName, @LastName, @Email, @Phone, @FinancialInformation, @TenantStatus)";

                using(SqlCommand INSERTcmd = new SqlCommand(INSERTsql, connection)) 
                {
                    INSERTcmd.Parameters.AddWithValue("@FirstName", "John");
                    INSERTcmd.Parameters.AddWithValue("@LastName", "Johnsen");
                    INSERTcmd.Parameters.AddWithValue("@Email", "JohnsEmail");
                    INSERTcmd.Parameters.AddWithValue("@Phone", "JohnsPhone");
                    INSERTcmd.Parameters.AddWithValue("@FinancialInformation", "JohnsFinance");
                    INSERTcmd.Parameters.AddWithValue("@TenantStatus", "JohnsActive");

                    int generatedTenatId = Convert.ToInt32(INSERTcmd.ExecuteScalar());

                    Console.WriteLine(generatedTenatId);
                }
            }

        }

        public void Update(object obj)
        {
            throw new NotImplementedException();
        }

        
    }
}