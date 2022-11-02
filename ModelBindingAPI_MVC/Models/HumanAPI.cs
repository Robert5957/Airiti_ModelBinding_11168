using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModelBindingAPI_MVC.Models
{
    public class HumanAPI
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public class Person : HumanAPI
    {
        public List<Person> Friends { get; set; }
    }
}