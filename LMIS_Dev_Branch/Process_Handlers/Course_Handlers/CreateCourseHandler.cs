using LMIS_Dev_Branch.Models;

namespace LMIS_Dev_Branch.Process_Handler.Course_Handlers
{
    public class CreateCourseHandler : IProcessHandler
    {
        private Null_Course CourseDetails { get; set; }
        private List<IModel> ReturnModel { get; set; }

        public CreateCourseHandler(Null_Course course)
        {
            this.CourseDetails = course;
            ReturnModel = new List<IModel>();
        }

        public void PerformTask()
        {
            //Add Course Details to database using DB Context

            //Add message to list
            ReturnModel.Add(new MessagingModel("Course Successfully Created"));
        }
        public List<IModel> GetModel()
        {
            return ReturnModel;
        }
    }
}
