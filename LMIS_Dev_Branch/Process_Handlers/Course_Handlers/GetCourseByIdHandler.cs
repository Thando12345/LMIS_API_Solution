using Dapper;
using LMIS_Dev_Branch.Models;
using LMIS_Dev_Branch.Process_Handlers.Database;
using System.Collections;

namespace LMIS_Dev_Branch.Process_Handler.Course_Handlers
{
    public class GetCourseByIdHandler : IProcessHandler
    {
        private List<Course> CourseDetails { get; set; }

        public Course Course { get; set; }
        private List<IModel> ReturnModel { get; set; }
        private string CourseID { get; set; }


        public GetCourseByIdHandler(string courseID)
        {
           
            // Perform the nessesary instructions to get course code from text passed in
            this.CourseID = courseID;



            this.ReturnModel = new List<IModel>();
            PerformTask();
        }
        public void PerformTask()
        {
            ReturnModel = GetModel();
        }
        public List<IModel> GetModel()
        {
            List<Course> courseList = new List<Course>();
            courseList = GetCoursesFromDatabase();
            this.Course = courseList.Find(c => c.CourseID == CourseID);
            ReturnModel.Add(Course);
            return ReturnModel;
        }

        public List<Course> GetCoursesFromDatabase()
        {
            DBContext dBContext = new DBContext();
            DynamicParameters dynamicParameters = new DynamicParameters();
            dynamicParameters.Add("");
            List<Course> courseList = dBContext.CollectionReturn<Course>("SP_GetAllCourses", dynamicParameters).ToList();
            return courseList;
        }
    }
}
