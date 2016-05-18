using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreReference.Models
{
    public class TeamMemberProfile
    {

        public virtual int Id { get; set; }

        public virtual string Name { get; set; }

        public virtual string Role { get; set; }

        public virtual string ImageUrl { get; set; }

        //public virtual string Skills { get; set; }

        public virtual string Description { get; set; }

        public virtual string FacebookProfileUrl { get; set; }

        public virtual string TwitterProfileUrl { get; set; }

        public virtual string GooglePlusProfileUrl { get; set; }

        public ICollection<Skill> Skills { get; set; }
    }
}