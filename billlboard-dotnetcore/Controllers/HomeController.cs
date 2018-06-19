﻿using Billboard.Config;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Billboard.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOptionsSnapshot<BillboardConfig> _config;


        public HomeController(IOptionsSnapshot<BillboardConfig> config)
        {
            _config = config;
        }

        [Route("/")]
        public string Greet() => _config.Value.Message;
        
    }
}
