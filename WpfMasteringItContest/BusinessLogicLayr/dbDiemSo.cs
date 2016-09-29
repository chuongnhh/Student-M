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
   public class dbDiemSo
    {
        DataAccess db;

        public dbDiemSo()
        {
            db = new DataAccess();
        }
        public DataTable getDiemSo()
        {
            return db.ExecuteQuery("select *from DiemSo", CommandType.Text, null);
        }

        public DataTable getDiemSoTheoDoiThiVaTroChoi(int maDoiThi, int maHeThi, int maTroChoi)
        {
            string sql = "select *from DiemSo where maDoiThi = '" + maDoiThi + "' and maHeThi = '" + maHeThi + "' and maTroChoi = '" + maTroChoi + "'";
            return db.ExecuteQuery(sql, CommandType.Text, null);
        }

        public DataTable getDiemSoTheoDoiThi(int maDoiThi)
        {
            string sql = "select *from DiemSo where maDoiThi = '" + maDoiThi + "'";
            return db.ExecuteQuery(sql, CommandType.Text, null);
        }

        public bool insertDiemSo(ref string err, int maDoiThi, int maTroChoi, int maHeThi, float diemSo)
        {
            return db.ExecuteNonQuery("spInsertDiemSo", CommandType.StoredProcedure, ref err,
                new SqlParameter("@maDoiThi", maDoiThi),
                new SqlParameter("@maTroChoi", maTroChoi),
                new SqlParameter("@maHeThi", maHeThi),
                new SqlParameter("@diemSo", diemSo));
        }

        public bool updateDiemSo(ref string err, int maDoiThi, int maTroChoi, int maHeThi, float diemSo)
        {
            return db.ExecuteNonQuery("spUpdateDiemSo", CommandType.StoredProcedure, ref err,
                new SqlParameter("@maDoiThi", maDoiThi),
                new SqlParameter("@maTroChoi", maTroChoi),
                new SqlParameter("@maHeThi", maHeThi),
                new SqlParameter("@diemSo", diemSo));
        }

        public bool deleteDiemSo(ref string err, int maDoiThi, int maTroChoi, int maHeThi)
        {
            return db.ExecuteNonQuery("spDeleteDiemSo", CommandType.StoredProcedure, ref err,
                new SqlParameter("@maDoiThi", maDoiThi),
                new SqlParameter("@maTroChoi", maTroChoi),
                new SqlParameter("@maHeThi", maHeThi));
        }
    }
}
