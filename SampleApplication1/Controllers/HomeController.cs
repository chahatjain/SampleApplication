using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleApplication1.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public String Index()
        {
            string s1 = "hello World";
            string s2 = "chahat jain";
            return s1 + s2;
        }

    }
}
