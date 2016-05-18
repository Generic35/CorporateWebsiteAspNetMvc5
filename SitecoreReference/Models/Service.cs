using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreReference.Models
{
    public class Service
    {

        public virtual int Id { get; set; }

        public virtual string Title { get; set; }

        public virtual string Icon { get; set; }

        public virtual string Description { get; set; }
    }
}