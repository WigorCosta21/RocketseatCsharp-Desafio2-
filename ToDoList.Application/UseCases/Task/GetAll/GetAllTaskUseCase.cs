using ToDoList.Application.Repository;
using ToDoList.Communication.Response;

namespace ToDoList.Application.UseCases.Task.GetAll;
public class GetAllTaskUseCase
{
    public List<ResponseAllTaskJson> Execute()
    {
        return TaskRepository.Tasks.Select(task => new ResponseAllTaskJson
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
