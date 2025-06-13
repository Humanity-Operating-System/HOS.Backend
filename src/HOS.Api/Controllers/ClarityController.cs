using System.Runtime.CompilerServices;
using MediatR;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Produces("application/json")]
public class ClarityController : ControllerBase
{
    private readonly ISender _sender;
    public ClarityController(ISender sender)
    {
        _sender = sender;
    }
    [HttpPost]
    public IActionResult Ask([FromBody]string goal)
    {
        var response = _sender.Send(new GetClarityCommand(goal));
        return Ok(response);
    }

    [HttpGet]
    [Route("status")]
    public IActionResult Status()
    {
        return Ok();
    }

    [HttpGet]
    [Route("roadmap")]
    public IActionResult Roadmap()
    {
        return Ok();   
    }
}