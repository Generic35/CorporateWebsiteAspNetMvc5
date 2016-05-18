using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SitecoreReference.Models;
using System.IO;
using Newtonsoft.Json;

namespace SitecoreReference.Dal
{
    public class DummyRepository : IRepository
    {
        IData _data;

        public DummyRepository(IData data)
        {
            _data = data;
        }
        
        public IQueryable<ClientComment> GetAllClientComments()
        {
            return _data.ClientComments();
        }

        public IQueryable<Location> GetAllLocations()
        {
            return _data.Locations();
        }

        public IQueryable<RecentWork> GetAllRecentWork()
        {
            return _data.RecentWorks();
        }

        public IQueryable<Service> GetAllServices()
        {
            return _data.Services();
        }

        public IQueryable<TeamMemberProfile> GetAllTeamMemberProfiles()
        {
            return _data.TeamMemberProfiles();
        }
    }
}