﻿using System.Web;
using System.Web.Mvc;

namespace ModelBinding_11105
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
