using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL1_products_.ProductRepo;

namespace A24sep2018Ado.net
{
    public partial class Insert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            ProductRepository repository = new ProductRepository();
            repository.Insert(TextBox2.Text, Convert.ToSingle(TextBox3.Text), TextBox4.Text, TextBox5.Text, Convert.ToInt32(DropDownList1.SelectedValue));

            Response.Redirect("/ProductManagement.aspx");

            //using (SqlConnection connection = new SqlConnection())
            //{
            //    connection.ConnectionString = "Data Source=Acupc_120;Initial Catalog=Auth1;Integrated Security=True";

            //    connection.Open();
            //    SqlCommand sqlCommand = new SqlCommand("Insertproc", connection);
            //    sqlCommand.CommandType = CommandType.StoredProcedure;
            //    sqlCommand.Parameters.Add("@Action", SqlDbType.VarChar, 10).Value = "INSERT";

            //   // sqlCommand.Parameters.Add("@ProductId", SqlDbType.Int, 5).Value = TextBox1.Text;
            //    sqlCommand.Parameters.Add("@PName", SqlDbType.VarChar, 50).Value = TextBox2.Text;
            //    sqlCommand.Parameters.Add("@Price", SqlDbType.Float, 50).Value = TextBox3.Text;
            //    sqlCommand.Parameters.Add("@ImageUrl", SqlDbType.VarChar, 50).Value = TextBox4.Text;
            //    sqlCommand.Parameters.Add("@Description", SqlDbType.VarChar, 500).Value = TextBox5.Text;
            //    sqlCommand.Parameters.Add("@BrandId", SqlDbType.Int, 5).Value = DropDownList1.SelectedValue;

            //    sqlCommand.ExecuteNonQuery();


            //}
        }
    }
}