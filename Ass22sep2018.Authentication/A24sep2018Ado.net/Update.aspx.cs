using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace A24sep2018Ado.net
{
    public partial class Update : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //    using (SqlConnection connection = new SqlConnection())
            //    {
            //        connection.ConnectionString =
            //         @"Data Source=(local)\SQLEXPRESS2014;Integrated Security=SSPI;" +
            //         "Initial Catalog=AutoLot";
            //        connection.Open();
            //        // Create a SQL command object.
            //        string sql = "Select * From Inventory";
            //        SqlCommand myCommand = new SqlCommand("", connection);
            //        //myCommand.Connection = connection;
            //        //myCommand.CommandText= sql;

            //        // Obtain a data reader a la ExecuteReader().
            //        //                SqlDataReader myDataReader = myCommand.ExecuteReader()


            //        using (SqlDataReader myDataReader = myCommand.ExecuteReader())
            //        {
            //            // Loop over the results.
            //            while (myDataReader.Read())
            //            {
            //                WriteLine($"-> Make: {myDataReader["Make"]}, PetName: {myDataReader["PetName"]}, Color: {myDataReader["Color"]}.");
            //            }
            //        }


        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = "Data Source=Acupc_120;Initial Catalog=Auth1;Integrated Security=True";
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("cartproc", connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@Action", SqlDbType.VarChar, 10).Value = "INSERT";

                sqlCommand.Parameters.Add("@ProductId", SqlDbType.Int, 5).Value = TextBox1.Text;
                sqlCommand.Parameters.Add("@PName", SqlDbType.VarChar, 50).Value = TextBox2.Text;
                sqlCommand.Parameters.Add("@Price", SqlDbType.Float, 50).Value = TextBox3.Text;
                sqlCommand.Parameters.Add("@ImageUrl", SqlDbType.VarChar, 50).Value = TextBox4.Text;
                sqlCommand.Parameters.Add("@Description", SqlDbType.VarChar, 500).Value = TextBox5.Text;
                sqlCommand.Parameters.Add("@BrandId", SqlDbType.Int, 5).Value = DropDownList1.SelectedValue;
               
                sqlCommand.ExecuteNonQuery();

            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection1 = new SqlConnection())
            {
                connection1.ConnectionString = "Data Source=Acupc_120;Initial Catalog=Auth1;Integrated Security=True";

                connection1.Open();
                SqlCommand sqlCommand = new SqlCommand("cartproc", connection1);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@Action", SqlDbType.VarChar, 10).Value = "UPDATE";

                sqlCommand.Parameters.Add("@ProductId", SqlDbType.Int, 5).Value = TextBox1.Text;
                sqlCommand.Parameters.Add("@PName", SqlDbType.VarChar, 50).Value = TextBox2.Text;
                sqlCommand.Parameters.Add("@Price", SqlDbType.Float, 50).Value = TextBox3.Text;
                sqlCommand.Parameters.Add("@ImageUrl", SqlDbType.VarChar, 50).Value = TextBox4.Text;
                sqlCommand.Parameters.Add("@Description", SqlDbType.VarChar, 500).Value = TextBox5.Text;
                sqlCommand.Parameters.Add("@BrandId", SqlDbType.Int, 5).Value = DropDownList1.SelectedValue;
                sqlCommand.ExecuteNonQuery();

            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection2 = new SqlConnection())
            {
                connection2.ConnectionString = "Data Source=Acupc_120;Initial Catalog=Auth1;Integrated Security=True";

                connection2.Open();
                SqlCommand sqlCommand = new SqlCommand("cartproc", connection2);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@Action", SqlDbType.VarChar, 10).Value = "DELETE";



                sqlCommand.Parameters.Add("@ProductId", SqlDbType.Int, 5).Value = TextBox1.Text;
                sqlCommand.Parameters.Add("@PName", SqlDbType.VarChar, 50).Value = TextBox2.Text;
                sqlCommand.Parameters.Add("@Price", SqlDbType.Float, 50).Value = TextBox3.Text;
                sqlCommand.Parameters.Add("@ImageUrl", SqlDbType.VarChar, 50).Value = TextBox4.Text;
                sqlCommand.Parameters.Add("@Description", SqlDbType.VarChar, 500).Value = TextBox5.Text;
                sqlCommand.Parameters.Add("@BrandId", SqlDbType.Int, 5).Value = DropDownList1.SelectedValue;
                sqlCommand.ExecuteNonQuery();

            }
        }
    }
}
