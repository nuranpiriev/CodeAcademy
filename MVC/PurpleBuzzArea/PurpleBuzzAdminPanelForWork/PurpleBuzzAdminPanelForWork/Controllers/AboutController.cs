﻿using Microsoft.AspNetCore.Mvc;

namespace PurpleBuzzAdminPanelForWork.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
