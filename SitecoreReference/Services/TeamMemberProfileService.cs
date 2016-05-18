using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SitecoreReference.Models;
using SitecoreReference.Dal;

namespace SitecoreReference.Services
{
    public class TeamMemberProfileService : ITeamMemberProfileService
    {
        IRepository _repo;
        public TeamMemberProfileService(IRepository repo)
        {
            _repo = repo;
        }

        public IEnumerable<TeamMemberProfile> GetAll()
        {
            return _repo.GetAllTeamMemberProfiles();
        }
    }
}