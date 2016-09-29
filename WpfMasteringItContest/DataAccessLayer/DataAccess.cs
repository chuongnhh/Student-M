using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DataAccess
    {
        SqlConnection cnn;
        SqlCommand cmd;
        SqlDataAdapter da;

        string stringConnection = "data source = chuongnh\\chuongnhdev; initial catalog = db_mitcontest_final; integrated security = true";
        //string stringConnection = "data source = chuongnh\\chuongnhdev; initial catalog = db_mitcontest_demo; integrated security = true";

        public DataAccess()
        {
            cnn = new SqlConnection(stringConnection);
            cmd = cnn.CreateCommand();
        }

        // Select query
        public DataTable ExecuteQuery(string sqlString, CommandType cmdType, params SqlParameter[] sqlParam)
        {
            cmd.CommandText = sqlString;
            cmd.CommandType = cmdType;
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        // action query
        public bool ExecuteNonQuery(string sqlString, CommandType cmdType,
            ref string errorMessage, params SqlParameter[] sqlParam)
        {
            bool flag = false;
            cnn.Open();
            cmd.Parameters.Clear();
            cmd.CommandText = sqlString;
            cmd.CommandType = cmdType;
            foreach (SqlParameter p in sqlParam)
                cmd.Parameters.Add(p);
            try
            {
                cmd.ExecuteNonQuery();
                flag = true;
            }
            catch (SqlException ex)
            {
                errorMessage = ex.Message;
            }
            finally
            {
                cnn.Close();
            }
            return flag;

        }
    }
}
