using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace lab11_erik.Controllers
{
    public class HomeController
    {
        public string Index()
        {
            return "Welcome to the home page...";
        }
        [Route("Register")]
        public string Register()
        {
            return "you can register here..";
        }
    }
}
