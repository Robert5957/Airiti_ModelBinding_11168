using ModelBinding_11168.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ModelBindingAPI_MVC.Controllers
{
    public class ModelBindObjController : ApiController
    {
        public object Post([FromBody] Human data)
        {
            if (data.Age != 0 && !string.IsNullOrEmpty(data.Name)) { return Json(data); } else { return Json("Null"); }
        }
    }
}
