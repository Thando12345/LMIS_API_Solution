using LMIS_Dev_Branch.Models;
using Dapper;
using System.Data.SqlClient;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
namespace LMIS_Dev_Branch.Process_Handler

{
    public interface IProcessHandler
    {
        public void PerformTask();
        public List<IModel> GetModel();

    }
}
