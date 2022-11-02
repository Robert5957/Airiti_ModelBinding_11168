using ModelBindingAPI_MVC._4.ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModelBindingAPI_MVC._3.DataAccessLayer
{
    public class HumanRespository : IHumanRespository
    {
        public IEnumerable<HumanModel> GetHuman()
        {
            for (int i = 0; i < 20; i++){
                yield return new HumanModel()
                {
                    id = i,
                    Name = string.Format("Name_{0}", i),
                    Age = 20 + i
                };
            }
        }
    }
}