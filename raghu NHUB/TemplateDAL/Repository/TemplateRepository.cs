using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateDAL.Model;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace TemplateDAL.Repository
{
    public class TemplateRepository
    {
        public List<TemplateProp> templateProps = new List<TemplateProp>();

        public void getDetails()
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = "Data Source=ACUPC_120;Initial Catalog=NotificationHub;Integrated Security=True";
                connection.Open();

                string sql = "select * from Template, TempalteChannel ";
                using (SqlCommand templateCommand = new SqlCommand())
                {
                    //DataSet templateStore = new DataSet();
                    //templateAdapter.Fill(templateStore);
                    SqlDataReader templateReader = templateCommand.ExecuteReader();
                    while (templateReader.Read())
                    {
                        templateProps.Add(new TemplateProp
                        {
                            //Id = Convert.ToInt32(templateReader["Id"]),
                            Name = templateReader["Name"].ToString(),
                            SourceName = templateReader["SourceName"].ToString(),
                            EventName = templateReader["EventName"].ToString(),
                        }
                            );
                    }

                }
            }
        }

        //public DataTable GetData(string query)
        //{
        //    DataTable dt = new DataTable();
        //    //string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
        //    using (SqlConnection con = new SqlConnection())
        //    {
        //        con.ConnectionString = "Data Source=ACUPC_120;Initial Catalog=NotificationHub;Integrated Security=True";
        //        con.Open();
        //        using (SqlCommand cmd = new SqlCommand(query))
        //        {
        //            using (SqlDataAdapter sda = new SqlDataAdapter())
        //            {
        //                cmd.CommandType = CommandType.Text;
        //                cmd.Connection = con;
        //                sda.SelectCommand = cmd;
        //                sda.Fill(dt);
        //            }
        //        }
        //        return dt;
        //    }
        //}
        public void Create(int ServiceLineId, int EventId, string Name, int ChannelId)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = "Data Source=ACUPC_120;Initial Catalog=NotificationHub;Integrated Security=True";
                connection.Open();
                // Note the "placeholders" in the SQL query.
                string sql = "Insert Into Template,TemplateChannel " +
                            "(ServiceLineId,EventId,Name,ChannelId) Values" +
                            "(@ServiceLineId,@EventId,@Name,@ChannelId)";

                // This command will have internal parameters.
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    // Fill params collection.
                    SqlParameter parameter = new SqlParameter
                    {
                        ParameterName = "@ServiceLineId",
                        Value = ServiceLineId,
                        SqlDbType = SqlDbType.Char,
                        Size = 10
                    };
                    command.Parameters.Add(parameter);

                    parameter = new SqlParameter
                    {
                        ParameterName = "@EventId",
                        Value = EventId,
                        SqlDbType = SqlDbType.Char,
                        Size = 10
                    };
                    command.Parameters.Add(parameter);

                    parameter = new SqlParameter
                    {
                        ParameterName = "@Name",
                        Value = Name,
                        SqlDbType = SqlDbType.Char,
                        Size = 10
                    };
                    command.Parameters.Add(parameter);

                    parameter = new SqlParameter
                    {
                        ParameterName = "@ChannelId",
                        Value = ChannelId,
                        SqlDbType = SqlDbType.Char,
                        Size = 10
                    };
                    command.Parameters.Add(parameter);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }


        }
        public void Delete(string Name)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = "Data Source=ACUPC_120;Initial Catalog=NotificationHub;Integrated Security=True";
                connection.Open();
                // Get ID of car to delete, then do so.
                string sql = $"Delete from Template where Name = '{Name}'";
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        Exception error = new Exception("Sorry! Error!", ex);
                        throw error;
                    }
                }
                connection.Close();
            }
        }

        //public void getdetails()
        //{


        //}
    }
}
