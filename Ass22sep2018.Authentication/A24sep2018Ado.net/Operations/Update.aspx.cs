using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL1_products_.ProductRepo;

namespace A24sep2018Ado.net
{
    public partial class Update : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            int s = Convert.ToInt32(Request.QueryString["Id"]);
            ProductRepository repo = new ProductRepository();
            repo.getDetails();
            Image image = new Image();
            PlaceHolder1.Controls.Add(image);
            image.ImageUrl = repo.productslist[s].ProductUrl;
            Label la = new Label();
            PlaceHolder1.Controls.Add(la);
            Label1.Text = repo.productslist[s].PName;
            Label2.Text = Convert.ToString(repo.productslist[s].Price);
            Label3.Text = repo.productslist[s].Description;



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

        //protected void Button1_Click1(object sender, EventArgs e)
        //{
        //    using (SqlConnection connection = new SqlConnection())
        //    {// using dataset
        //        connection.ConnectionString = "Data Source=Acupc_120;Initial Catalog=Auth1;Integrated Security=True";

        //        //DataSet dataSet = new DataSet("Auth1");

        //        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
        //        DataTable dataTable = new DataTable();
        //        DataGrid dataGrid = new DataGrid();
          
        //        SqlCommand sqlCommand = new SqlCommand("cartproc", connection);
        //        sqlCommand.CommandType = CommandType.StoredProcedure;
        //        sqlCommand.Parameters.Add("@Action", SqlDbType.VarChar, 10).Value = "INSERT";

        //        sqlCommand.Parameters.Add("@ProductId", SqlDbType.Int, 5).Value = TextBox1.Text;
        //        sqlCommand.Parameters.Add("@PName", SqlDbType.VarChar, 50).Value = TextBox2.Text;
        //        sqlCommand.Parameters.Add("@Price", SqlDbType.Float, 50).Value = TextBox3.Text;
        //        sqlCommand.Parameters.Add("@ImageUrl", SqlDbType.VarChar, 50).Value = TextBox4.Text;
        //        sqlCommand.Parameters.Add("@Description", SqlDbType.VarChar, 500).Value = TextBox5.Text;
        //        sqlCommand.Parameters.Add("@BrandId", SqlDbType.Int, 5).Value = DropDownList1.SelectedValue;

        //        sqlDataAdapter.SelectCommand = sqlCommand;
        //        sqlDataAdapter.Fill(dataTable);
        //        dataGrid.DataSource = dataTable;

        //        //DataTableMapping dataTableMapping =
        //        //    sqlDataAdapter.TableMappings.Add("Products", "NProducts");
        //        //dataTableMapping.ColumnMappings.Add()
        //--------------------------------------------------------------------------
        //        //connection.Open();
        //        //SqlCommand sqlCommand = new SqlCommand("cartproc", connection);
        //        //sqlCommand.CommandType = CommandType.StoredProcedure;
        //        //sqlCommand.Parameters.Add("@Action", SqlDbType.VarChar, 10).Value = "INSERT";

        //        //sqlCommand.Parameters.Add("@ProductId", SqlDbType.Int, 5).Value = TextBox1.Text;
        //        //sqlCommand.Parameters.Add("@PName", SqlDbType.VarChar, 50).Value = TextBox2.Text;
        //        //sqlCommand.Parameters.Add("@Price", SqlDbType.Float, 50).Value = TextBox3.Text;
        //        //sqlCommand.Parameters.Add("@ImageUrl", SqlDbType.VarChar, 50).Value = TextBox4.Text;
        //        //sqlCommand.Parameters.Add("@Description", SqlDbType.VarChar, 500).Value = TextBox5.Text;
        //        //sqlCommand.Parameters.Add("@BrandId", SqlDbType.Int, 5).Value = DropDownList1.SelectedValue;

        //        //sqlCommand.ExecuteNonQuery();

        //    }
        //}

        protected void Button2_Click(object sender, EventArgs e)
        {
            ProductRepository productRepository = new ProductRepository();
        

            int b = Convert.ToInt32(Request.QueryString["Id"]);
            int a = b + 1;
            productRepository.Update(a, TextBox2.Text, Convert.ToSingle(TextBox3.Text), TextBox4.Text, TextBox5.Text, Convert.ToInt32(DropDownList1.SelectedValue));

            Response.Redirect("/ProductManagement.aspx");









            //int a = Convert.ToInt32( TextBox1.Text);
            //int b = a - 1;

            //Response.Redirect("/ProductDetails.aspx?Id=" + b);

            //ProductDetails productDetails = new ProductDetails();
            //productDetails.
            //using (SqlConnection connection1 = new SqlConnection())
            //{

            //    // using data adapters
            //    connection1.ConnectionString = "Data Source=Acupc_120;Initial Catalog=Auth1;Integrated Security=True";

            //    connection1.Open();
            //    SqlCommand sqlCommand = new SqlCommand("cartproc", connection1);
            //    sqlCommand.CommandType = CommandType.StoredProcedure;
            //    sqlCommand.Parameters.Add("@Action", SqlDbType.VarChar, 10).Value = "UPDATE";

            //    sqlCommand.Parameters.Add("@ProductId", SqlDbType.Int, 5).Value = a;
            //    sqlCommand.Parameters.Add("@PName", SqlDbType.VarChar, 50).Value = TextBox2.Text;
            //    sqlCommand.Parameters.Add("@Price", SqlDbType.Float, 50).Value = TextBox3.Text;
            //    sqlCommand.Parameters.Add("@ImageUrl", SqlDbType.VarChar, 50).Value = TextBox4.Text;
            //    sqlCommand.Parameters.Add("@Description", SqlDbType.VarChar, 500).Value = TextBox5.Text;
            //    sqlCommand.Parameters.Add("@BrandId", SqlDbType.Int, 5).Value = DropDownList1.SelectedValue;
            //    sqlCommand.ExecuteNonQuery();

            //    
            //}

        }
    }
}
