using ToDoList.Application.Repository;
using ToDoList.Communication.Response;

namespace ToDoList.Application.UseCases.Task.GetAll;
public class GetAllTaskUseCase
{
    public List<ResponseTaskJson> Execute()
    {
        return TaskRepository.Tasks.Select(task => new ResponseTaskJson
        {
            Id = task.Id,
            Name = task.Name,
            Description = task.Description, 
            Priority = task.Priority,
            Dateline = task.Dateline,
            Status = task.Status,
        }).ToList();
    }
}
