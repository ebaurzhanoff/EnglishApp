using Application.Handlers.CourseRequest.Queries.GetAll;
using Application.Handlers.GrammarRequest.Command.CreateGrammar;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CourseController : ControllerBase
{
    private readonly ISender _sender;

    public CourseController(ISender sender)
    {
        _sender = sender;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await _sender.Send(new GetAllCourseQuery()));
    }
}
