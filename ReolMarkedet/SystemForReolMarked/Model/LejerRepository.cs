using System.Data.SqlClient;
using System.Numerics;

namespace ReolMarkedet.Model
{
    public class LejerRepository : IObjectInterface
    {
        private string connectionString = "Server=10.56.8.36;Database=DB_F23_TEAM_05;User Id=DB_F23_TEAM_05;Password=TEAMDB_DB_05;";

        private static int lejerId;
        private static string fornavn;
        private static string efternavn;
        private static string status;
        private static string bankoplysninger;
        private static string email;
        private static string tlf;

        

        private List<Lejer> lejerList = new List<Lejer>();

        Lejer lejer = new Lejer(fornavn, efternavn, status, bankoplysninger, email, tlf);





        public LejerRepository()
        {
        }


        public Lejer OpretLejerFraBrugerInput(string fornavn, string efternavn, string status, string bankoplysninger, string email, string tlf)
        {
            lejer = new Lejer(fornavn, efternavn, status, bankoplysninger, email, tlf);
            return lejer;
        }

        public List<object> HentAlle()
        {
            throw new NotImplementedException();
        }

        public Object HentObject(int idEllerStregkode)
        {
            Lejer valgtLejer = null;
            using(SqlConnection connection = new SqlConnection(connectionString)) 
            {
                connection.Open();

                string SELECTsql = $"SELECT * FROM TENANT WHERE TenantId = {idEllerStregkode}";

                using (SqlCommand command = new SqlCommand(SELECTsql, connection)) 
                {
                    using(SqlDataReader reader = command.ExecuteReader()) 
                    {
                        while (reader.Read()) 
                        {
                            int lejerId = reader.GetInt32(0);
                            string fornavn = reader.GetString(1);
                            string efternavn = reader.GetString(2);
                            string email = reader.GetString(3);
                            string tlf = reader.GetString(4);
                            string bankoplysninger = reader.GetString(5);
                            string status = reader.GetString(6);

                            Lejer valgtlejer = new Lejer(fornavn, efternavn, status, bankoplysninger, email, tlf); 
                            Console.WriteLine(valgtlejer.ToString());
                            
                            
                        }                        
                    }
                }
            } return valgtLejer;           
        }

        public void Slet(object obj)
        {
            throw new NotImplementedException();
        }

        public void Tilføj(Object obj )
        {
            Lejer lejer = obj as Lejer;

            using(SqlConnection connection = new SqlConnection(connectionString)) 
            {
                connection.Open();

                string INSERTsql = "INSERT INTO Tenant (FirstName, LastName, Email, Phone, FinancialInformation, TenantStatus) VALUES (@FirstName, @LastName, @Email, @Phone, @FinancialInformation, @TenantStatus); " +
                    "SELECT SCOPE_IDENTITY() as TenantId";

                string firstName = lejer.LejerBeskrivelse.Fornavn;
                string lastName = lejer.LejerBeskrivelse.Efternavn;
                string email = lejer.LejerBeskrivelse.Email;
                string phone = lejer.LejerBeskrivelse.Tlf;
                string financialInformation = lejer.LejerBeskrivelse.BankOplysninger;
                string tenantStatus = lejer.LejerBeskrivelse.Status;
                
                
                
                using(SqlCommand INSERTcmd = new SqlCommand(INSERTsql, connection)) 
                {
                    INSERTcmd.Parameters.AddWithValue("@FirstName", $"{firstName}");
                    INSERTcmd.Parameters.AddWithValue("@LastName", $"{lastName}");
                    INSERTcmd.Parameters.AddWithValue("@Email", $"{email}");
                    INSERTcmd.Parameters.AddWithValue("@Phone", $"{phone}");
                    INSERTcmd.Parameters.AddWithValue("@FinancialInformation", $"{financialInformation}");
                    INSERTcmd.Parameters.AddWithValue("@TenantStatus", $"{tenantStatus}");

                    int? tenantId = null;
                    var result = INSERTcmd.ExecuteScalar();
                    if( result != null) 
                    {
                        tenantId = (int?)result;
                        Console.WriteLine($"tenantId = {tenantId}");
                    }

                }
            }

        }

        public void Update(object obj)
        {
            throw new NotImplementedException();
        }

        
    }
}