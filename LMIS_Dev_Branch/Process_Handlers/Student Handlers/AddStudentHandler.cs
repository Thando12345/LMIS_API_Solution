using Dapper;
using LMIS_Dev_Branch.Models;
using LMIS_Dev_Branch.Process_Handler;
using LMIS_Dev_Branch.Process_Handlers.Database;

namespace LMIS_Dev_Branch.Process_Handlers.Student_Handlers
{
    public class AddStudentHandler : IProcessHandler
    {
        private Student StudentDetails { get; set; }
        private List<IModel> ReturnModel { get; set; }

        public AddStudentHandler(Student student)
        {
            this.StudentDetails = student;
            ReturnModel = new List<IModel>();
        }

        public void PerformTask()
        {
            AddStudentToDatabase(this.StudentDetails);
            ReturnModel.Add(new MessagingModel("Student Successfully Added"));
        }
        public List<IModel> GetModel()
        {
            return ReturnModel;
        }


        public void AddStudentToDatabase(Student student)
        {
            DBContext dBContext = new DBContext();

            DynamicParameters dynamicParameters = new DynamicParameters();

            dynamicParameters.Add(this.StudentDetails.FirstName);
            dynamicParameters.Add(this.StudentDetails.LastName);
            dynamicParameters.Add(this.StudentDetails.StudentNumber);

            dBContext.UpdateProcedure("SP_AddStudent", dynamicParameters);




        }
    }
}
