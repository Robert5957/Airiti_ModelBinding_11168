using ModelBinding_11168.Models;
using ModelBindingAPI_MVC._2.BusinessLayer;
using ModelBindingAPI_MVC._4.ModelLayer;
using ModelBindingAPI_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using System.Web;

namespace ModelBindingAPI_MVC.Controllers
{
    public class ValuesController : ApiController
    {
        public IHumanService HumanService { get; set; }
        public ValuesController() : this(new HumanService()) { }
        public ValuesController(IHumanService humanService) {
            this.HumanService = humanService;
        }
        // GET api/values
        public IEnumerable<HumanModel> Get()
        {
            var data = this.HumanService.GetHumans().ToList();
            return data;
        }
        public IHttpActionResult Get(int id)
        {
            var data = this.HumanService.GetHumans().ToList();
            var product = data.FirstOrDefault((p) => p.id == id);
            if (product != null)
            {
                return Ok(product);
            }
            else
            {
                return NotFound();
            }
        }
        private IEnumerable<HumanAPI> NotFound(IEnumerable<HumanAPI> product)
        {
            throw new NotImplementedException();
        }
        // POST api/values
        public void Post([FromBody] string value)
        {
        }
        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }
        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
