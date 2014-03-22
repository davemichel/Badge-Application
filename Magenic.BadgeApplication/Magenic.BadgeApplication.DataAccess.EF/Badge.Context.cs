﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Magenic.BadgeApplication.DataAccess.EF
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
    
        public virtual DbSet<Activity> Activities { get; set; }
        public virtual DbSet<BadgeActivity> BadgeActivities { get; set; }
        public virtual DbSet<BadgeType> BadgeTypes { get; set; }
        public virtual DbSet<EmployeePermission> EmployeePermissions { get; set; }
        public virtual DbSet<Permission> Permissions { get; set; }
        public virtual DbSet<BadgePrerequisite> BadgePrerequisites { get; set; }
        public virtual DbSet<ActivitySubmission> ActivitySubmissions { get; set; }
        public virtual DbSet<BadgeAward> BadgeAwards { get; set; }
        public virtual DbSet<CurrentActiveBadge> CurrentActiveBadges { get; set; }
        public virtual DbSet<EarnedBadge> EarnedBadges { get; set; }
        public virtual DbSet<QueueEvent> QueueEvents { get; set; }
        public virtual DbSet<QueueItem> QueueItems { get; set; }
        public virtual DbSet<ItemStatu> ItemStatus { get; set; }
        public virtual DbSet<QueueEventLog> QueueEventLogs { get; set; }
        public virtual DbSet<Badge> Badges { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<ActivityEntryType> ActivityEntryTypes { get; set; }
    }
}
