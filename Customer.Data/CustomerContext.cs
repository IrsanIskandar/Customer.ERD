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
        public DbSet<MelampauiBmpk> MelampauiBmpks { get; set; }
        public DbSet<MelanggarBmpk> MelanggarBmpks { get; set; }
        public DbSet<GolonganPihakKetiga> GolonganPihakKetigas { get; set; }
        public DbSet<GoPublicMap> GoPublicMaps { get; set; }
        public DbSet<GroupUsahaDebitur> GroupUsahaDebiturs { get; set; }
        public DbSet<HubunganPelapor> HubunganPelapors { get; set; }
        public DbSet<MSAccountManager> MSAccountManagers { get; set; }
        public DbSet<MSAddressType> MSAddressTypes { get; set; }
        public DbSet<MSBentukBadanUsaha> MSBentukBadanUsahas { get; set; }
        public DbSet<MSCustomerRelationship> MSCustomerRelationships { get; set; }
        public DbSet<MSCustomerStatus> MSCustomerStatuses { get; set; }
        public DbSet<MSExternalRating> MSExternalRatings { get; set; }
        public DbSet<MSExternalRatingAgency> MSExternalRatingAgencies { get; set; }
        public DbSet<MSNegara> MSNegaras { get; set; }
        public DbSet<MSProvinsi> MSProvinsis { get; set; }
        public DbSet<MSKota> MSKotas { get; set; }
        public DbSet<MSKecamatan> MSKecamatans { get; set; }
        public DbSet<MSKelurahan> MSKelurahans { get; set; }
        public DbSet<MSKodepos> MSKodepos { get; set; }
        public DbSet<MSOrgDirectorate> MSOrgDirectorates { get; set; }
        public DbSet<MSOrgDivision> MSOrgDivisions { get; set; }
        public DbSet<MSRatingModel> MSRatingModels { get; set; }
        public DbSet<MSRiskRatingModel> MSRiskRatingModels { get; set; }
        public DbSet<MSSector> MSSectors { get; set; }
        public DbSet<MSSoeStatus> MSSoeStatuses { get; set; }
        public DbSet<MSSubsector> MSSubsectors { get; set; }
        public DbSet<SectorSubsector> SectorSubsectors { get; set; }
        public DbSet<CustomerLog> SektorEkonomis { get; set; }
        public DbSet<CustomerStatuses> CustomerStatuses { get; set; }
        public DbSet<CustomerRatings> CustomerRatings { get; set; }
        public DbSet<CustomerGroup> CustomerGroups { get; set; }
        public DbSet<CustomerAccountManager> CustomerAccountManagers { get; set; }
        public DbSet<CustomerContactPerson> CustomerContactPerson { get; set; }
        public DbSet<CustomerAddress> CustomerAddresses { get; set; }
        public DbSet<Customer.Domain.Models.Customer> Customers { get; set; }

        public CustomerContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Data Source=NBPSS068\\SQLSVRDEV89;Database=CustomerModel;User Id=sa;Password=intikom123;Trusted_Connection=True;MultipleActiveResultSets=true");
            //optionsBuilder.UseNpgsql("Host=localhost;Database=CustomerModel;Username=postgres;Password=irs123*");
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
