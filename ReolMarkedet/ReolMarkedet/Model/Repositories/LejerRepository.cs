using Microsoft.Data.SqlClient;
using ReolMarkedet.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolMarkedet.Model.Repositories
{
    public class LejerRepository : IObjectInterface
    {
        List<Lejer> _lejer = new List<Lejer>();
        private static LejerRepository instance;
        public static LejerRepository GetInstance()
        {
            if (instance == null)
            {
                instance = new LejerRepository();
            }
            return instance;
        }
        public void Fjern(object obj)
        {
            throw new NotImplementedException();
        }

        public object HentViaStregkode(object obj)
        {
            DatabaseConnection databaseConnection = new DatabaseConnection();
            using (SqlConnection connection = new SqlConnection(databaseConnection.DatabaseConnectionString()))
            {
                connection.Open();
                SqlCommand command = new SqlCommand($"SELECT TenantId FROM Tenants where TenantId = {(string)obj}", connection);
            }
            string søgeStregkode = obj.ToString();
            foreach (var lejer in _lejer)
            {
                if (lejer.Id == søgeStregkode)
                    return lejer;
            }
            return null;
        }

        public void List()
        {
            DatabaseConnection databaseConnection = new DatabaseConnection();
            using (SqlConnection connection = new SqlConnection(databaseConnection.DatabaseConnectionString()))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Tenants", connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string FirstName = (string)reader["FirstName"];
                    string LastName = (string)reader["LastName"];
                    string Tlf = (string)reader["Phone"];
                    string Email = (string)reader["Email"];
                    
                    Console.WriteLine($"navn: {FirstName} {LastName}, TLF nr.: {Tlf}, Email: {Email}");

                }
            }
        }

       

        public void ListLedige(object obj)
        {
            throw new NotImplementedException();
        }

        public void Opdater(object obj, object obj2)
        {
            throw new NotImplementedException();
        }

        public string RetunerSeneste()
        {

            DatabaseConnection databaseConnection = new DatabaseConnection();
            using (SqlConnection connection = new SqlConnection(databaseConnection.DatabaseConnectionString()))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT MAX(TenantId) FROM Tenants;", connection);
                object result = command.ExecuteScalar();
               
                return Convert.ToString(result);
            } 
        }

        public void Slet(object obj)
        {
            throw new NotImplementedException();
        }

        public void Tilføj(object obj)
        {
            
            Lejer lejer = (Lejer)obj;
            DatabaseConnection databaseConnection = new DatabaseConnection();
            using (SqlConnection connection = new SqlConnection(databaseConnection.DatabaseConnectionString()))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("INSERT INTO Tenants(LastName, FirstName, Phone, Email) VALUES(@LastName, @FirstName, @Phone, @Email); " + "SELECT CAST(scope_identity() AS int)", connection);
                    command.Parameters.AddWithValue("@LastName", lejer.LejerBeskrivelse.EfterNavn);
                    command.Parameters.AddWithValue("@FirstName", lejer.LejerBeskrivelse.ForNavn);
                    command.Parameters.AddWithValue("@Phone", lejer.LejerBeskrivelse.Tlf);
                    command.Parameters.AddWithValue("@Email", lejer.LejerBeskrivelse.Email);
                    int tenantID = (Int32)command.ExecuteScalar();
                    Console.WriteLine($"Ny lejer tilføjet med ID: {tenantID}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Der opstod en fejl: {ex.Message}");
                }
            }
           
        }
    }
}

