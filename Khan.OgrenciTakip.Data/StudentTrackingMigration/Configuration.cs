using Khan.OgrenciTakip.Data.Contexts;
using System.Data.Entity.Migrations;

namespace Khan.OgrenciTakip.Data.StudentTrackingMigration
{
    public class Configuration : DbMigrationsConfiguration<StudentTrackingContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true; //Migration işlemlerini otomatik yap.
            AutomaticMigrationDataLossAllowed = true; //Migration işleminde veri kaybı olmasına izin veriyoruz.
        }
    }
}
