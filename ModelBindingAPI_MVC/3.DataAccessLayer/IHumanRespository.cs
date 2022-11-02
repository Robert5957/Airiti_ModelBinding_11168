using ModelBindingAPI_MVC._4.ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelBindingAPI_MVC._3.DataAccessLayer
{
      public  interface IHumanRespository
    {
        IEnumerable<HumanModel> GetHuman();
    }
}
