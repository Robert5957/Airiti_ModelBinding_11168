using ModelBinding_11168.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Web.Http;

namespace ModelBindingAPI_MVC.Controllers
{
    public class SimpleBindingController : ApiController
    {

        public object Post([FromBody] Human data)
        {
           if (data != null) { return Json(data); } else { return Json("Null"); }
        }
    }
}