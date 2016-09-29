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
    public class BLLCourse
    {
        private daLayer da;

        public BLLCourse()
        {
            da = new daLayer();
        }

        public DataTable GetAll()
        {
            return da.ExecuteQuery("spGetCourse", CommandType.StoredProcedure, null);
        }
        public DataTable GetByCourseID(string CourseID)
        {
            return da.ExecuteQuery("spGetCourseByCourseID", CommandType.StoredProcedure,
                new SqlParameter("@CourseID", CourseID));
        }


        public DataTable GetByLevel(string LevelID)
        {
            return da.ExecuteQuery("spGetCourseByLevel", CommandType.StoredProcedure,
                new SqlParameter("@LevelID", LevelID));
        }

        public DataTable GetByOpening(DateTime FromDate,DateTime ToDate)
        {
            return da.ExecuteQuery("spGetCourseByOpening", CommandType.StoredProcedure,
                new SqlParameter("@FromDate", FromDate),
                new SqlParameter("@ToDate", ToDate));
        }


        public DataTable GetByOpeningAndLevel(string LevelID,DateTime FromDate,DateTime ToDate)
        {
            return da.ExecuteQuery("spGetCourseByOpeningAndLevel", CommandType.StoredProcedure,
                new SqlParameter("@LevelID", LevelID),
                new SqlParameter("@FromDate", FromDate),
                new SqlParameter("@ToDate", ToDate));
        }

        public bool Insert(ref string error, string CourseID, string CourseName,
           DateTime CourseTime, DateTime Opening, DateTime Closing,
           string FirstDay, string SecondDay, string Skill, string Practice, string LevelID)
        {
            return da.ExcuteNoneQuery("spInsertCourse", CommandType.StoredProcedure, ref error,
                new SqlParameter("@CourseID", CourseID),
                new SqlParameter("@CourseName", CourseName),
                new SqlParameter("@CourseTime", CourseTime),
                new SqlParameter("@Opening", Opening),
                new SqlParameter("@Closing", Closing),

                new SqlParameter("@FirstDay", FirstDay),
                new SqlParameter("@SecondDay", SecondDay),
                new SqlParameter("@Skill", Skill),
                new SqlParameter("@Practice", Practice),

                new SqlParameter("@LevelID", LevelID));
        }

        public bool Update(ref string error, string CourseID, string CourseName,
          DateTime ClassTime, DateTime Opening, DateTime Closing,
          string FirstDay, string SecondDay, string Skill, string Practice, string LevelID)
        {
            return da.ExcuteNoneQuery("spUpdateCourse", CommandType.StoredProcedure, ref error,
                new SqlParameter("@CourseID", CourseID),
                new SqlParameter("@CourseName", CourseName),
                new SqlParameter("@CourseTime", ClassTime),
                new SqlParameter("@Opening", Opening),
                new SqlParameter("@Closing", Closing),

                new SqlParameter("@FirstDay", FirstDay),
                new SqlParameter("@SecondDay", SecondDay),
                new SqlParameter("@Skill", Skill),
                new SqlParameter("@Practice", Practice),

                new SqlParameter("@LevelID", LevelID));
        }

        public bool Delete(ref string error, string CourseID)
        {
            return da.ExcuteNoneQuery("spDeleteCourse", CommandType.StoredProcedure, ref error,
                new SqlParameter("@CourseID", CourseID));
        }

        // Search Course by ID
        public DataTable SearchCourseID(string CourseID)
        {
            return da.ExecuteQuery("spSearchCourseID", CommandType.StoredProcedure,
                new SqlParameter("@CourseID", CourseID));
        }

        public DataTable SearchCourseName(string CourseName)
        {
            return da.ExecuteQuery("spSearchCourseName", CommandType.StoredProcedure,
                new SqlParameter("@CourseName", CourseName));
        }

        public DataTable SearchCourseIDByOpeningAndLevel(string CourseID,string LevelID,DateTime FromDate,DateTime ToDate)
        {
            return da.ExecuteQuery("spSearchCourseIDByOpeningAndLevel", CommandType.StoredProcedure,
                new SqlParameter("@CourseID", CourseID),
                new SqlParameter("@LevelID", LevelID),
                new SqlParameter("@FromDate", FromDate),
                new SqlParameter("@ToDate", ToDate));
        }

        public DataTable SearchCourseNameByOpeningAndLevel(string CourseName, string LevelID, DateTime FromDate, DateTime ToDate)
        {
            return da.ExecuteQuery("spSearchCourseNameByOpeningAndLevel", CommandType.StoredProcedure,
                new SqlParameter("@CourseName", CourseName),
                new SqlParameter("@LevelID", LevelID),
                new SqlParameter("@FromDate", FromDate),
                new SqlParameter("@ToDate", ToDate));
        }

        public DataTable SearchCourseIDByLevel(string CourseID,string LevelID)
        {
            return da.ExecuteQuery("spSearchCourseIDByLevel", CommandType.StoredProcedure,
                new SqlParameter("@CourseID", CourseID),
                new SqlParameter("@LevelID", LevelID));
        }

        public DataTable SearchCourseNameByLevel(string CourseName, string LevelID)
        {
            return da.ExecuteQuery("spSearchCourseNameByLevel", CommandType.StoredProcedure,
                new SqlParameter("@CourseName", CourseName),
                new SqlParameter("@LevelID", LevelID));
        }

        public DataTable SearchCourseIDByOpening(string CourseID, DateTime FromDate, DateTime ToDate)
        {
            return da.ExecuteQuery("spSearchCourseNameByOpening", CommandType.StoredProcedure,
                new SqlParameter("@CourseID", CourseID),
                new SqlParameter("@FromDate", FromDate),
                new SqlParameter("@ToDate", ToDate));
        }

        public DataTable SearchCourseNameByOpening(string CourseName, DateTime FromDate, DateTime ToDate)
        {
            return da.ExecuteQuery("spSearchCourseNameByOpening", CommandType.StoredProcedure,
                new SqlParameter("@CourseName", CourseName),
                new SqlParameter("@FromDate", FromDate),
                new SqlParameter("@ToDate", ToDate));
        }
    }
}
