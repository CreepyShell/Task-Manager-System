using System;
using System.Collections.Generic;
using TMS_BLL.Models;

namespace Task_Manager_System
{
    public class TasksDb
    {
        private static TasksDb tasksDb;
        public static TasksDb GetTasksDb()
        {
            if (tasksDb == null)
                tasksDb = new TasksDb();
            return tasksDb;
        }
        private TasksDb()
        {
            Developers = new List<Developer>();
            Tasks = new List<Task>();
            Projects = new List<Project>();
            InstertDefaultValues();
        }
        public List<Developer> Developers { get; set; }
        public List<Task> Tasks { get; set; }
        public List<Project> Projects { get; set; }

        private void InstertDefaultValues()
        {

            Project project = new Project();
            project.Id = 1;
            project.Status = Status.Extended;
            project.Name = "BotNet";
            project.Description = "Secret";
            project.StartDate = DateTime.Today;
            project.EndDate = DateTime.Today.AddMonths(3);
            project.ExpectedCost = 100000;

            Project project2 = new Project();
            project2.Id = 2;
            project2.Status = Status.Started;
            project2.Name = "Online shop";
            project2.Description = "Food shop";
            project2.StartDate = DateTime.Today;
            project2.EndDate = DateTime.Today.AddMonths(2);
            project2.ExpectedCost = 1000;

            Project project3 = new Project();
            project3.Id = 3;
            project3.Status = Status.Extended;
            project3.Name = "Calculator";
            project3.Description = "Math calculator";
            project3.StartDate = DateTime.Today;
            project3.EndDate = DateTime.Today.AddDays(14);
            project3.ExpectedCost = 5000;

            Project project4 = new Project();
            project4.Id = 4;
            project4.Status = Status.Finished;
            project4.Name = "Generator";
            project4.Description = "This project should generate random number from 1 to 1000";
            project4.StartDate = new DateTime(2021, 11, 24, 16, 52, 22);
            project4.EndDate = project.StartDate.AddDays(1);
            project4.ExpectedCost = 15000;

            Project project5 = new Project();
            project5.Id = 5;
            project5.Status = Status.Started;
            project5.Name = "Airplane system";
            project5.Description = "Develop Airplane system for Ryanair";
            project5.StartDate = DateTime.Today;
            project5.EndDate = DateTime.Today.AddMonths(3);
            project5.ExpectedCost = 10000;
            this.Projects.AddRange(new Project[] { project, project2, project3, project4, project5 });


            Developer developer = new Developer();
            developer.Id = 1;
            developer.Age = 22;
            developer.Specialization = ".Net";
            developer.FirstName = "Andrew";
            developer.LastName = "";

            Developer developer2 = new Developer();
            developer2.Id = 2;
            developer2.Age = 25;
            developer2.Specialization = "Java";
            developer2.FirstName = "Mike";
            developer2.LastName = "";

            Developer developer3 = new Developer();
            developer3.Id = 3;
            developer3.Age = 30;
            developer3.Specialization = "Sql";
            developer3.FirstName = "David";
            developer3.LastName = "";

            Developer developer4 = new Developer();
            developer4.Id = 4;
            developer4.Age = 27;
            developer4.Specialization = "C++";
            developer4.FirstName = "John";
            developer4.LastName = "";
            developer4.Project = project;

            this.Developers.AddRange(new Developer[] { developer, developer2, developer3, developer4 });


            Task task = new Task();
            task.Id = 1;
            task.Name = "Downaload c++";
            task.Status = Status.Extended;
            task.StartDate = DateTime.Now;
            task.Project = project5;
            task.Hours = 20;
            task.Developer = developer;
            task.Description = "Download c++ from official site";

            Task task2 = new Task();
            task2.Id = 2;
            task2.Name = "Finish adding item";
            task2.Status = Status.Started;
            task2.Project = project2;
            task2.StartDate = DateTime.Now.AddDays(1);
            task2.Hours = 10;
            task2.Description = "Finish adding item";
            task2.Developer = developer3;

            Task task3 = new Task();
            task3.Id = 3;
            task3.Name = "Downaload java";
            task3.Status = Status.Extended;
            task3.Project = project;
            task3.Hours = 30;
            task3.StartDate = new DateTime(2021, 11, 24, 16, 52, 22);
            task3.Description = "Download java from official site";
            task3.Developer = developer4;
            this.Tasks.AddRange(new Task[] { task, task2, task3 });
        }
    }
}
