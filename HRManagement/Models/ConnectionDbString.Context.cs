﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HRManagement.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HRManagementDBEntities : DbContext
    {
        public HRManagementDBEntities()
            : base("name=HRManagementDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Insurance> Insurance { get; set; }
        public virtual DbSet<Payment> Payment { get; set; }
        public virtual DbSet<PerformanceReview> PerformanceReview { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<Resumes> Resumes { get; set; }
        public virtual DbSet<Training> Training { get; set; }
    }
}
