using SitecoreReference.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitecoreReference.Services
{
    public interface IRecentWorkService
    {
        IEnumerable<RecentWork> GetAll();
    }
}
