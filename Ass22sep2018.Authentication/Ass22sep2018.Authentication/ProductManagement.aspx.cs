﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ass22sep2018.Authentication
{
    public partial class ProductManagement : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Context.User.IsInRole("Product"))
            {
                
                Response.Redirect("Default.aspx");
            }
        }
    }
}