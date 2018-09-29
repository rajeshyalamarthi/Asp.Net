using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TemplateDAL.Repository;
using System.Data;
using System.Data.SqlClient;

namespace NHUB
{
    public partial class Template : System.Web.UI.Page
    {
        //TemplateRepository ts = new TemplateRepository();
        //protected void Page_Load(object sender, EventArgs e)
        //{
        //    if (!this.IsPostBack)
        //    {
              
        //        DataTable dt = ts.GetData("SELECT Id, Name FROM Source");
        //        this.PopulateTreeView(dt, 0, null);
        //    }

        //}

        //private void PopulateTreeView(DataTable dtParent, int parentId, TreeNode treeNode)
        //{
        //    foreach (DataRow row in dtParent.Rows)
        //    {
        //        TreeNode child = new TreeNode
        //        {
        //            Text = row["Name"].ToString(),
        //            Value = row["Id"].ToString()
        //        };
        //        if (parentId == 0)
        //        {
        //            TreeView1.Nodes.Add(child);
        //            DataTable dtChild =ts.GetData("SELECT Id, Name FROM Event WHERE SourceId = " + child.Value);
        //            PopulateTreeView(dtChild, int.Parse(child.Value), child);
        //        }
        //        else
        //        {
        //            treeNode.ChildNodes.Add(child);
        //        }
        //    }
        //}
       



        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddTemplates.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                Table t = new Table();
                t.ID = "1";
                PlaceHolder1.Controls.Add(t);
                TemplateRepository tr = new TemplateRepository();
                tr.getDetails();
            

                for (int count = 0; count < tr.templateProps.Count(); count++)
                {
                    TableRow tableRow = new TableRow();
                    t.Rows.Add(tableRow);
                    TableCell tcell = new TableCell();
                    //PlaceHolder placeHolder = new PlaceHolder();
                    Label lb = new Label();
                   
                    lb.Width = 200;
                    PlaceHolder1.Controls.Add(lb);

                    HyperLink Configure = new HyperLink();
                    HyperLink Delete = new HyperLink();
                    Configure.Text = "Configure";
                    Configure.NavigateUrl = "AddTemplates.aspx";
                    Configure.Width = 200;
                    PlaceHolder1.Controls.Add(Configure);
                    Delete.Text = "Delete";
                    Delete.NavigateUrl = "Delete.aspx";
                    Delete.Width = 200;
                    PlaceHolder1.Controls.Add(Delete);
                    tableRow.Cells.Add(tcell);
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {


        }

        protected void TreeView1_SelectedNodeChanged(object sender, EventArgs e)
        {

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                using (SqlConnection Conn = new SqlConnection())
                {
                    Conn.ConnectionString = "Data Source=ACUPC_120;Initial Catalog=NotificationHub;Integrated Security=True";
                    Conn.Open();

                    string Source = "Select * from Source";
                    string Event = "Select * from Event";
                    string Template = "select * from Template";

                    string Treeview = Source + ";" + Event + ";" + Template;

                    DataSet ds = new DataSet();
                    SqlDataAdapter da = new SqlDataAdapter(Treeview, Conn);
                    da.Fill(ds);
                    ds.Tables[0].TableName = "Source";
                    ds.Tables[1].TableName = "Event";
                    ds.Tables[2].TableName = "Template";

                    DataRelation dr = new DataRelation("SourceEvent", ds.Tables["Source"].Columns["S_Id"], ds.Tables["Event"].Columns["E_Id"], ds.Tables["Template"].Columns["Id"]);
                    ds.Relations.Add(dr);

                    foreach (DataRow drSource in ds.Tables["Source"].Rows)
                    {
                        TreeNode NDSource = new TreeNode();
                        NDSource.Text = drSource["S_Name"].ToString();
                        NDSource.Value = drSource["S_Id"].ToString();
                        TreeView1.Nodes.Add(NDSource);

                        foreach (DataRow drEvent in drSource.GetChildRows("SourceEvent"))
                        {
                            TreeNode NDEvent = new TreeNode();
                            NDEvent.Text = drEvent["E_Name"].ToString();
                            NDEvent.Value = drEvent["E_Id"].ToString();
                            NDSource.ChildNodes.Add(NDEvent);


                        }
                    }


                    DataRelation dr1 = new DataRelation("EventTemplate", ds.Tables["Event"].Columns["Id"], ds.Tables["Template"].Columns["Id"]);
                    ds.Relations.Add(dr1);

                    foreach (DataRow drEvent in ds.Tables["Event"].Rows)
                    {
                        TreeNode NDEvent = new TreeNode();
                        NDEvent.Text = drEvent["Name"].ToString();
                        NDEvent.Value = drEvent["Id"].ToString();
                        TreeView1.Nodes.Add(NDEvent);

                        foreach (DataRow drTemplate in drEvent.GetChildRows("EventTemplate"))
                        {
                            TreeNode NDTemplate = new TreeNode();
                            NDTemplate.Text = drTemplate["Name"].ToString();
                            NDTemplate.Value = drTemplate["Id"].ToString();
                            NDTemplate.ChildNodes.Add(NDEvent);


                        }
                    }



                    //DataRelation dr = new DataRelation("SourceEventTemplate", ds.Tables["Source"].Columns["SourceId"], ds.Tables["Event"].Columns["EventId"], ds.Tables["Template"].Columns["Id"]);
                    //ds.Relations.Add(dr);

                    //foreach (DataRow drSource in ds.Tables["Source"].Rows)
                    //{
                    //    TreeNode NDSource = new TreeNode();
                    //    NDSource.Text = drSource["SourceName"].ToString();
                    //    NDSource.Value = drSource["SourceId"].ToString();
                    //    TreeView1.Nodes.Add(NDSource);

                    //    foreach (DataRow drEvent in drSource.GetChildRows("SourceEvent"))
                    //    {
                    //        TreeNode NDEvent = new TreeNode();
                    //        NDEvent.Text = drEvent["SourceName"].ToString();
                    //        NDEvent.Value = drEvent["EventId"].ToString();
                    //        NDSource.ChildNodes.Add(NDEvent);

                    //        foreach (DataRow drTemplate in drEvent.GetChildRows("SourceEventTemplate"))
                    //        {
                    //            TreeNode NDTemplate = new TreeNode();
                    //            NDTemplate.Text = drTemplate["Name"].ToString();
                    //            NDTemplate.Value = drTemplate["Id"].ToString();
                    //            NDEvent.ChildNodes.Add(NDTemplate);
                    //        }
                    //    }
                    //}
                }
            }
        
        }
    }
}

