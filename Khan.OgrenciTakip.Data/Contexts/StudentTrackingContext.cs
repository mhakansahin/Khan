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
            Configuration.LazyLoadingEnabled = false; //sorgu çalýþtýrdýðýmýzda sadece ilgili kolonu getirsin, diðerlerini getirmesin. Performans için.
        }

        public StudentTrackingContext(string connectionString) : base(connectionString)
        {
            Configuration.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>(); //Table' ýn ismini ne vermiþsek database e o gitsin.(s eklemesin ismin sonuna.)
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>(); //Bir tablodan bir veriyi sildiðimiz zaman, iliþkili olduðu tablodan da verileri silme.
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>(); //Üsttekinin aynýsý.
        }

        public DbSet<City> City { get; set; }
        public DbSet<County> County { get; set; }
        public DbSet<School> School { get; set; }
    }
}