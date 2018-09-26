using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace A24sep2018Ado.net
{
    public partial class OrderManagement : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!(Context.User.IsInRole("Orders")))
            {
                Response.Redirect("Default.aspx");
            }
        }
    }
}