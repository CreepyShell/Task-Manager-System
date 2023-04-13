using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Threading.Tasks;

namespace Task_Manager_System.Services
{
    public class BaseService
    {
        protected async Task insertQuery(string sqlQuery)
        {
            using (OracleConnection connection = new OracleConnection(DbConnect.oradb))
            {
                await connection.OpenAsync();

                OracleCommand command = new OracleCommand(sqlQuery, connection);
                int res = await command.ExecuteNonQueryAsync();

                OracleTransaction transaction = connection.BeginTransaction();
                transaction.Commit();

                command.Dispose();
                connection.Close();
            }
        }

        protected async Task<DataSet> getDataSet(string sqlQuery)
        {
            using (OracleConnection connection = new OracleConnection(DbConnect.oradb))
            {
                await connection.OpenAsync();

                OracleDataAdapter adapter = new OracleDataAdapter(sqlQuery, connection);

                DataSet ds = new DataSet(); 
                adapter.Fill(ds);

                connection.Close();
                return ds;
            }
        }
    }
}
