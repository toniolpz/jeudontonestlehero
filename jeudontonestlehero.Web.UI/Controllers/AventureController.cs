﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jeudontonestlehero.Web.UI.Controllers
{
    public class AventureController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
