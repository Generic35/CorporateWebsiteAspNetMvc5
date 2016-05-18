using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SitecoreReference.Models;
using SitecoreReference.Dal;

namespace SitecoreReference.Services
{
    public class ServicesService : IServicesService
    {
        IRepository _repo;
        public ServicesService(IRepository repo)
        {
            _repo = repo;
        }

        public IEnumerable<Service> GetAll()
        {
            return _repo.GetAllServices();
        }
    }
}