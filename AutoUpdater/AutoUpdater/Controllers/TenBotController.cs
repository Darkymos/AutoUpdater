using Microsoft.AspNetCore.Mvc;

namespace AutoUpdater.Controllers;
[ApiController, Route("tenbot")]
public class TenBotController : ControllerBase
{
    [HttpPost("update")]
    public async Task<ActionResult> Update()
    {
        Console.WriteLine("Updating...");

        await Task.CompletedTask;

        return Ok();
    }
}
