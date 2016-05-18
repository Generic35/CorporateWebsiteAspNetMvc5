using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace SitecoreReference.Models
{
    public class Skill
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual ICollection<TeamMemberProfile> TeamMemberProfiles {  get; set; }
    }
}