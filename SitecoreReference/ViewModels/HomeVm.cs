using SitecoreReference.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreReference.ViewModels
{
    public class HomeVm
    {
        public IEnumerable<Service> OurServices { get; set; }
        public IEnumerable<RecentWork> RecentWork { get; set; }
    }
}