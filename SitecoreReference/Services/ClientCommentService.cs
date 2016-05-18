using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SitecoreReference.Models;
using SitecoreReference.Dal;

namespace SitecoreReference.Services
{
    public class ClientCommentService : IClientCommentService
    {
        IRepository _repo;
        public ClientCommentService(IRepository repo)
        {
            _repo = repo;
        }

        public IEnumerable<ClientComment> GetAll()
        {
            return _repo.GetAllClientComments();
        }
    }
}