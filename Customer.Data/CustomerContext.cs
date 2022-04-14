using Customer.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.Data
{
    public class CustomerContext : DbContext
    {
        public DbSet<MSAccountManager> MSAccountManagers { get; set; }

        public CustomerContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Data Source=NBPSS068\\SQLSVRDEV89;Database=CustomerModel;User Id=sa;Password=intikom123;Trusted_Connection=True;MultipleActiveResultSets=true");
            optionsBuilder.UseNpgsql("Host=localhost;Database=CustomerModel;Username=postgres;Password=123456");
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<MSNegara>()
        //        .HasIndex(sl => sl.slik_code)
        //        .IsUnique();

        //    modelBuilder.Entity<MSProvinsi>()
        //        .HasIndex(sl => sl.slik_code)
        //        .IsUnique();

        //    modelBuilder.Entity<MSKota>()
        //        .HasIndex(sl => sl.slik_code)
        //        .IsUnique();

        //    modelBuilder.Entity<MSKecamatan>()
        //        .HasIndex(sl => sl.slik_code)
        //        .IsUnique();

        //    modelBuilder.Entity<MSKelurahan>()
        //        .HasIndex(sl => sl.slik_code)
        //        .IsUnique();

        //    modelBuilder.Entity<MSAddressType>()
        //        .HasIndex(sl => sl.code)
        //        .IsUnique();

        //    modelBuilder.Entity<MSOrgDirectorate>()
        //        .HasIndex(sl => sl.code)
        //        .IsUnique();

        //    modelBuilder.Entity<MSOrgDivision>()
        //        .HasIndex(sl => sl.code)
        //        .IsUnique();
        //}
    }
}
