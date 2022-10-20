using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModelBinding_11126.Models
{
    public class Travelinfo
    {
        public string contentType { get; set; }

        public bool isImage { get; set; }
        public string ID { get; set; }
        public bool Success { get; set; }

        public XMLH data { get; set; }
    }

    public class XMLH
    {
        public INFOS XML_Head { get; set; }

    }


    public class INFOS
    {
        public string ListName { get; set; }
        public string Language { get; set; }
        public string Orgname { get; set; }
        public string UpdateTime { get; set; }
        public INFO Infos { get; set; }
    }

    public class INFO
    {
        public List<Infos> Info { get; set; }
    }
}