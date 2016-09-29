using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayr
{
    public class dbHeThi
    {
        DataAccess db;

        public dbHeThi()
        {
            db = new DataAccess();
        }

        public DataTable getHeThi()
        {
            return db.ExecuteQuery("select * from HeThi", CommandType.Text, null);
        }

        public bool insertHeThi(ref string err, string tenHeThi)
        {
            return db.ExecuteNonQuery("spInsertHeThi", CommandType.StoredProcedure, ref err,
                new SqlParameter("@tenHeThi", tenHeThi));
        }


        public bool updateHeThi(ref string err, int maHeThi, string tenHeThi)
        {
            return db.ExecuteNonQuery("spUpdateHeThi", CommandType.StoredProcedure, ref err,
                new SqlParameter("@tenHeThi", tenHeThi),
                new SqlParameter("@maHeThi", maHeThi));
        }

        public bool deleteHeThi(ref string err, int maHeThi)
        {
            return db.ExecuteNonQuery("spDeleteHeThi", CommandType.StoredProcedure, ref err,
                new SqlParameter("@maHeThi", maHeThi));
        }
    }
}
