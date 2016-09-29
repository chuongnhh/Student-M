using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALayer
{
    public class daLayer
    {
        private string sqlConnect = @"data source = chuongnh\chuongnhdev; initial catalog = StudentM; integrated security = true";

        private SqlConnection cnn;
        private SqlCommand cmd;
        private SqlDataAdapter da;

        public daLayer()
        {
            cnn = new SqlConnection(sqlConnect);
            cmd = cnn.CreateCommand();
        }

        public DataTable ExecuteQuery(string cmdText, CommandType cmdType, params SqlParameter[] sqlParam)
        {
            DataTable dt = new DataTable();

            if (cnn.State == ConnectionState.Closed)
                cnn.Open();
            cmd.CommandText = cmdText;
            cmd.CommandType = cmdType;
            cmd.CommandTimeout = 15;
            cmd.Parameters.Clear();
            try
            {
                foreach (SqlParameter param in sqlParam)
                    cmd.Parameters.Add(param);
            }
            catch { }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        public bool ExcuteNoneQuery(string cmdText, CommandType cmdType, ref string error, params SqlParameter[] sqlParam)
        {
            if (cnn.State == ConnectionState.Closed)
                cnn.Open();
            cmd.CommandText = cmdText;
            cmd.CommandType = cmdType;
            cmd.CommandTimeout = 15;
            cmd.Parameters.Clear();

            foreach (SqlParameter param in sqlParam)
                cmd.Parameters.Add(param);

            bool excuteSuccess = false;
            try
            {
                cmd.ExecuteNonQuery();
                excuteSuccess = true;
            }
            catch (SqlException sqlException)
            {
                error = sqlException.Message;
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
            return excuteSuccess;
        }
    }
}
