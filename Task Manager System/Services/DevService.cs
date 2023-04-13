using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Task_Manager_System.Interfaces;
using TMS_BLL.Models;

namespace Task_Manager_System.Services
{
    public class DevService : BaseService, IDevService
    {
        public DevService()
        {

        }

        public async Task<List<Developer>> GetAll()
        {
            List<Developer> developers = new List<Developer>();
            string selectQuery = "SELECT * FROM DEVELOPERS";

            DataSet ds = await getDataSet(selectQuery);

            DataTable dt = ds.Tables["projects"];

            if (dt.Rows.Count == 0)
                return developers;

            foreach (DataRow row in dt.Rows)
            {
                developers.Add(new Developer()
                {
                    Id = (int)row["DevId"],
                    FirstName = (string)row["FirstName"],
                    LastName = (string)row["LastName"],
                    Specialization = (string)row["Specialization"],
                    Age = (int)row["Age"],
                    Project = new Project() { Id = (int)row["ProjectId"] }
                });
            }
            ds.Dispose();
            return developers;
        }


        public async Task<Developer> GetDeveloperById(int id)
        {
            string selectQuery = "SELECT * FROM developers" +
                                     $" Where DevId = {id}";
            return await GetDeveloper(selectQuery);
        }

        public async Task<Developer> GetDeveloperByLastName(string lastname)
        {
            string selectQuery = "SELECT * FROM developers" +
                                     $" Where LastName = {lastname}";
            return await GetDeveloper(selectQuery);
        }
        private async Task<Developer> GetDeveloper(string query)
        {
            DataSet dataSet = await getDataSet(query);
            DataTable developers = dataSet.Tables["developers"];

            if (developers.Rows.Count == 0)
                return null;

            DataRow row = developers.Rows[0];
            Developer developer = new Developer()
            {
                Id = (int)row["DevId"],
                FirstName = (string)row["FirstName"],
                LastName = (string)row["LastName"],
                Specialization = (string)row["Specialization"],
                Age = (int)row["Age"],
                Project = new Project() { Id = (int)row["ProjectId"] }
            };
            dataSet.Dispose();
            return developer;
        }
    }
}
