using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using SafariApp.Models;

namespace SafariApp
{
    public partial class Safari_VacationContext : DbContext
    {
        public Safari_VacationContext()
        {
        }

        public Safari_VacationContext(DbContextOptions<Safari_VacationContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("server=localhost;database=Safari_Vacation");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {}

        public DbSet<SeenAnimals> SeenAnimalsTable;

    }
}
