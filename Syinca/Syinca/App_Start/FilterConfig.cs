﻿using System.Web;
using System.Web.Mvc;
using System.Web.WebPages;

namespace Syinca
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
