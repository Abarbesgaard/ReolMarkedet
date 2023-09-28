using Microsoft.Data.SqlClient;
using ReolMarkedet.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ReolMarkedet.Model.Repositories
{
    public class VareRepository : IObjectInterface
    {
        public List<Vare> _varer = new List<Vare>();
        private Vare Vare { get; set; }

        public void Fjern(object obj)
        {
            throw new NotImplementedException();
        }

        public void Opdater(object obj, object obj2)
        {
            throw new NotImplementedException();
        }

        public void Slet(object obj)
        {
            throw new NotImplementedException();
        }

        public void Tilføj(object obj)
        {
            // Gammel implementering
            if (obj is Vare vare)
            {
                _varer.Add(vare);
            }
            else
            {
                throw new ArgumentException("Objektet er ikke af typen Vare");
            }
        }

        object IObjectInterface.HentViaStregkode(object obj)
        {
            string søgeStregkode = obj.ToString();
            foreach (var vare in _varer)
            {
                if (vare.Stregkode == søgeStregkode)
                    return vare;
            }
            return null;
        }

        public void List()
        {
            DatabaseConnection databaseConnection = new DatabaseConnection();
            using (SqlConnection connection = new SqlConnection(databaseConnection.DatabaseConnectionString()))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Items", connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string stregkode = (string)reader["ItemLineCode"];
                    string vareType = (string)reader["ItemType"];
                    string pris = (string)reader["Phone"];
                    

                    Console.WriteLine($"Vare: {stregkode}, {vareType}, Pris: {pris}");

                }
            }

        }

        public string RetunerSeneste()
        {
            throw new NotImplementedException();
        }

        public void ListLedige()
        {
            throw new NotImplementedException();
        }

        public void ListLedige(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
