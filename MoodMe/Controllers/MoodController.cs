﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MoodMe.Controllers
{
    public class MoodController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}