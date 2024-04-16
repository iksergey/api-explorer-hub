using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class HelloController : ControllerBase
{
    //app.MapGet("/hello/{name}", (string name) => $"Привет, {name}!");
    // http://localhost:5000/api/Test/hello/{name}
    [HttpGet("hello/{name}")]
    public string GetGreetingByName(string name)
    {
        return $"Привет, {name}!";
    }
}