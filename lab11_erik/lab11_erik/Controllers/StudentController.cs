using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace lab11_erik.Controllers
{   
    public class StudentController
    {   
        [Route("Student/Print")]
        public string Print()
        {
            return "Printing all students...";
        }
        [Route("Student/Find")]
        public string Find(string name, int age)
        {
            return $"looking for: {name} age:{age}";
        }
    }
}
