using System;
using System.Collections.Generic;
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
    }
}
