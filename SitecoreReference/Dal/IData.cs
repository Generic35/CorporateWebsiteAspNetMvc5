using System.Linq;
using SitecoreReference.Models;

namespace SitecoreReference.Dal
{
    public interface IData
    {
        IQueryable<ClientComment> ClientComments();
        IQueryable<Location> Locations();
        IQueryable<RecentWork> RecentWorks();
        IQueryable<Service> Services();
        IQueryable<TeamMemberProfile> TeamMemberProfiles();
    }
}