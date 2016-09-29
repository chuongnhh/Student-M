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
    public class dbTroChoi
    {
        DataAccess db;

        public dbTroChoi()
        {
            db = new DataAccess();
        }

        public DataTable getTroChoi()
        {
            return db.ExecuteQuery("select *from TroChoi", CommandType.Text, null);
        }

        public DataTable getTroChoiTheoMaTroChoi(int maTroChoi)
        {
            return db.ExecuteQuery("select *from TroChoi where maTroChoi = '" + maTroChoi + "'", CommandType.Text, null);
        }

        public DataTable getTroChoiTheoHeThi(int maHeThi)
        {
            return db.ExecuteQuery("select *from TroChoi where maHeThi = '" + maHeThi + "'", CommandType.Text, null);
        }

        public bool insertTroChoi(ref string err, int maHeThi, string tenTroChoi, int thoiGian)
        {
            return db.ExecuteNonQuery("spInsertTroChoi", CommandType.StoredProcedure, ref err,
                new SqlParameter("@maHeThi", maHeThi),
                new SqlParameter("@tenTroChoi", tenTroChoi),
                new SqlParameter("@thoiGian", thoiGian));
        }

        public bool updateTroChoi(ref string err, int maTroChoi, int maHeThi, string tenTroChoi, int thoiGian)
        {
            return db.ExecuteNonQuery("spUpdateTroChoi", CommandType.StoredProcedure, ref err,
                new SqlParameter("@maHeThi", maHeThi),
                new SqlParameter("@tenTroChoi", tenTroChoi),
                new SqlParameter("@thoiGian", thoiGian),
                new SqlParameter("@maTroChoi", maTroChoi));
        }

        public bool deleteTroChoi(ref string err, int maTroChoi)
        {
            return db.ExecuteNonQuery("spDeleteTroChoi", CommandType.StoredProcedure, ref err,
                new SqlParameter("@maTroChoi", maTroChoi));
        }
    }
}
