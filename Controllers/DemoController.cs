using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Demo.Controllers
{
    public class DemoController : ApiController
    {
        private static List<string> studentnames = new List<string> { "Yannis", "Yogesh", "Andhin" };


        [HttpGet]
        public IEnumerable<string> GetNames()

        {
            return studentnames;
        }

        [HttpGet]
        public string GetNameByIndex(int id)
        {
            return studentnames[2];

        }
    }
}
