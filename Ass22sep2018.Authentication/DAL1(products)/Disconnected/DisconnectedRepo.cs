using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL1_products_.Disconnected
{
   public  class DisconnectedRepo
    {

        public void insert()
        {

            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = "Data Source=Acupc_120;Initial Catalog=Auth1;Integrated Security=True";


            }
        }
    }
}
