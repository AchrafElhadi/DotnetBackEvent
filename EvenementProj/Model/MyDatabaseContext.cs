using Microsoft.EntityFrameworkCore;
using VoitureApi.Model;

namespace VoitureAPi2.Model
{
    public class MyDatabaseContext:DbContext
    {
        public MyDatabaseContext(DbContextOptions<MyDatabaseContext> options):base(options)
        {

        }
        public DbSet<Categorie> categories { get; set; }
        public DbSet<Events> evenements { get; set; }

    }
}
