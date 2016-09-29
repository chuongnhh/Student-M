using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALayer;
using System.Data.SqlClient;
using System.Data;

namespace BLLayer
{
    public class BLLTranscript
    {
        private daLayer da;
        public BLLTranscript()
        {
            da = new daLayer();
        }

        public bool DeleteByStudent(ref string error, string StudentID)
        {
            return da.ExcuteNoneQuery("spDeleteTranscriptByStudent", CommandType.StoredProcedure, ref error,
                new SqlParameter("@StudentID", StudentID));
        }

        public bool DeleteByCourse(ref string error, string CourseID)
        {
            return da.ExcuteNoneQuery("spDeleteTranscriptByCourse", CommandType.StoredProcedure, ref error,
                new SqlParameter("@CourseID", CourseID));
        }
    }
}
