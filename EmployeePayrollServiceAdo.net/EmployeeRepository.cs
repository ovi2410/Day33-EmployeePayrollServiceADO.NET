using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollServiceAdo.net
{
    public class EmployeeRepository
    {
        // for Database Connection
        public static string connection = @"Server=.;Database=PayRoll_Service;Trusted_Connection=True;";
        SqlConnection sqlConnection = new SqlConnection(connection);
    }
}
