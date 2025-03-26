using Microsoft.AspNetCore.Mvc;
using ToDoList.Application.UseCases.Task.GetAll;
using ToDoList.Application.UseCases.Task.Register;
using ToDoList.Communication.Request;
using ToDoList.Communication.Response;

namespace ToDoList.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TaskController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisterJson), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ResponseRegisterJson), StatusCodes.Status400BadRequest)]
    public IActionResult Register([FromBody] RequestTaskJson request)
    {
        var useCase = new RegisterTaskUseCase();

        var response = useCase.Execute(request);

        return Created(string.Empty, response);
    }

    [HttpGet]
    [ProducesResponseType(typeof(ResponseAllTaskJson), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult GetAll()
    {
        var useCase = new GetAllTaskUseCase();

        var response = useCase.Execute();

        if(response.Any())
        {
            return Ok(response);
        }

        return NoContent();
    }
}
