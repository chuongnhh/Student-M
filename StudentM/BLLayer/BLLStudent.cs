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
    public class BLLStudent
    {
        private daLayer da;
        public BLLStudent()
        {
            da = new daLayer();
        }
        // Get Student
        public DataTable GetAll()
        {
            return da.ExecuteQuery("spGetStudent", CommandType.StoredProcedure, null);
        }

        public DataTable GetByStudentID(string StudentID)
        {
            return da.ExecuteQuery("spGetStudentByStudentID", CommandType.StoredProcedure, 
                new SqlParameter("@StudentID", StudentID));
        }

        public DataTable GetByStudentByCourse(string CourseID)
        {
            return da.ExecuteQuery("spGetStudentByCourse", CommandType.StoredProcedure,
                new SqlParameter("@CourseID", CourseID));
        }

        // Insert Student
        public bool Insert(ref string error, string StudentID, string StudentName, string Gender,
            DateTime Birthday, string PhoneNumber,string Email,string Staying, string Address, string Education,string University)
        {
            return da.ExcuteNoneQuery("spInsertStudent", CommandType.StoredProcedure, ref error,
                new SqlParameter("@StudentID", StudentID),
                new SqlParameter("@StudentName", StudentName),
                new SqlParameter("@Gender", Gender),
                new SqlParameter("@Birthday", Birthday),
                new SqlParameter("@PhoneNumber", PhoneNumber),
                new SqlParameter("@Email", Email),
                new SqlParameter("@Staying", Staying),
                new SqlParameter("@Address", Address),
                new SqlParameter("@Education", Education),
                new SqlParameter("@University", University));
        }

        // Update Student
        public bool Update(ref string error, string StudentID, string StudentName, string Gender,
           DateTime Birthday, string PhoneNumber, string Email, string Staying, string Address, string Education, string University)
        {
            return da.ExcuteNoneQuery("spUpdateStudent", CommandType.StoredProcedure, ref error,
                new SqlParameter("@StudentID", StudentID),
                new SqlParameter("@StudentName", StudentName),
                new SqlParameter("@Gender", Gender),
                new SqlParameter("@Birthday", Birthday),
                new SqlParameter("@PhoneNumber", PhoneNumber),
                new SqlParameter("@Email", Email),
                new SqlParameter("@Staying", Staying),
                new SqlParameter("@Address", Address),
                new SqlParameter("@Education", Education),
                new SqlParameter("@University", University));
        }

        public bool Delete(ref string error, string StudentID)
        {
            return da.ExcuteNoneQuery("spDeleteStudent", CommandType.StoredProcedure, ref error,
                new SqlParameter("@StudentID", StudentID));
        }

        //Search Student no Course
        public DataTable SearchStudentID(string StudentID)
        {
            return da.ExecuteQuery("spSearchStudentID", CommandType.StoredProcedure, new SqlParameter("@StudentID", StudentID));
        }

        public DataTable SearchStudentName(string StudentName)
        {
            return da.ExecuteQuery("spSearchStudentName", CommandType.StoredProcedure, new SqlParameter("@StudentName", StudentName));
        }
        public DataTable SearchStudentPhoneNumber(string PhoneNumber)
        {
            return da.ExecuteQuery("spSearchStudentPhoneNumber", CommandType.StoredProcedure, new SqlParameter("@PhoneNumber", PhoneNumber));
        }


        // Search Student wwith Course
        public DataTable SearchStudentIDByCourse(string StudentID, string CourseID)
        {
            return da.ExecuteQuery("spSearchStudentIDByCourse", CommandType.StoredProcedure,
                new SqlParameter("@StudentID", StudentID),
                new SqlParameter("@CourseID", CourseID));
        }

        public DataTable SearchStudentNameByCourse(string StudentName, string CourseID)
        {
            return da.ExecuteQuery("spSearchStudentNameByCourse", CommandType.StoredProcedure,
                new SqlParameter("@StudentName", StudentName),
                new SqlParameter("@CourseID", CourseID));
        }

        public DataTable SearchStudentPhoneNumberByCourse(string PhoneNumber, string CourseID)
        {
            return da.ExecuteQuery("spSearchPhoneNumberByCourse", CommandType.StoredProcedure,
                new SqlParameter("@PhoneNumber", PhoneNumber),
                new SqlParameter("@CourseID", CourseID));
        }
    }
}
