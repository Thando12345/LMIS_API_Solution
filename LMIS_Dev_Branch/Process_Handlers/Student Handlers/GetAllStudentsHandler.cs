using Dapper;
using System.Collections;
using System.Collections.Generic;
using LMIS_Dev_Branch.Models;
using LMIS_Dev_Branch.Process_Handler;
using LMIS_Dev_Branch.Process_Handlers.Database;

namespace LMIS_Dev_Branch.Process_Handlers.Student_Handlers
{
    public class GetAllStudentsHandler : IProcessHandler
    {
        public List<IModel> ReturnModel { get; set; }
        public GetAllStudentsHandler()
        {
            ReturnModel = new List<IModel>();
        }
        public void PerformTask()
        {
            ReturnModel = GetModel();
        }
        public List<IModel> GetModel()
        {
            List<Student> studentList = new List<Student>();
            studentList = GetStudentsFromDatabase();

            foreach (Student student in studentList)
            {
                ReturnModel.Add(student);
            }

            return ReturnModel;
        }
        public List<Student> GetStudentsFromDatabase()
        {
            DBContext dBContext = new DBContext();
            DynamicParameters dynamicParameters = new DynamicParameters();
            dynamicParameters.Add("");
            List<Student> studentList = dBContext.CollectionReturn<Student>("SP_GetAllStudents", dynamicParameters).ToList();
            return studentList;
        }
    }
}
