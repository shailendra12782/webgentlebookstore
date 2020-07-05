using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace webgentlebookstore.Controllers
{
    public class HomeController: Controller
    {
        public string Index()
        {
            return "Hello from Controller";
        
        }
    }
}
