using Entity_Framework_Core_Part_4.DataModel;
using Entity_Framework_Core_Part_4.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework_Core_Part_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //using (CountrisContext context = new CountrisContext())
            //{
            //    Countris countris = new Countris();
            //    countris.Name = "Бразилия";
            //    countris.Population = "54365647";
            //    countris.Type = "Европа";

            //    context.Countris.Add(countris);
            //    context.SaveChanges();
            //}

            //using (IDbConnection connection = new SqlConnection(Settings.Default.DbConnect))
            //{
            //    IDbCommand command = new SqlCommand("SELECT * FROM countris");
            //    command.Connection = connection;

            //    connection.Open();

            //    IDataReader reader = command.ExecuteReader();

            //    while (reader.Read())
            //    {
            //        Console.WriteLine("Идентификатор: {0}\tName:{1}", reader.GetInt32(0), reader.GetString(1));
            //    }
            //}
            //Console.ReadLine();

             var countries = GetCountris();
            foreach (var countris in countries)
            {
                Console.WriteLine("Индификатор: {0}\tname:{1}", countris.Id, countris.Name);
            }
            Console.ReadLine();
        }


        
        private static List<CountrisProxy> GetCountris()
        {
            using (IDbConnection connection = new SqlConnection(Settings.Default.DbConnect))
            {
                IDbCommand command = new SqlCommand("SELECT * FROM countris");
                command.Connection = connection;

                connection.Open();

                IDataReader reader = command.ExecuteReader();

                List<CountrisProxy> countris = new List<CountrisProxy>();

                while (reader.Read())
                {
                    CountrisProxy countrist = new CountrisProxy();

                    countrist.Id = reader.GetInt32(0);
                    countrist.Name = reader.GetString(1);

                   countris.Add(countrist);
                }
                return countris;
            }
        }
    }
    
}
