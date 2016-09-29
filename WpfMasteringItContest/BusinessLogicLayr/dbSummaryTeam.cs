using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayr
{
   public class dbSummaryTeam
    {
        DataAccess db;

        public dbSummaryTeam()
        {
            db = new DataAccess();
        }

        public DataTable getSummaryTeamDesc(int maHeThi)
        {
            string sql = "select DoiThi.maDoiThi, DoiThi.tenDoiThi, SUM(DiemSo.diemSo) tongDiem " +
                            "from DiemSo inner join DoiThi on DiemSo.maDoiThi=DoiThi.maDoiThi " +
                            "where DiemSo.maHeThi = " + maHeThi +
                            "group by DoiThi.maDoiThi, DoiThi.tenDoiThi " +
                            "order by tongDiem desc";
            return db.ExecuteQuery(sql, CommandType.Text, null);
        }
    }
}
