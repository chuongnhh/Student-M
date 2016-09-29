using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALayer;
using System.Data;
using System.Data.SqlClient;

namespace BLLayer
{
    public class BLLLevel
    {
        private daLayer da;

        public BLLLevel()
        {
            da = new daLayer();
        }

        public DataTable GetAll()
        {
            return da.ExecuteQuery("spGetLevel", CommandType.StoredProcedure, null);
        }

        public bool Insert(ref string error,string LevelID,string LevelName)
        {
            return da.ExcuteNoneQuery("spInsertLevel", CommandType.StoredProcedure, ref error,
                new SqlParameter("@LevelID", LevelID),
                new SqlParameter("@LevelName", LevelName));
        }

        public bool Update(ref string error, string LevelID, string LevelName)
        {
            return da.ExcuteNoneQuery("spUpdateLevel", CommandType.StoredProcedure, ref error,
                new SqlParameter("@LevelID", LevelID),
                new SqlParameter("@LevelName", LevelName));
        }
    }
}
