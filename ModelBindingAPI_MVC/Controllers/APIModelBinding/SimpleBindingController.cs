using ModelBinding_11168.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ModelBindingAPI_MVC.Controllers.NewFolder1
{
    public class SimpleBindingController : ApiController
    {
        public object Post([FromBody] Human data)
        {
            if (data != null) { return Json(data); } else { return Json("Null"); }
        }
    }
}
