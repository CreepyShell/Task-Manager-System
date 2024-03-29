﻿using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Threading.Tasks;

namespace Task_Manager_System.Services
{
    public class BaseService
    {
        protected async Task ExecuteNonQuery(string sqlQuery)
        {
            using (OracleConnection connection = new OracleConnection(DbConnect.oradb))
            {
                await connection.OpenAsync();

                OracleCommand command = new OracleCommand(sqlQuery, connection);
                int res = await command.ExecuteNonQueryAsync();

                OracleTransaction transaction = connection.BeginTransaction();
                transaction.Commit();

                transaction.Dispose();
                command.Dispose();
                connection.Close();
            }
        }

        protected async Task<DataSet> ExecuteQuery(string sqlQuery)
        {
            using (OracleConnection connection = new OracleConnection(DbConnect.oradb))
            {
                await connection.OpenAsync();

                OracleDataAdapter adapter = new OracleDataAdapter(sqlQuery, connection);

                DataSet ds = new DataSet(); 
                adapter.Fill(ds);

                adapter.Dispose();
                connection.Close();
                return ds;
            }
        }
    }
}
