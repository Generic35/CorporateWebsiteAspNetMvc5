﻿using SitecoreReference.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreReference.ViewModels
{
    public class ContactVm
    {
        public IEnumerable<Location> Locations { get; set; }
    }
}