﻿using Microsoft.AspNetCore.Mvc;

namespace PurpleBuzzProject.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
