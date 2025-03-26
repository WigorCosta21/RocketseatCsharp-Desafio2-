using ToDoList.Application.Repository;
using ToDoList.Communication.Response;

namespace ToDoList.Application.UseCases.Task.GetById;
public class GetByIdTaskUseCase
{
    public ResponseTaskJson? Execute(int id)
    {
        var task = TaskRepository.Tasks.FirstOrDefault(t => t.Id == id);

        if (task == null)
        {
            return null;
        }

        return new ResponseTaskJson
        {
            Id = task.Id,
            Name = task.Name,
            Description = task.Description,
            Priority = task.Priority,
            Dateline = task.Dateline,
            Status = task.Status,
        };
    }
}
