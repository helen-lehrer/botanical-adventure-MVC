using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace ForageMvc.Models
{
  public class ForageMvcContextFactory : IDesignTimeDbContextFactory<ForageMvcContext>
  {

    ForageMvcContext IDesignTimeDbContextFactory<ForageMvcContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();

      var builder = new DbContextOptionsBuilder<ForageMvcContext>();

      builder.UseSqlServer();

      return new ForageMvcContext(builder.Options);
    }
  }
}
