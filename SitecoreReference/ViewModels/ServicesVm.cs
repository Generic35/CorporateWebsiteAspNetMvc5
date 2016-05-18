using SitecoreReference.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreReference.ViewModels
{
    public class ServicesVm
    {
        public IEnumerable<ClientComment> ClientComments { get; set; }
        public IEnumerable<Service> OurServices { get; set; }
    }
}