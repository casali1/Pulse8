using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pulse8.Models;

namespace Pulse8.Data
{
    public class PulseContext : DbContext
    {
        public PulseContext(DbContextOptions<PulseContext> options) : base(options)
        {
        }

        public DbSet<Diagnosis> Diagnosises { get; set; }
        public DbSet<DiagnosisCategory> DiagnosisCategories { get; set; }
        public DbSet<DiagnosisCategoryMap> DiagnosisCategoryMaps { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<MemberDiagnosis> MemberDiagnosises { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Diagnosis>().ToTable("Diagnosis");            
            modelBuilder.Entity<DiagnosisCategory>().ToTable("DiagnosisCategory");    
            modelBuilder.Entity<DiagnosisCategoryMap>().ToTable("DiagnosisCategoryMap");
            modelBuilder.Entity<Member>().ToTable("Member");    
            modelBuilder.Entity<MemberDiagnosis>().ToTable("MemberDiagnosis");
        }
    }
}
