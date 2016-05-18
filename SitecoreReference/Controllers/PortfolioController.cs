using SitecoreReference.Services;
using SitecoreReference.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SitecoreReference.Controllers
{
    public class PortfolioController : Controller
    {
        IRecentWorkService _recentWorkService;

        public PortfolioController(IRecentWorkService recentWorkService)
        {
            _recentWorkService = recentWorkService;
        }
        // GET: Portfolio
        public ActionResult Index()
        {
            var vm = new PortfolioVm
            {
                OurRecentWork = _recentWorkService.GetAll()
            };

            return View(vm);
        }
    }
}