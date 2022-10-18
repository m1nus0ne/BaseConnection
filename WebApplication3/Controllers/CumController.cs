using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.Controllers;

[ApiController]
[Route("[controller]")]
public class CumController: Controller
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };
    
    public CumController(){}
    
    [HttpPost]
    public async Task GetTodoItems([FromBody]Item item)
    {
        await ControllerContext.HttpContext.Response.WriteAsJsonAsync(item);
    }
}