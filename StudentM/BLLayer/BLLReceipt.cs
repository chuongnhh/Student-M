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
    public class BLLReceipt
    {
        private daLayer da;

        public BLLReceipt()
        {
            da = new daLayer();
        }

        //public DataTable GetByStudent(string StudentID)
        //{
        //    return da.ExecuteQuery("spGetReceiptStudent", CommandType.StoredProcedure,
        //       new SqlParameter("@StudentID", StudentID));
        //}
        public DataTable GetByRegister(string StudentID,string CourseID)
        {
            return da.ExecuteQuery("spGetReceiptByRegister", CommandType.StoredProcedure,
               new SqlParameter("@StudentID", StudentID),
               new SqlParameter("@CourseID", CourseID));
        }
        public bool Insert(ref string error,string ReceiptID,string StudentID,
            string CourseID,decimal Payment,DateTime Date)
        {
            return da.ExcuteNoneQuery("spInsertReceipt", CommandType.StoredProcedure,
                ref error,
                new SqlParameter("@ReceiptID", ReceiptID),
                new SqlParameter("@StudentID", StudentID),
                new SqlParameter("@CourseID", CourseID),
                new SqlParameter("@Payment", Payment), 
                new SqlParameter("@Date", Date));
        }
        public bool Update(ref string error, string ReceiptID, string StudentID,
          string CourseID, decimal Payment, DateTime Date)
        {
            return da.ExcuteNoneQuery("spUpdateReceipt", CommandType.StoredProcedure,
                ref error,
                new SqlParameter("@ReceiptID", ReceiptID),
                new SqlParameter("@StudentID", StudentID),
                new SqlParameter("@CourseID", CourseID),
                new SqlParameter("@Payment", Payment),
                new SqlParameter("@Date", Date));
        }
        public bool DeleteByStudent(ref string error, string StudentID)
        {
            return da.ExcuteNoneQuery("spDeleteReceiptByStudent", CommandType.StoredProcedure, ref error,
                new SqlParameter("@StudentID", StudentID));
        }

        public bool DeleteByCourse(ref string error, string CourseID)
        {
            return da.ExcuteNoneQuery("spDeleteReceiptByCourse", CommandType.StoredProcedure, ref error,
                new SqlParameter("@CourseID", CourseID));
        }
    }
}
