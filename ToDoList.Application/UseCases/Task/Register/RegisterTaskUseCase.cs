using ToDoList.Application.Domain;
using ToDoList.Application.Repository;
using ToDoList.Communication.Request;
using ToDoList.Communication.Response;

namespace ToDoList.Application.UseCases.Task.Register;
public class RegisterTaskUseCase
{
    public ResponseRegisterJson Execute(RequestTaskJson request)
    {
        var task = new TaskItem
        {
            Id = request.Id,
            Name = request.Name,
            Description = request.Description,
            Priority = request.Priority,
            Dateline = request.Dateline,
            Status = request.Status,
        };

        TaskRepository.Tasks.Add(task);

        return new ResponseRegisterJson
        {
            Id = request.Id,
            Name = request.Name,
            Description = request.Description,
            Priority = request.Priority,
            Dateline = request.Dateline,
            Status = request.Status,
        };
    }
}
