using Domain.LessonBoundaryModel;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LessonController : ControllerBase
{
    [HttpGet]
    public Lesson Get(long id)
    {
        var lesson = new Lesson
        {
            Id = id,
            Title = "Lesson 1",
            Description = "Description 1"
        };

        return lesson;
    }

    [HttpPost]
    public IActionResult Post(Request request)
    {
        return Ok(request);
    }
}

public class Request
{
    public string Name { get; set; }
}
