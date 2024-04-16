using Microsoft.AspNetCore.Mvc;

// http://localhost:5000/api/Test
[ApiController]
[Route("api/[controller]")]
public class TestController : ControllerBase
{
    // app.MapGet("/test", () => "Hello world!");
    // http://localhost:5000/api/Test/test
    [HttpGet("test")]
    public string GetHelloWorldText()
    {
        return "Hello world!";
    }

}