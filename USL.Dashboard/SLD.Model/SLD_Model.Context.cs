﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SLD.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SLD_DatabaseEntities : DbContext
    {
        public SLD_DatabaseEntities()
            : base("name=SLD_DatabaseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Gesture> Gestures { get; set; }
        public virtual DbSet<GestureMapper> GestureMappers { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<Permission> Permissions { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserType> UserTypes { get; set; }
        public virtual DbSet<VoiceType> VoiceTypes { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
    }
}