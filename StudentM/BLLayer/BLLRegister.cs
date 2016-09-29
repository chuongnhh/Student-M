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
    public class BLLRegister
    {
        private daLayer da;
        public BLLRegister()
        {
            da = new daLayer();
        }

        public bool Insert(ref string error, string StudentID, string CourseID,
            DateTime RegisterDay, decimal Tuition,decimal Payment,decimal Debt, string Note)
        {
            return da.ExcuteNoneQuery("spInsertRegister", CommandType.StoredProcedure, ref error,
                new SqlParameter("@StudentID", StudentID),
                new SqlParameter("@CourseID", CourseID),
                new SqlParameter("@RegisterDay", RegisterDay),
                new SqlParameter("@Tuition", Tuition),
                new SqlParameter("@Payment", Payment),
                new SqlParameter("@Debt", Debt),
                new SqlParameter("@Note", Note));
        }

        public bool Update(ref string error, string StudentID, string CourseID,
            DateTime RegisterDay, decimal Tuition, decimal Payment, decimal Debt, string Note)
        {
            return da.ExcuteNoneQuery("spUpdateRegister", CommandType.StoredProcedure, ref error,
                new SqlParameter("@StudentID", StudentID),
                new SqlParameter("@CourseID", CourseID),
                new SqlParameter("@RegisterDay", RegisterDay),
                new SqlParameter("@Tuition", Tuition),
                 new SqlParameter("@Payment", Payment),
                new SqlParameter("@Debt", Debt),
                new SqlParameter("@Note", Note));
        }


        public DataTable GetByStudent(string StudentID)
        {
            return da.ExecuteQuery("spGetRegisterByStudent", CommandType.StoredProcedure,
               new SqlParameter("@StudentID", StudentID));
        }
        public bool Delete(ref string error, string StudentID, string CourseID)
        {
            return da.ExcuteNoneQuery("spDeleteRegister", CommandType.StoredProcedure, ref error,
                new SqlParameter("@StudentID", StudentID),
                new SqlParameter("@CourseID", CourseID));
        }

        public bool DeleteByStudent(ref string error, string StudentID)
        {
            return da.ExcuteNoneQuery("spDeleteRegisterByStudent", CommandType.StoredProcedure, ref error,
                new SqlParameter("@StudentID", StudentID));
        }

        public bool DeleteByCourse(ref string error, string CourseID)
        {
            return da.ExcuteNoneQuery("spDeleteRegisterByCourse", CommandType.StoredProcedure, ref error,
                new SqlParameter("@CourseID", CourseID));
        }
    }
}
