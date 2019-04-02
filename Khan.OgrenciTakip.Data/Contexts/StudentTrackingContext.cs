using Khan.OgrenciTakip.Data.StudentTrackingMigration;
using Khan.OgrenciTakip.Model.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Khan.OgrenciTakip.Data.Contexts
{
    public class StudentTrackingContext : BaseDbContext<StudentTrackingContext, Configuration>
    {
        public StudentTrackingContext()
        {
            Configuration.LazyLoadingEnabled = false; //sorgu �al��t�rd���m�zda sadece ilgili kolonu getirsin, di�erlerini getirmesin. Performans i�in.
        }

        public StudentTrackingContext(string connectionString) : base(connectionString)
        {
            Configuration.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>(); //Table' �n ismini ne vermi�sek database e o gitsin.(s eklemesin ismin sonuna.)
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>(); //Bir tablodan bir veriyi sildi�imiz zaman, ili�kili oldu�u tablodan da verileri silme.
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>(); //�sttekinin ayn�s�.
        }

        public DbSet<City> City { get; set; }
        public DbSet<County> County { get; set; }
        public DbSet<School> School { get; set; }
    }
}