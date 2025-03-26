using ToDoList.Application.Repository;
using ToDoList.Communication.Response;

namespace ToDoList.Application.UseCases.Task.Delete;
public class DeleteTaskByIdUseCase
{
    public ResponseDeleteTask Execute(int id)
    {
        var task = TaskRepository.Tasks.FirstOrDefault(t => t.Id == id);

        if (task == null)
        {
            return null;
        }

        TaskRepository.Tasks.Remove(task);

        return new ResponseDeleteTask
        {
            Id = task.Id
        };
    }
}
