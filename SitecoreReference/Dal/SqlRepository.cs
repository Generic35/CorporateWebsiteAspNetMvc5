using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using SitecoreReference.Models;

namespace SitecoreReference.Dal
{
    public class SqlRepository : DbContext, IRepository
    {
        public SqlRepository() : base("DefaultConnection") { }
        public DbSet<ClientComment> ClientComments { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<RecentWork> RecentWorks { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<TeamMemberProfile> TeamMemberProfiles { get; set; }
        public DbSet<Skill> Skills { get; set; }

        public IQueryable<ClientComment> GetAllClientComments()
        {
            return ClientComments;
        }

        public IQueryable<Location> GetAllLocations()
        {
            return Locations;
        }

        public IQueryable<RecentWork> GetAllRecentWork()
        {
            return RecentWorks;
        }

        public IQueryable<Service> GetAllServices()
        {
           return Services;
        }

        public IQueryable<TeamMemberProfile> GetAllTeamMemberProfiles()
        {
            return TeamMemberProfiles.Include(t => t.Skills);
        }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TeamMemberProfile>().HasMany(x => x.Skills).WithMany();
        }
    }
}