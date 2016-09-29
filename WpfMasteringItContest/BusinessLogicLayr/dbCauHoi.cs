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
    public class dbCauHoi
    {
        DataAccess db;

        public dbCauHoi()
        {
            db = new DataAccess();
        }

        public DataTable getCauHoi()
        {
            return db.ExecuteQuery("select *from CauHoi", CommandType.Text, null);
        }


        public DataTable getCauHoiTheoTroChoi(int maTroChoi)
        {
            string sql = "select * from CauHoi where maTroChoi = '" + maTroChoi + "'";
            return db.ExecuteQuery(sql, CommandType.Text, null);
        }

        public DataTable getCauHoiTheoMaCauHoi(int maCauHoi)
        {
            string sql = "select * from CauHoi where maCauHoi = '" + maCauHoi + "'";
            return db.ExecuteQuery(sql, CommandType.Text, null);
        }

        public bool insertCauHoi(ref string err, int maTroChoi, string tenCauHoi, string noiDung, string luaChonA,
            string luaChonB, string luaChonC, string luaChonD, string dapAnDung)
        {
            return db.ExecuteNonQuery("spInsertCauHoi", CommandType.StoredProcedure, ref err,
                new SqlParameter("@maTroChoi", maTroChoi),
                new SqlParameter("@tenCauHoi", tenCauHoi),
                new SqlParameter("@noiDung", noiDung),
                new SqlParameter("@luaChonA", luaChonA),
                new SqlParameter("@luaChonB", luaChonB),
                new SqlParameter("@luaChonC", luaChonC),
                new SqlParameter("@luaChonD", luaChonD),
                new SqlParameter("@dapAnDung", dapAnDung));
        }

        public bool updateCauHoi(ref string err, int maCauHoi, int maTroChoi, string tenCauHoi, string noiDung, string luaChonA,
            string luaChonB, string luaChonC, string luaChonD, string dapAnDung)
        {
            return db.ExecuteNonQuery("spUpdateCauHoi", CommandType.StoredProcedure, ref err,
                 new SqlParameter("@maCauHoi", maCauHoi),
                new SqlParameter("@maTroChoi", maTroChoi),
                new SqlParameter("@tenCauHoi", tenCauHoi),
                new SqlParameter("@noiDung", noiDung),
                new SqlParameter("@luaChonA", luaChonA),
                new SqlParameter("@luaChonB", luaChonB),
                new SqlParameter("@luaChonC", luaChonC),
                new SqlParameter("@luaChonD", luaChonD),
                new SqlParameter("@dapAnDung", dapAnDung));
        }

        public bool deleteCauHoi(ref string err, int maCauHoi)
        {
            return db.ExecuteNonQuery("spDeleteCauHoi", CommandType.StoredProcedure, ref err,
                new SqlParameter("@maCauHoi", maCauHoi));
        }
    }
}
