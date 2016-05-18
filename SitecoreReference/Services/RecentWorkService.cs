using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SitecoreReference.Models;
using SitecoreReference.Dal;

namespace SitecoreReference.Services
{
    public class RecentWorkService : IRecentWorkService
    {
        IRepository _repo;
        public RecentWorkService(IRepository repo)
        {
            _repo = repo;
        }

        public IEnumerable<RecentWork> GetAll()
        {
            return _repo.GetAllRecentWork();
        }
    }
}