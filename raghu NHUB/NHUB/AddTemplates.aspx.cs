using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TemplateDAL.Repository;

namespace NHUB
{
    public partial class AddTemplates : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Template.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            TemplateRepository tr = new TemplateRepository();
            tr.Create(Convert.ToInt32(DropDownList1.Text), Convert.ToInt32(DropDownList2.Text), TextBox1.Text, Convert.ToInt32(DropDownList3.Text));

              Response.Redirect("Template.aspx");
              Response.Redirect("ManagerApprovalPage.aspx");
               
            
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TemplateRepository tr = new TemplateRepository();
            tr.getDetails();

        }
    }
}