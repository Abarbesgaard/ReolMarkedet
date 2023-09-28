using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using ReolMarkedet.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolMarkedet.Model.Repositories
{
    public class ReolRepository : IObjectInterface
    {
        private List<Reol> _reoler = new List<Reol>();

        private static ReolRepository instance;
        public static ReolRepository GetInstance()
        {
            if (instance == null)
            {
                instance = new ReolRepository();
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
            using(SqlConnection connection = new SqlConnection(databaseConnection.DatabaseConnectionString()))
            {
                connection.Open();
                SqlCommand command = new SqlCommand($"SELECT PlaceId FROM Shelves where PlaceId = {(string)obj}", connection);
            }
            string søgeStregkode = obj.ToString();
            foreach (var reol in _reoler)
            {
                if (reol.Id == søgeStregkode)
                    return reol;
            }
            return null;
        }

        public void List()
        {          
            DatabaseConnection databaseConnection = new DatabaseConnection();
            using (SqlConnection connection = new SqlConnection(databaseConnection.DatabaseConnectionString()))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Shelves WHERE TenantId IS NULL", connection);
                SqlDataReader reader = command.ExecuteReader();
            
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["PlaceId"]);
                    string type = (string)reader["PlaceType"];
                    Console.WriteLine($"Id: {id} Type: {type}. Er ikke udlejet");

                }
            }
     
        }

        public void Opdater(object obj, object obj2)
        {
            DatabaseConnection databaseConnection = new DatabaseConnection();
            using (SqlConnection connection = new SqlConnection(databaseConnection.DatabaseConnectionString()))
            {
                connection.Open();
                SqlCommand command = new SqlCommand($"UPDATE Shelves SET TenantId = {(string)obj} WHERE PlaceId = {(string)obj2}", connection);
                command.ExecuteNonQuery();
            }
        }

        public void Slet(object obj)
        {
            throw new NotImplementedException();
        }

        public void Tilføj(object obj)
        {
            if (obj is Reol reol)
            {
                _reoler.Add(reol);
            }
            else
            {
                throw new ArgumentException("Objektet er ikke af typen Vare");
            }
        }

        public string RetunerSeneste()
        {
            throw new NotImplementedException();
        }

        public void ListLedige(object obj)
        {
            DatabaseConnection databaseConnection = new DatabaseConnection();
            using (SqlConnection connection = new SqlConnection(databaseConnection.DatabaseConnectionString()))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Shelves WHERE TenantId IS NOT NULL", connection);
                
                SqlDataReader reader = command.ExecuteReader();


                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["PlaceId"]);
                    string type = (string)reader["PlaceType"];
                    int lejer = Convert.ToInt32(reader["TenantId"]);
                    Console.WriteLine($"Id: {id} Type: {type}. Er Udlejet til: ");

                }
            }
        }
    }
}
