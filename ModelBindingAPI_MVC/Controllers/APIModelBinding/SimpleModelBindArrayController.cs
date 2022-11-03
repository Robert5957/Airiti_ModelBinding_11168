using ModelBinding_11168.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ModelBindingAPI_MVC.Controllers
{
    public class SimpleModelBindArrayController : ApiController
    {
        // POST api/values
        public object Post([FromBody] string[] Name, int[] Age)
        {
            return Json(Name);
        }
    }
}
