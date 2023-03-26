using System;
using System.Data.Entity;
using System.Linq;

namespace Entity_Framework_Core_Part_4.DataModel
{
    public class CountrisContext : DbContext
    {
        // Your context has been configured to use a 'CountrisContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Entity_Framework_Core_Part_4.DataModel.CountrisContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'CountrisContext' 
        // connection string in the application configuration file.
        public CountrisContext()
            : base("name=CountrisContext")
        {
        }
        public DbSet<Countris> Countris { get; set; }


        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}