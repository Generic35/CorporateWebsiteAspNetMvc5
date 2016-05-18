using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SitecoreReference.Models;
using SitecoreReference.Dal;

namespace SitecoreReference.Services
{
    public class LocationService : ILocationService
    {
        IRepository _repo;
        public LocationService(IRepository repo)
        {
            _repo = repo;
        }

        public IEnumerable<Location> GetAll()
        {
            return _repo.GetAllLocations();
        }
    }
}