﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Wcf.Hr.Service
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<DEPARTMENT> DEPARTMENTS { get; set; }
        public DbSet<EMPLOYEE> EMPLOYEES { get; set; }
        public DbSet<JOB_HISTORY> JOB_HISTORY { get; set; }
        public DbSet<JOB> JOBS { get; set; }
        public DbSet<LOCATION> LOCATIONS { get; set; }
        public DbSet<REGION> REGIONS { get; set; }
        public DbSet<SALARY_HISTORY> SALARY_HISTORY { get; set; }
    }
}