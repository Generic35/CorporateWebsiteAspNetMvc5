using SitecoreReference.Services;
using SitecoreReference.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SitecoreReference.Controllers
{
    public class HomeController : Controller
    {
        private IServicesService _servicesService;
        private IRecentWorkService _recentWorkService;

        public HomeController(IServicesService servicesService, IRecentWorkService recentWorkService)
        {
            _servicesService = servicesService;
            _recentWorkService = recentWorkService;
        }
        // GET: Corlate
        public ActionResult Index()
        {
            var vm = new HomeVm()
            {
                OurServices = _servicesService.GetAll(),
                RecentWork = _recentWorkService.GetAll()
            };

            return View(vm);
        }
    }
}