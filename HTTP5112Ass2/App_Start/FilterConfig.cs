﻿using System.Web;
using System.Web.Mvc;

namespace HTTP5112Ass2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
