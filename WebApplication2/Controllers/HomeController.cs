using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "hello from webgentlr";
        }

        public string Name()
        {
            return "my name is umar";
        }
    }
}