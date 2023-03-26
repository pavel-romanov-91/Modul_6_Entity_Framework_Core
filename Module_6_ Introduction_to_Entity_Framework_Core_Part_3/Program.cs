using Module_6__Introduction_to_Entity_Framework_Core_Part_3.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_6__Introduction_to_Entity_Framework_Core_Part_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //using (IDbConnection connection = new SqlConnection(Settings.Default.DbConnect))
            //{
            //    IDbCommand command = new SqlCommand("SELECT * FROM countries");
            //    command.Connection = connection;
            //    connection.Open();
            //    IDataReader reader = command.ExecuteReader();
            //    while (reader.Read())
            //    {
            //        Console.WriteLine("Индификатор: {0}\tname:{1}", reader.GetInt32(0),
            //            reader.GetString(1));
            //    }
            //}
            //Console.ReadLine();
            var countries = GetCountriesEF();
            foreach (var countrie in countries)
            {
                Console.WriteLine("Индификатор: {0}\tname:{1}", countrie.id, countrie.name);
            }
            Console.ReadLine();
        }
        private static List<countries> GetCountriesEF()
        {
            var context = new TestDbContecs();
            IQueryable<countries> query = context.countries.Where(c => c.capital_id == 1);
            List<countries> countries = query.ToList();
            return countries;
        }
        private static List<CountriesProxy> GetCountries()
        {
            using (IDbConnection connection = new SqlConnection(Settings.Default.DbConnect))
            {
                IDbCommand command = new SqlCommand("SELECT * FROM countries");
                command.Connection = connection;

                connection.Open();

                IDataReader reader = command.ExecuteReader();

                List<CountriesProxy> countries = new List<CountriesProxy>();

                while (reader.Read())
                {
                    CountriesProxy country = new CountriesProxy();

                    country.Id = reader.GetInt32(0);
                    country.Name = reader.GetString(1);
                    countries.Add(country);
                }
                return countries;
            }
        }
    }
}
