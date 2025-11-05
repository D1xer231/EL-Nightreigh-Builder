using EL_Nightreigh_Builder.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System.IO;

namespace EL_Nightreigh_Builder
{
    public class AppDbContext : DbContext
    {
        public DbSet<Weapon> Weapons { get; set; }

        public AppDbContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var connectionString = "server=mydb-sasha-aalexandr397-031a.h.aivencloud.com;port=13668;username=avnadmin;password=AVNS_jK5JtBXiH0SCCz70Ap3;database=defaultdb";

            options.UseMySql(
                connectionString,
                ServerVersion.AutoDetect(connectionString)
            );
        }
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {
        }
    }
}
