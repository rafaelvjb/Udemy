using Microsoft.EntityFrameworkCore;
using vega.Controllers;
using vega.Models;

namespace vega.Persistence
{
    public class VegaDbContext: DbContext
    {
            //System.Configuration.ConfigurationManager
        public DbSet<Model> Models {get;set;}
        public DbSet<Make> Makes{get;set;}
        public DbSet<Feature> Features { get; set; }
        

        //public VegaDbContext(string connectionString) : base(connectionString)
        public VegaDbContext(DbContextOptions<VegaDbContext> options) : base(options)
        {
        }
    }
}