
using Module_6__Introduction_to_Entity_Framework_Core_Part_3;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

public partial class TestDbContext : DbContext
    {
    public TestDbContext() : base("name=TestDbContext")
    {

    }
    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
       throw new UnintentionalCodeFirstException();
    }
    public DbSet<countries> countries { get; set; }
    public DbSet<capitals> name { get; set; }
    public DbSet<capitals> area { get; set; }

}

