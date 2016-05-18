using SitecoreReference.Services;
using SitecoreReference.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SitecoreReference.Controllers
{
    public class ContactController : Controller
    {
        ILocationService _locationService;

        public ContactController(ILocationService locationService)
        {
            _locationService = locationService;
        }
        // GET: Contact
        public ActionResult Index()
        {
            var vm = new ContactVm()
            {
                Locations = _locationService.GetAll()
            };

            return View(vm);
        }
    }
}