﻿using ASPNETWEBCORE.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASPNETWEBCORE.Controllers
{
    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {
            return View();
        }

    }
}