﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EstimateCreator.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class EstimatorDbContext : DbContext
    {
        public EstimatorDbContext()
            : base("name=EstimatorDbContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BrandMaster> BrandMasters { get; set; }
        public virtual DbSet<CaptionMaster> CaptionMasters { get; set; }
        public virtual DbSet<ClientMaster> ClientMasters { get; set; }
        public virtual DbSet<EstimateEdition> EstimateEditions { get; set; }
        public virtual DbSet<EstimateHeader> EstimateHeaders { get; set; }
        public virtual DbSet<EstimatePublication> EstimatePublications { get; set; }
        public virtual DbSet<UserDetail> UserDetails { get; set; }
    
        public virtual ObjectResult<sp_ValidateUser_Result> sp_ValidateUser(string userName, string password)
        {
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_ValidateUser_Result>("sp_ValidateUser", userNameParameter, passwordParameter);
        }
    }
}
