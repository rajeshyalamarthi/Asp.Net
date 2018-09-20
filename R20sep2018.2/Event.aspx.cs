using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace R20sep2018._2
{
    public partial class Event : System.Web.UI.Page
    {
        protected void Page_PreInit(object sender, EventArgs e)
        {
            Label1.Text = Label1.Text + "<br/>" + "PreInit";
        }
        protected void Page_Init(object sender, EventArgs e)
        {
            Label1.Text = Label1.Text + "<br/>" + "Init";
        }
        protected void Page_InitComplete(object sender, EventArgs e)
        {
            Label1.Text = Label1.Text + "<br/>" + "InitComplete";
        }
        protected void Page_OnPreLoad(object sender, EventArgs e)
        {
            Label1.Text=Label1.Text+"<br/>" + "OnPreLoad";
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Label1.Text + "<br/>" + "Load";
        }
        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            Label1.Text = Label1.Text + "<br/>" + "LoadComplete";
        }
        protected override void OnPreRender(EventArgs e)
        {
             
            Label1.Text = Label1.Text + "<br/>" + "ONPreRender";
        }
        protected override void OnSaveStateComplete(EventArgs e)
        {
           
            Label1.Text = Label1.Text + "<br/>" + "SaveStateComplete";
        }
        protected void Page_UnLoad(object sender, EventArgs e)
        {

            Label1.Text = Label1.Text + "<br/>" + "UnLoad";
        }

        


        protected void Button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(TextBox1.Text);
            int b = Convert.ToInt32(TextBox2.Text);

            int c = a + b;
            TextBox3.Text =Convert.ToString(c);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Label2.Text = "Welcome to the Practice session";
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string str = TextBox4.Text;
            Label3.Text = str;
        }

      
    }
}