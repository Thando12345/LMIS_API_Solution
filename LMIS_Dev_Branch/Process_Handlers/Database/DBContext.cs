using System.Collections;
using System.Collections.Generic;
using Dapper;
using System.Data.SqlClient;
using System.Data;
using System.Data.Common;
using Microsoft.Extensions.Configuration;
namespace LMIS_Dev_Branch.Process_Handlers.Database
{
    public class DBContext
    {
        private string _connectionString = string.Empty;

        public DBContext()
        {
            var configuration = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory()) 
                 .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true) 
                 .Build();

            _connectionString = configuration.GetConnectionString("DefaultConnection");
        
        }
        public void UpdateProcedure(string storedProcName, DynamicParameters dynamicParameters)
        {
            using (IDbConnection dbConnection = new SqlConnection(_connectionString))
            {
                dbConnection.Open();
                dbConnection.Execute(storedProcName, dynamicParameters, commandType: CommandType.StoredProcedure);
            }
        }

        public List<T> CollectionReturn<T>(string storedProcName, DynamicParameters dynamicParameters)
        {

            using (IDbConnection dbConnection = new SqlConnection(_connectionString))
            {
                dbConnection.Open();
                var result = dbConnection.Query<T>(storedProcName, dynamicParameters, commandType: CommandType.StoredProcedure);
                return result.AsList();
            }
        }

    }
}
