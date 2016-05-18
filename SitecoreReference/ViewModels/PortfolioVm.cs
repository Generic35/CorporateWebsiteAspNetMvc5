using SitecoreReference.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreReference.ViewModels
{
    public class PortfolioVm
    {
        public IEnumerable<RecentWork> OurRecentWork{ get; set; }
    }
}