using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace myWebApi461.Controllers
{
    public class DemoController : ApiController
    {
        // GET api/demo
        public IEnumerable<string> Get()
        {
            return new string[] { "Demo1", "value2" };
        }

    }
}
