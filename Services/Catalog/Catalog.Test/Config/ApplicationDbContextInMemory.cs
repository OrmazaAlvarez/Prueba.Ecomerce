using Catalog.Persistence.DataBase;
using Microsoft.EntityFrameworkCore;

namespace Catalog.Test.Config
{
    public static class ApplicationDbContextInMemory
    {
        public static ApplicationDbContext Get()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                                    .UseInMemoryDatabase(databaseName: $"Catalog.Api")
                                    .Options;
            return new ApplicationDbContext(options);
        }
    }
}
