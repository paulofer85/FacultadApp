using FacultadAppSvc.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using FacultadAppSvc.Tests;

namespace FacultadAppSvc.ContextTest
{
    public static class DbContextMocker
    {
        public static FacultadAppContext GetAlumnosDbContext(string dbName)
        {
            // Create options for DbContext instance
            var options = new DbContextOptionsBuilder<FacultadAppContext>()
                .UseInMemoryDatabase(databaseName: dbName)
                .Options;

            // Create instance of DbContext
            var dbContext = new FacultadAppContext(options);

            // Add entities in memory
            DbContextExtensions.Seed(dbContext);

            return dbContext;
        }
    }
}
