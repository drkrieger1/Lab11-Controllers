using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace lab11_erik.Controllers
{
    public class ErrorController
    {   
        [Route("Error")]
        public string Error()
        {
            return "Error! something is broken";
        }
    }
}
