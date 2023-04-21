using System.Collections.Generic;
using System.Threading.Tasks;

namespace TMS_BLL.Interfaces
{
    public interface ITaskService : IBasicInterface<Models.Task>
    {
        /// <summary>
        /// Add task to the system
        /// </summary>
        /// <param name="newTask">New task entity</param>
        /// <returns>True if added successfully</returns>
        Task<bool> AddTaskToProject(Models.Task newTask);
        /// <summary>
        /// Update task in the system
        /// </summary>
        /// <param name="idUpdatedTask">Old task id</param>
        /// <param name="updatedTask">Updated task details</param>
        /// <returns>Updated task</returns>
        Task<Models.Task> UpdateTask(int idUpdatedTask, Models.Task updatedTask);
        /// <summary>
        /// Delete task from the system
        /// </summary>
        /// <param name="taskId">Task id to remove</param>
        /// <returns>True, if removed successfully, false if a developer was assigned to a task</returns>
        Task<bool> RemoveTaskFromProject(int taskId);
        /// <summary>
        /// Assign developer to task
        /// </summary>
        /// <param name="taskId">Task id to assign</param>
        /// <param name="devId">Developer id</param>
        /// <returns>True if task was assigned to a developer successfully, false if task is already assigned to a developer</returns>
        Task<bool> AssignDeveloperToTask(int taskId, int devId);
        /// <summary>
        /// Remvoe developer from a task
        /// </summary>
        /// <param name="taskId">Task id to remove</param>
        /// <param name="devId">Developer id</param>
        /// <returns>True if task was removed successfully, false if task has no developer assigned to it or task has another developer assigned to it (not chosen one)</returns>
        Task<bool> RemoveDeveloperFromTask(int taskId, int devId);
        /// <summary>
        /// Complete task
        /// </summary>
        /// <param name="taskId">Task id to complete</param>
        /// <returns>True, if complete successfully, false if task is already finished</returns>
        Task<bool> CompleteTask(int taskId);
        /// <summary>
        /// Get all tasks that do not have finished status and have no developer assigned to it
        /// </summary>
        /// <returns>List of tasks</returns>
        Task<List<Models.Task>> GetUnassignedAndUnfinishedTasks();
        /// <summary>
        /// Get all tasks that assigned to one project
        /// </summary>
        /// <param name="projId">Project id</param>
        /// <returns>List of tasks added to a project</returns>
        Task<List<Models.Task>> GetAllProjectTasks(int projId);
        /// <summary>
        /// Get all tasks that assigned to one developer
        /// </summary>
        /// <param name="devId">Developer id</param>
        /// <returns>List of tasks assigned to a developer</returns>
        Task<List<Models.Task>> GetDeveloperTasks(int devId);
    }
}
