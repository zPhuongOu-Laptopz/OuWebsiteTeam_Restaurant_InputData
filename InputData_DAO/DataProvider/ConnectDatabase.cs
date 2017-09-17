using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace InputData_DAO.DataProvider
{
    public class ConnectDatabase
    {
        public SqlConnection cn = null;

        //public ConnectDatabase()
        //{
        //    string ChuoiKetNoi = ConfigurationManager.ConnectionStrings["RestaurantDBContext"].ConnectionString; // gán chuỗi kết nói bên App.config => biến
        //    cn = new SqlConnection(ChuoiKetNoi);
        //}

        ////Allow access to DB
        //public void Connect()
        //{
        //    if (cn != null && cn.State==ConnectionState.Closed)
        //    {
        //        cn.Open();
        //    }
        //}

        ////Don't allow access to DB
        //public void Disconnect()
        //{
        //    if (cn!=null && cn.State==ConnectionState.Open)
        //    {
        //        cn.Close();
        //    }
        //}
    }
}
