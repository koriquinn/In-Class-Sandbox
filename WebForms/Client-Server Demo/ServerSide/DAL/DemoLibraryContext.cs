using DataEntities;
using System.Data.Entity;


namespace ServerSide.DAL
{
    internal class DemoLibraryContext: DbContext
    {
        public DemoLibraryContext() : base("DefaultConnection")
        {
        }

        public DbSet<CodeDemo> CodeDemos { get; set; }

    }
}
