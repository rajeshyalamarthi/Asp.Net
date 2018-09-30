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

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("Template.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            TemplateRepository tr = new TemplateRepository();
            tr.getDetails();
           

            tr.Create(DropDownList1.Text, DropDownList2.Text, TextBox1.Text, CheckBox1.Checked, DropDownList3.Text, 1);

              Response.Redirect("Template.aspx");
              Response.Redirect("ManagerApprovalPage.aspx");
           

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TemplateRepository tr = new TemplateRepository();
           

        }
    }
}