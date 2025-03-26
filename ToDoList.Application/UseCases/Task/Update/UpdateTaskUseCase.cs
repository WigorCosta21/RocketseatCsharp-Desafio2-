using ToDoList.Application.Repository;
using ToDoList.Communication.Request;
using ToDoList.Communication.Response;

namespace ToDoList.Application.UseCases.Task.Update;
public class UpdateTaskUseCase
{
    public ResponseTaskJson Execute(int id, RequestUpdateTaskJson request)
    {
        var task = TaskRepository.Tasks.FirstOrDefault(t => t.Id == id);  
        
        if (task == null)
        {
            return null;
        }

        task.Name = request.Name;
        task.Description = request.Description;
        task.Priority = request.Priority;
        task.Dateline = request.Dateline;
        task.Status = request.Status;

        return new ResponseTaskJson
        {
            Id = id,
            Name = request.Name,
            Description = request.Description,
            Priority = request.Priority,
            Dateline = request.Dateline,
            Status = request.Status,
        };

    }
}
