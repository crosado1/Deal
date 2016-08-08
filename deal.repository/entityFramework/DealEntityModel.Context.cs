﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace deal.repository.entityFramework
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DealOptionEntities : DbContext
    {
        public DealOptionEntities()
            : base("name=DealOptionEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Company> Companies { get; set; }
        public DbSet<CompanyService> CompanyServices { get; set; }
        public DbSet<CompanySubsidiary> CompanySubsidiaries { get; set; }
        public DbSet<CompanyUser> CompanyUsers { get; set; }
        public DbSet<DealResponse> DealResponses { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<ServiceRequest> ServiceRequests { get; set; }
        public DbSet<ServiceRequestStatusType> ServiceRequestStatusTypes { get; set; }
        public DbSet<ServiceType> ServiceTypes { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<StateCity> StateCities { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<UserStateLocation> UserStateLocations { get; set; }
    }
}