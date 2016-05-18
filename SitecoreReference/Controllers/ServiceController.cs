using SitecoreReference.Services;
using SitecoreReference.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SitecoreReference.Controllers
{
    public class ServiceController : Controller
    {
        IClientCommentService _clientCommentService;
        IServicesService _servicesService;

        public ServiceController(IClientCommentService clientCommentService, IServicesService servicesService)
        {
            _clientCommentService = clientCommentService;
            _servicesService = servicesService;
        }

        // GET: Services
        public ActionResult Index()
        {
            var vm = new ServicesVm
            {
                ClientComments = _clientCommentService.GetAll(),
                OurServices = _servicesService.GetAll()
            };

            return View(vm);
        }
    }
}