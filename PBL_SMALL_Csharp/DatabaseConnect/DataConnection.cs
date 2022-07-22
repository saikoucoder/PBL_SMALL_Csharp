using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL_SMALL_Csharp.DatabaseConnect
{
    internal class DataConnection
    {
        string conStr;
        public DataConnection()
        {
            conStr = @"Data Source=LAPTOP-O2NPFHTH;Initial Catalog=Library;Integrated Security=True";
        }
        public SqlConnection getConnect()
        {
            return new SqlConnection(conStr);
        }
    }
}