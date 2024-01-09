using Microsoft.AspNetCore.Mvc;

namespace NetWebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class HelloController : ControllerBase
{
    private readonly ILogger<HelloController> _logger;

    public HelloController(ILogger<HelloController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "SayHowdy")]
    public string Get()
    {
        _logger.LogInformation("Hello Request...");
        return "Hello There ...";
    }
}
