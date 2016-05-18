using SitecoreReference.Services;
using SitecoreReference.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SitecoreReference.Controllers
{
    public class AboutController : Controller
    {
        ITeamMemberProfileService _teamMemberProfileService;

        public AboutController(ITeamMemberProfileService  teamMemberProfileService)
        {
            _teamMemberProfileService = teamMemberProfileService;
        }

        // GET: About
        public ActionResult Index()
        {
            var vm = new AboutVm()
            {
                TeamMemberProfiles = _teamMemberProfileService.GetAll()
            };

            return View(vm);
        }
    }
}