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
   public class dbDoiThi
    {
        DataAccess db;

        public dbDoiThi()
        {
            db = new DataAccess();
        }

        public DataTable getDoiThi()
        {
            return db.ExecuteQuery("select *from DoiThi", CommandType.Text, null);
        }

        public DataTable getDoiThiTheoMaHeThi(int maHeThi)
        {
            return db.ExecuteQuery("select *from DoiThi where maHeThi = '" + maHeThi + "'", CommandType.Text, null);
        }

        public DataTable get3DoiThiTheoMaHeThi(int maHeThi)
        {
            string sql = " select top 3 DoiThi.maDoiThi, DoiThi.tenDoiThi, SUM(DiemSo.diemSo) tongDiem " +
                           "from DiemSo inner join DoiThi on DiemSo.maDoiThi=DoiThi.maDoiThi " +
                           "where DiemSo.maHeThi = " + maHeThi +
                           "group by DoiThi.maDoiThi, DoiThi.tenDoiThi " +
                           "order by tongDiem desc";

            return db.ExecuteQuery(sql, CommandType.Text, null);
        }

        public bool insertDoiThi(ref string err, int maHeThi, string tenDoiThi, string thanhVien1, string thanhVien2
            , string thanhVien3, string thanhVien4, string thanhVien5)
        {
            return db.ExecuteNonQuery("spInsertDoiThi", CommandType.StoredProcedure, ref err,
                new SqlParameter("@maHeThi", maHeThi),
                new SqlParameter("@tenDoiThi", tenDoiThi),
                new SqlParameter("@thanhVien1", thanhVien1),
                new SqlParameter("@thanhVien2", thanhVien2),
                new SqlParameter("@thanhVien3", thanhVien3),
                new SqlParameter("@thanhVien4", thanhVien4),
                new SqlParameter("@thanhVien5", thanhVien5));
        }

        public bool updateDoiThi(ref string err, int maDoiThi, int maHeThi, string tenDoiThi, string thanhVien1, string thanhVien2
           , string thanhVien3, string thanhVien4, string thanhVien5)
        {
            return db.ExecuteNonQuery("spUpdateDoiThi", CommandType.StoredProcedure, ref err,
                new SqlParameter("@maDoiThi", maDoiThi),
                new SqlParameter("@maHeThi", maHeThi),
                new SqlParameter("@tenDoiThi", tenDoiThi),
                new SqlParameter("@thanhVien1", thanhVien1),
                new SqlParameter("@thanhVien2", thanhVien2),
                new SqlParameter("@thanhVien3", thanhVien3),
                new SqlParameter("@thanhVien4", thanhVien4),
                new SqlParameter("@thanhVien5", thanhVien5));
        }

        public bool deleteDoiThi(ref string err, int maDoiThi, int maHeThi)
        {
            return db.ExecuteNonQuery("spDeleteDoiThi", CommandType.StoredProcedure, ref err,
                new SqlParameter("@maDoiThi", maDoiThi),
                new SqlParameter("@maHeThi", maHeThi));
        }
    }
}
