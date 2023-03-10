using Application.Handlers.GrammarRequest.Command.CreateGrammar;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GrammarController : ControllerBase
{
    private readonly ISender _sender;

    public GrammarController(ISender sender)
    {
        _sender = sender;
    }

    [HttpPost]
    public IActionResult Create(CreateGrammarRequest request)
    {
        return Ok(_sender.Send(new CreateGrammarCommand() { Request = request}));
    }
}
