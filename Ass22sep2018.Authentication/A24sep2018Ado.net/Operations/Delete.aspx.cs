using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace A24sep2018Ado.net
{
    public partial class Delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int b = Convert.ToInt32(Request.QueryString["Id"]);

            using (SqlConnection connection2 = new SqlConnection())
            {
                connection2.ConnectionString = "Data Source=Acupc_120;Initial Catalog=Auth1;Integrated Security=True";
                connection2.Open();

                SqlCommand sqlCommand = new SqlCommand("cartproc", connection2);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@Action", SqlDbType.VarChar, 10).Value = "DELETE";

                sqlCommand.Parameters.Add("@ProductId", SqlDbType.Int, 5).Value = b;
                sqlCommand.ExecuteNonQuery();

            }



        }
    }
}