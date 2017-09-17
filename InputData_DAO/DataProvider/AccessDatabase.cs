using System.Data;
using System.Data.SqlClient;
using InputData_DAO.DataProvider;

namespace InputData_DAO.DataProvider
{
    public class AccessDatabase
    {
        public DataTable GetAllData(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, new InputData_DAO.DataProvider.ConnectDatabase { }.cn); 
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
