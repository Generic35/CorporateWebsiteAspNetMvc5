using SitecoreReference.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitecoreReference.Dal
{
    public interface IRepository
    {
        IQueryable<ClientComment> GetAllClientComments();
        IQueryable<TeamMemberProfile> GetAllTeamMemberProfiles();
        IQueryable<Service> GetAllServices();
        IQueryable<RecentWork> GetAllRecentWork();
        IQueryable<Location> GetAllLocations();
    }
}
