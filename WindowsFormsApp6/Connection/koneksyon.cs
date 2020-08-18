using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace WindowsFormsApp6.Connection
{
    class koneksyon
    {
        SqlConnection conn;

        public SqlConnection getConnect()
        {
            conn = new SqlConnection("Data Source = GENEVIEVE\\SQLEXPRESS; Initial Catalog = myDB; Integrated Security = True");
            return conn;
        }
    }
}
