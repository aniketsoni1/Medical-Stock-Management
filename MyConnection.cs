using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace CarryAndForwardAgent
{
    class MyConnection
    {
        public SqlConnection mycon = new SqlConnection("Data Source=ANIKETSONI\\SQLEXPRESS;Initial Catalog=CarryandForwardAgent;Integrated Security=True");
    
    }
}
