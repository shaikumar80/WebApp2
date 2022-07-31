using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class EmployeeController : Controller
    {
        public string EmployeeProfile(int id)
        {
            string profile = "";
            if(id == 1)
            {
                profile = "employee 1 profile";
            } else if(id == 2)
            {
                profile = "employee 2 profile";
            }
            else
            {
                profile = "no record found";
            }
            return profile;
        }

        public string Address(int id, int?dept=3)
        {
            return "id= " + id + "dept= " + dept;
        }
    }
}