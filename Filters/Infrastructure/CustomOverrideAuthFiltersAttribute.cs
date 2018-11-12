﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Filters;

namespace Filters.Infrastructure
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method,
        Inherited = true, AllowMultiple = false)]
    public class CustomOverrideAuthFiltersAttribute : FilterAttribute, IOverrideFilter
    {
        public Type FiltersToOverride
        {
            get { return typeof(IAuthorizationFilter); }
        }
    }
}