using System;
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

            DataSet ds = await ExecuteQuery(selectQuery);

            DataTable dt = ds.Tables[0];

            if (dt.Rows.Count == 0)
                return developers;

            foreach (DataRow row in dt.Rows)
            {
                developers.Add(new Developer()
                {
                    Id = row.Field<short>(0),
                    FirstName = row.Field<string>(1),
                    LastName = row.Field<string>(2),
                    Specialization = row.Field<string>(3),
                    Age = row.Field<short>(4),
                    Project = row.IsNull(5) ? null : new Project() { Id = row.Field<short>(5) }
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

        public async Task<Developer> GetDeveloperWithProject(int devId)
        {
            string query = "SELECT * FROM DEVELOPERS LEFT JOIN PROJECTS ON DEVELOPERS.PROJECTID = PROJECTS.PROJID WHERE DEVELOPERS.DEVID = " + devId;
            DataSet dataSet = await ExecuteQuery(query);
            DataTable developers = dataSet.Tables[0];
            if (developers.Rows.Count == 0)
                return null;

            DataRow row = developers.Rows[0];
            Developer developer = new Developer()
            {
                Id = row.Field<short>(0),
                FirstName = row.Field<string>(1),
                LastName = row.Field<string>(2),
                Specialization = row.Field<string>(3),
                Age = row.Field<short>(4),
                Project = row.IsNull(5) ? null : new Project()
                {
                    Id = row.Field<short>(5),
                    Name = row.Field<string>(7),
                    Status = (Status)Enum.Parse(typeof(Status), row.Field<string>(11)),
                    StartDate = row.Field<DateTime>(9),
                    EndDate = row.Field<DateTime>(10),
                }
            };
            dataSet.Dispose();

            return developer;
        }

        private async Task<Developer> GetDeveloper(string query)
        {
            DataSet dataSet = await ExecuteQuery(query);
            DataTable developers = dataSet.Tables[0];

            if (developers.Rows.Count == 0)
                return null;

            DataRow row = developers.Rows[0];
            Developer developer = new Developer()
            {
                Id = row.Field<short>(0),
                FirstName = row.Field<string>(1),
                LastName = row.Field<string>(2),
                Specialization = row.Field<string>(3),
                Age = row.Field<short>(4),
                Project = row.IsNull(5) ? null : new Project() { Id = row.Field<short>(5) }
            };
            dataSet.Dispose();
            return developer;
        }
    }
}
