using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace DataAccessLayer
{
public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<AppCorpDbContext>
{
    public AppCorpDbContext CreateDbContext(string[] args)
    {
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        var builder = new DbContextOptionsBuilder<AppCorpDbContext>();

        var connectionString = configuration.GetConnectionString("AppCorpDatabase");

        builder.UseSqlServer(connectionString);

        return new AppCorpDbContext(builder.Options);
    }
}
}
