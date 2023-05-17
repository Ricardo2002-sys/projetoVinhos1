﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.UI;

namespace projetoVinhos1
{

    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            ScriptManager.ScriptResourceMapping.AddDefinition("jquery",
                            new ScriptResourceDefinition
                            {
                                Path = "~/scripts/jquery-3.6.3.min.js",
                                DebugPath = "~/scripts/jquery-3.6.3.js",
                                CdnPath = "http://ajax.microsoft.com/ajax/jQuery/jquery-3.6.3.min.js",
                                CdnDebugPath = "http://ajax.microsoft.com/ajax/jQuery/jquery-3.6.3.js"
                            });
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}

