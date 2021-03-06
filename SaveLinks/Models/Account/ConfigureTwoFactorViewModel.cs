﻿using System.Collections.Generic;
using System.Web.Mvc;

namespace SaveLinks.Models.Account
{
    public class ConfigureTwoFactorViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<SelectListItem> Providers { get; set; }
    }
}