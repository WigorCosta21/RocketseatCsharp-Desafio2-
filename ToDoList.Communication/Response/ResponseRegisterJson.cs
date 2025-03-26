using ToDoList.Communication.Enuns;

namespace ToDoList.Communication.Response;
public class ResponseRegisterJson
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public Priority Priority { get; set; }
    public DateTime Dateline { get; set; }
    public Status Status { get; set; }
}
