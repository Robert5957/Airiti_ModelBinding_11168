﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModelBinding_11126.Models
{
    public class Person : Human
    {
        public List<Person> Friends { get; set; }
    }
}