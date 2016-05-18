using SitecoreReference.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreReference.ViewModels
{
    public class AboutVm
    {
        public IEnumerable<TeamMemberProfile> TeamMemberProfiles { get; set; }
    }
}