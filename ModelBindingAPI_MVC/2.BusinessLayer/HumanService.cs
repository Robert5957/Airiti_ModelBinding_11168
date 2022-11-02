using ModelBindingAPI_MVC._3.DataAccessLayer;
using ModelBindingAPI_MVC._4.ModelLayer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModelBindingAPI_MVC._2.BusinessLayer
{
    public class HumanService : IHumanService
    {
        public HumanRespository HumanRespository { get; set; }
        public HumanService() : this(new HumanRespository()) { }
        public HumanService(IHumanRespository humanRespository)
        {
            this.HumanRespository = (HumanRespository)humanRespository;
        }

        public IEnumerable<HumanModel> GetHumans()
        {
            return this.HumanRespository.GetHuman();
        }
    }

}