﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Filters;

namespace Filters.Infrastructure
{
    public class GoogleAuthAttribute : FilterAttribute, IAuthenticationFilter
    {
        public void OnAuthentication(AuthenticationContext filterContext)
        {
          
        }

        public void OnAuthenticationChallenge(AuthenticationChallengeContext filterContext)
        {
           
        }
    }
}