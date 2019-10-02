using aspnetcore_template.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    public class InMemoryDbContextFactory
    {
        public CoreDbContext GetCoreDbContext()
        {
            var options = new DbContextOptionsBuilder<CoreDbContext>()
                            .UseInMemoryDatabase(databaseName: "InMemoryRestaurantDatabase")
                            .Options;
            var dbContext = new CoreDbContext(options);

            return dbContext;
        }
    }
}
