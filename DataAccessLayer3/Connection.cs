using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer3
{
    public class Connection
    {
        public static SqlConnection bgl = new SqlConnection(@"Data Source = LAPTOP-B0T59E4D;Initial Catalog=yazokulu;Integrated Security = True");
    }
}
