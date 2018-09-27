using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL1_products_.Model;

namespace DAL1_products_.ProductRepo
{
    public class ProductRepository
    {
        public List<Products> productslist = new List<Products>();
       public List<Products> nameslist = new List<Products>();

        public List<Products> getDetails()
        {

            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = "Data Source=Acupc_120;Initial Catalog=Auth1;Integrated Security=True";

                connection.Open();

                string sql = "select * from products order by ProductId asc";
                SqlCommand sqlCommand = new SqlCommand(sql, connection);

                using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        productslist.Add(new Products
                        {
                            ProductId = Convert.ToInt32(sqlDataReader["ProductId"].ToString()),
                            PName = (sqlDataReader["PName"].ToString()),
                            Price = Convert.ToSingle(sqlDataReader["Price"].ToString()),
                            ProductUrl = sqlDataReader["ImageUrl"].ToString(),
                            Description = sqlDataReader["Description"].ToString(),
                            BrandId = Convert.ToInt32(sqlDataReader["BrandId"].ToString())


                        });
                    }
                }
            }

            return productslist;
        }

        public List<Products> Searchbyname(string SName)
        {
         
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = "Data Source=Acupc_120;Initial Catalog=Auth1;Integrated Security=True";

                connection.Open();
                string sqlc = "select * from Products where PName like '%"+SName+"%'";
                //  string sqlc = string.Format("select * from Products where pName like '%{0}%'",SName);
                SqlCommand sqlCommand = new SqlCommand(sqlc, connection);
                using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        nameslist.Add(new Products
                        {

                            ProductId = Convert.ToInt32(sqlDataReader["ProductId"].ToString()),
                            PName = (sqlDataReader["PName"].ToString()),
                            Price = Convert.ToSingle(sqlDataReader["Price"].ToString()),
                            ProductUrl = sqlDataReader["ImageUrl"].ToString(),
                            Description = sqlDataReader["Description"].ToString(),
                            BrandId= Convert.ToInt32(sqlDataReader["BrandId"].ToString())

                        });


                    }

                }
            }
            return nameslist;
        }





        public void Insert(string PName,float Price,string ImageUrl,string Description,int BrandId)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = "Data Source=Acupc_120;Initial Catalog=Auth1;Integrated Security=True";

                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("Insertproc", connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@Action", SqlDbType.VarChar, 10).Value = "INSERT";

                // sqlCommand.Parameters.Add("@ProductId", SqlDbType.Int, 5).Value = TextBox1.Text;
                //sqlCommand.Parameters.Add("@PName", SqlDbType.VarChar, 50).Value = TextBox2.Text;
                //sqlCommand.Parameters.Add("@Price", SqlDbType.Float, 50).Value = TextBox3.Text;
                //sqlCommand.Parameters.Add("@ImageUrl", SqlDbType.VarChar, 50).Value = TextBox4.Text;
                //sqlCommand.Parameters.Add("@Description", SqlDbType.VarChar, 500).Value = TextBox5.Text;
                //sqlCommand.Parameters.Add("@BrandId", SqlDbType.Int, 5).Value = DropDownList1.SelectedValue;

                sqlCommand.Parameters.Add("@PName", SqlDbType.VarChar, 50).Value = PName;
                sqlCommand.Parameters.Add("@Price", SqlDbType.Float, 50).Value = Price;
                sqlCommand.Parameters.Add("@ImageUrl", SqlDbType.VarChar, 50).Value = ImageUrl;
                sqlCommand.Parameters.Add("@Description", SqlDbType.VarChar, 500).Value = Description;
                sqlCommand.Parameters.Add("@BrandId", SqlDbType.Int, 5).Value = BrandId;



                sqlCommand.ExecuteNonQuery();


            }

        }


        public void Update(int ProductId,string ProductName,float Price,string ImageUrl,string Description,int BrandId)
        {

            using (SqlConnection connection1 = new SqlConnection())
            {

                // using data adapters
                connection1.ConnectionString = "Data Source=Acupc_120;Initial Catalog=Auth1;Integrated Security=True";

                connection1.Open();
                SqlCommand sqlCommand = new SqlCommand("cartproc", connection1);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@Action", SqlDbType.VarChar, 10).Value = "UPDATE";
                sqlCommand.Parameters.Add("@ProductId", SqlDbType.Int, 5).Value = ProductId;
                sqlCommand.Parameters.Add("@PName", SqlDbType.VarChar, 50).Value = ProductName;
                sqlCommand.Parameters.Add("@Price", SqlDbType.Float, 50).Value = Price;
                sqlCommand.Parameters.Add("@ImageUrl", SqlDbType.VarChar, 50).Value =ImageUrl;
                sqlCommand.Parameters.Add("@Description", SqlDbType.VarChar, 500).Value = Description;
                sqlCommand.Parameters.Add("@BrandId", SqlDbType.Int, 5).Value = BrandId;

                sqlCommand.ExecuteNonQuery();

                //sqlCommand.Parameters.Add("@ProductId", SqlDbType.Int, 5).Value = TextBox1.text;
                //sqlCommand.Parameters.Add("@PName", SqlDbType.VarChar, 50).Value = TextBox2.text;
                //sqlCommand.Parameters.Add("@Price", SqlDbType.Float, 50).Value = TextBox3.Text;
                //sqlCommand.Parameters.Add("@ImageUrl", SqlDbType.VarChar, 50).Value = TextBox4.Text;
                //sqlCommand.Parameters.Add("@Description", SqlDbType.VarChar, 500).Value = TextBox5.Text;
                //sqlCommand.Parameters.Add("@BrandId", SqlDbType.Int, 5).Value = DropDownList1.SelectedValue;


            }
        } 


        public void Delete(int ProductId)
        {
            using (SqlConnection connection2 = new SqlConnection())
            {
                connection2.ConnectionString = "Data Source=Acupc_120;Initial Catalog=Auth1;Integrated Security=True";
                connection2.Open();

                SqlCommand sqlCommand = new SqlCommand("delproc", connection2);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@Action", SqlDbType.VarChar, 10).Value = "DELETE";

                sqlCommand.Parameters.Add("@ProductId", SqlDbType.Int, 5).Value = ProductId;
                sqlCommand.ExecuteNonQuery();



            }
        }

    }
}
